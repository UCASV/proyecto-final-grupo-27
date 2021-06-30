using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationProject.Context;
using VaccinationProject.Controller.Services;

namespace VaccinationProject.View
{
    public partial class frmReservation : Form
    {
        private ReservationServices Reservation= new ReservationServices();
        private CitizenServices Citizen = new CitizenServices();
        private BoothServices Booth = new BoothServices();
        private ChronicDiseaseServices cDisease = new ChronicDiseaseServices();
        public Manager manager { get; set; }
        public frmReservation(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string patternDUI = @"^\d{8}-\d{1}$", patternPhone = @"^\d{4}-\d{4}$", patternEmail = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Citizen person = new Citizen();
            person.CitizenName = txtName.Text;
            person.CitizenAddress = txtAdress.Text;
            person.Email = txtEmail.Text;
            person.PhoneNumber = txtPhoneN.Text;
            person.Dui = txtDui.Text;
            person.IdManager = manager.Id;
            int age;
            if (txtAge.Text == "")
            {
                age = -1;
            }
            else
            {
                age = Convert.ToInt32(txtAge.Text);
            }
           
            if (txtId.Text == "" && age < 60)
            {
                MessageBox.Show("El ciudadano no cumple con los requisitos necesarios para ser vacunado", "Ministerio de Salud",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Reservation reserve = new Reservation();
            Random r = new Random();

            Booth boo = new Booth();
            boo = Booth.GetById(boo.Id = (r.Next(1, 11)));

            

            if (person.CitizenName == "" || person.CitizenAddress == "" || person.PhoneNumber == "" || person.Dui == "" || age == -1)
            {
                MessageBox.Show("Rellene todos los campos para iniciar sesion correctamente", "Ministerio de Salud",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(person.Dui, patternDUI))
            {
                MessageBox.Show("El numero de DUI ingresado es invalido", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(person.PhoneNumber, patternPhone))
            {
                MessageBox.Show("El numero de telefono ingresado es invalido", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (person.Email != null && !Regex.IsMatch(person.Email, patternEmail))
            {

                    MessageBox.Show("La direccion de correo electronico ingresado es invalido", "Ministerio de Salud",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
               if(Citizen.Comprobation(person.Dui, person.PhoneNumber, person.Email) != null)
                {
                    MessageBox.Show("DUI, Teléfono o Correo Electrónico repetidos en la base de datos", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (age >= 60 && age <= 120)
                    {
                        if (txtId.Text == "")
                        {
                            person.IdPriorityGroup = 1;
                            person.NumIdentifier = null;
                            Citizen.Create(person);
                            Citizen.Save();

                            reserve.DuiCitizen = person.Dui;

                            var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                            List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                            int hour = r.Next(7, 24);
                            int index = r.Next(minutes.Count);
                            string min = minutes[index];
                            reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}");  //se crea de manera aleatoria la fecha y hora de la reserva

                            reserve.VaccinationPlace = boo.Place;
                            Reservation.Create(reserve);
                            Reservation.Save();
                            if (!(txtChronicDisease.Text == ""))
                            {
                                string phrase = txtChronicDisease.Text;
                                string[] words = phrase.Split(',');

                                foreach (var w in words)
                                {
                                    ChronicDisease cdis = new ChronicDisease();
                                    cdis.DuiCitizen = person.Dui;
                                    cdis.ChronicDisease1 = w;
                                    cDisease.Create(cdis);
                                    cDisease.Save();
                                }
                               
                            }
                            MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else if (txtId.Text != "")
                        {
                            person.NumIdentifier = Convert.ToInt32(txtId.Text);
                            person.IdPriorityGroup = 1;
                            Citizen.Create(person);
                            Citizen.Save();

                            reserve.DuiCitizen = person.Dui;

                            var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                            List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                            int hour = r.Next(7, 24);
                            int index = r.Next(minutes.Count);
                            string min = minutes[index];
                            reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}"); //se crea de manera aleatoria la fecha y hora de la reserva

                            reserve.VaccinationPlace = boo.Place;
                            Reservation.Create(reserve);
                            Reservation.Save();
                            if (!(txtChronicDisease.Text == ""))
                            {
                                string phrase = txtChronicDisease.Text;
                                string[] words = phrase.Split(',');

                                foreach (var w in words)
                                {
                                    ChronicDisease cdis = new ChronicDisease();
                                    cdis.DuiCitizen = person.Dui;
                                    cdis.ChronicDisease1 = w;
                                    cDisease.Create(cdis);
                                    cDisease.Save();
                                } 
                            }
                            MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }

                    }
					else if (!(txtChronicDisease.Text == "") && age < 60 && age >= 18)
                    {
                        person.NumIdentifier = Convert.ToInt32(txtId.Text);
                        person.IdPriorityGroup = 4;
                        Citizen.Create(person);
                        Citizen.Save();

                        reserve.DuiCitizen = person.Dui;

                        var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                        List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                        int hour = r.Next(7, 24);
                        int index = r.Next(minutes.Count);
                        string min = minutes[index];
                        reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}"); //se crea de manera aleatoria la fecha y hora de la reserva

                        reserve.VaccinationPlace = boo.Place;
                        Reservation.Create(reserve);
                        Reservation.Save();
                        if (!(txtChronicDisease.Text == ""))
                        {
                            string phrase = txtChronicDisease.Text;
                            string[] words = phrase.Split(',');

                            foreach (var w in words)
                            {
                                ChronicDisease cdis = new ChronicDisease();
                                cdis.DuiCitizen = person.Dui;
                                cdis.ChronicDisease1 = w;
                                cDisease.Create(cdis);
                                cDisease.Save();
                            }
                        }
                        MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else if (!(txtId.Text == "") && age < 60 && age >= 18)
                    {
                        person.NumIdentifier = Convert.ToInt32(txtId.Text);
                        person.IdPriorityGroup = Convert.ToInt32(txtId.Text[0].ToString());
                        Citizen.Create(person);
                        Citizen.Save();

                        reserve.DuiCitizen = person.Dui;

                        var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                        List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                        int hour = r.Next(7, 24);
                        int index = r.Next(minutes.Count);
                        string min = minutes[index];
                        reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}"); //se crea de manera aleatoria la fecha y hora de la reserva

                        reserve.VaccinationPlace = boo.Place;
                        Reservation.Create(reserve);
                        Reservation.Save();
                        if (!(txtChronicDisease.Text == ""))
                        {
                            string phrase = txtChronicDisease.Text;
                            string[] words = phrase.Split(',');

                            foreach (var w in words)
                            {
                                ChronicDisease cdis = new ChronicDisease();
                                cdis.DuiCitizen = person.Dui;
                                cdis.ChronicDisease1 = w;
                                cDisease.Create(cdis);
                                cDisease.Save();
                            }
                        }
                        MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }  
            }
        }
    }
}
