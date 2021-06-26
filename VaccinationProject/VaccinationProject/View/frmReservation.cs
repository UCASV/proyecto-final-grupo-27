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
            string patternDUI = @"^\d{8}-\d{1}$", patternPhone = @"^\d{4}-\d{4}$", patternEmail = "^[^@\\s]+@[^@\\s\\.]+\\.[^@\\s\\.]+(\\.[^@\\s\\.])?$";
            Citizen person = new Citizen();
            person.CitizenName = txtName.Text;
            person.CitizenAddress = txtAdress.Text;
            person.Email = txtEmail.Text;
            person.PhoneNumber = txtPhoneN.Text;
            person.Dui = txtDui.Text;
            person.IdManager = manager.Id;
            var age = 0;
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

            else if (txtId.Text == "" && age >=60)
            {
                person.NumIdentifier = null;

            }

            Reservation reserve = new Reservation();
            Random r = new Random();

            Booth boo = new Booth();
            boo = Booth.GetById(boo.Id = (r.Next(1, 11)));

            ChronicDisease cdis = new ChronicDisease();

            if (person.CitizenName == "" || person.CitizenAddress == "" || person.PhoneNumber == "" || person.Dui == "" || age == -1)
            {
                MessageBox.Show("Rellene todos los campos para iniciar sesion correctamente", "Ministerio de Salud",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Regex.IsMatch(person.Dui, patternDUI))
            {
                MessageBox.Show("El numero de DUI ingresado es invalido", "Ministerio de Salud", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Regex.IsMatch(person.PhoneNumber, patternPhone))
            {
                MessageBox.Show("El numero de telefono ingresado es invalido", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (person.Email != null)
            {
                if (!Regex.IsMatch(person.Email, patternEmail))
                {
                    MessageBox.Show("La direccion de correo electronico ingresado es invalido", "Ministerio de Salud",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               if (age >= 60)
                {
                    person.IdPriorityGroup = 1;
                    Citizen.Create(person);
                    Citizen.Save();

                    reserve.DuiCitizen = person.Dui;
                    reserve.DateReservation = DateTime.Now.AddDays(r.Next(5, 10));
                    reserve.VaccinationPlace = boo.Place;
                    Reservation.Create(reserve);
                    Reservation.Save();
                    if (!(txtChronicDisease.Text == ""))
                    {
                        cdis.DuiCitizen = person.Dui;
                        cdis.ChronicDisease1 = txtChronicDisease.Text;
                        cDisease.Create(cdis);
                    }
                    MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
               else if (!(txtId.Text == "" && age < 60))
                {
                    person.NumIdentifier = Convert.ToInt32(txtId.Text);
                    person.IdPriorityGroup = Convert.ToInt32(txtId.Text[0].ToString());
                    Citizen.Create(person);
                    Citizen.Save();

                    reserve.DuiCitizen = person.Dui;
                    reserve.DateReservation = DateTime.Now.AddDays(r.Next(5, 10));
                    reserve.VaccinationPlace = boo.Place;
                    Reservation.Create(reserve);
                    Reservation.Save();
                    if (!(txtChronicDisease.Text == ""))
                    {
                        cdis.DuiCitizen = person.Dui;
                        cdis.ChronicDisease1 = txtChronicDisease.Text;
                        cDisease.Create(cdis);
                    }
                    MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }
    }
}
