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
		// Atributos a utilizar en este formulario y que se enviaran como refencia a otros.
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
            if (txtAge.Text == "") // Si se deja en blanco la edad se asigna un -1 para poder mostrar un mensaje de error mas adelante
            {
                age = -1;
            }
            else
            {
                age = Convert.ToInt32(txtAge.Text);
            }
           
            if (txtId.Text == "" && age < 60) // Si no pertenece a ningun grupo prioritario muestra un mensaje de error.
            {
                MessageBox.Show("El ciudadano no cumple con los requisitos necesarios para ser vacunado", "Ministerio de Salud",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Reservation reserve = new Reservation();
            Random r = new Random();

            Booth boo = new Booth();
            boo = Booth.GetById(boo.Id = (r.Next(1, 11))); // Se obtiene una Cabina de forma aleatoria para asignar su direccion mas adelante a la reservacion creada.

            
			// Si deja algun campo vacio de los que no pueden dejarse vacio, muestra un mensaje de error.
            if (person.CitizenName == "" || person.CitizenAddress == "" || person.PhoneNumber == "" || person.Dui == "" || age == -1)
            {
                MessageBox.Show("Rellene todos los campos para iniciar sesion correctamente", "Ministerio de Salud",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(person.Dui, patternDUI)) // Si no tiene el formato adecuado el DUI muestra mensaje de error.
            {
                MessageBox.Show("El numero de DUI ingresado es invalido", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(person.PhoneNumber, patternPhone)) // Si no tiene el formato adecuado el telefono muestra mensaje de error.
            {
                MessageBox.Show("El numero de telefono ingresado es invalido", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (person.Email != null && !Regex.IsMatch(person.Email, patternEmail)) // Si no tiene el formato adecuado el correo muestra mensaje error.
            {

                    MessageBox.Show("La direccion de correo electronico ingresado es invalido", "Ministerio de Salud",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
               if(Citizen.Comprobation(person.Dui, person.PhoneNumber, person.Email) != null) // Si el DUI o correo existeb con anterioridad mustra mensaje de error. 
                {
                    MessageBox.Show("DUI, Teléfono o Correo Electrónico repetidos en la base de datos", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (age >= 60 && age <= 120) // Si la persona tiene mas de 60 años.
                    {
                        if (txtId.Text == "") // Si no fue brindado un identificador especial, se le asigna el grupo de prioridad con id 1 (Mayor de 60 años)
                        {
                            person.IdPriorityGroup = 1; // Se agrega el ciudadano a la DB.
                            person.NumIdentifier = null;
                            Citizen.Create(person);
                            Citizen.Save();

                            reserve.DuiCitizen = person.Dui; // Se asigna la FK a la reservacion.

                            var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                            List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                            int hour = r.Next(7, 24);
                            int index = r.Next(minutes.Count);
                            string min = minutes[index];
                            reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}");  //se crea de manera aleatoria la fecha y hora de la reserva

                            reserve.VaccinationPlace = boo.Place;
                            Reservation.Create(reserve);
                            Reservation.Save(); // Se agrega la resrva a la DB.
                            if (!(txtChronicDisease.Text == "")) // Si se agregaron una o mas enfermedades.
                            {
                                string phrase = txtChronicDisease.Text;
                                string[] words = phrase.Split(','); // Se parte la cadena de texto con la lista de enfermedades.

                                foreach (var w in words)
                                {
                                    ChronicDisease cdis = new ChronicDisease();
                                    cdis.DuiCitizen = person.Dui;
                                    cdis.ChronicDisease1 = w;
                                    cDisease.Create(cdis);
                                    cDisease.Save(); // Se guarda una a una la enfermedad.
                                }
                               
                            }
                            MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else if (txtId.Text != "") // Si brindo un nurmero identificador siendo mayor de 60 años de igual manera se le asigna el grupo de prioridad con id 1 (Mayor de 60 años)
                        {
                            person.NumIdentifier = Convert.ToInt32(txtId.Text);
                            person.IdPriorityGroup = 1;
                            Citizen.Create(person);
                            Citizen.Save(); // Se guarda en la DB al ciudadano.

                            reserve.DuiCitizen = person.Dui;

                            var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                            List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                            int hour = r.Next(7, 24);
                            int index = r.Next(minutes.Count);
                            string min = minutes[index];
                            reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}"); //se crea de manera aleatoria la fecha y hora de la reserva

                            reserve.VaccinationPlace = boo.Place;
                            Reservation.Create(reserve);
                            Reservation.Save(); // Se almacena la reserva en la DB.
                            if (!(txtChronicDisease.Text == ""))// Si se agregaron una o mas enfermedades.
                            {
                                string phrase = txtChronicDisease.Text;
                                string[] words = phrase.Split(',');// Se parte la cadena de texto con la lista de enfermedades.

                                foreach (var w in words)
                                {
                                    ChronicDisease cdis = new ChronicDisease();
                                    cdis.DuiCitizen = person.Dui;
                                    cdis.ChronicDisease1 = w;
                                    cDisease.Create(cdis);
                                    cDisease.Save(); // Se guarda una a una la enfermedad.
                                } 
                            }
                            MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }

                    }
					else if (!(txtChronicDisease.Text == "") && age < 60 && age >= 18) // Si la persona es mayor de 18 años e ingreso por lo menos una enfermedad
                    {																  // se le asigna el grupo de prioridad con id 4 (mayor de 18 con efermendad/es no transmisibles).
                        person.NumIdentifier = Convert.ToInt32(txtId.Text);
                        person.IdPriorityGroup = 4;
                        Citizen.Create(person);
                        Citizen.Save(); // Se guarda en la DB al ciudadano.

                        reserve.DuiCitizen = person.Dui;

                        var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                        List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                        int hour = r.Next(7, 24);
                        int index = r.Next(minutes.Count);
                        string min = minutes[index];
                        reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}"); //se crea de manera aleatoria la fecha y hora de la reserva

                        reserve.VaccinationPlace = boo.Place;
                        Reservation.Create(reserve);
                        Reservation.Save();// Se almacena la reserva en la DB.
                        if (!(txtChronicDisease.Text == ""))
                        {
                            string phrase = txtChronicDisease.Text;
                            string[] words = phrase.Split(',');// Se parte la cadena de texto con la lista de enfermedades.

                            foreach (var w in words)
                            {
                                ChronicDisease cdis = new ChronicDisease();
                                cdis.DuiCitizen = person.Dui;
                                cdis.ChronicDisease1 = w;
                                cDisease.Create(cdis);
                                cDisease.Save(); // Se guarda una a una la enfermedad.
                            }
                        }
                        MessageBox.Show($"Reservación de {person.CitizenName} hecha", "Ministerio de Salud",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else if (!(txtId.Text == "") && age < 60 && age >= 18) // Si la persona es mayor de 18 y brindo un numero identificador se le asigna el grupo de
                    {														// prioridad segun el primer digito ingresado
                        person.NumIdentifier = Convert.ToInt32(txtId.Text);
                        person.IdPriorityGroup = Convert.ToInt32(txtId.Text[0].ToString());
                        Citizen.Create(person);
                        Citizen.Save(); // Se guarda en la DB al ciudadano.

                        reserve.DuiCitizen = person.Dui;

                        var dateNextDose = DateTime.Now.AddDays(r.Next(5, 10)).ToShortDateString();
                        List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                        int hour = r.Next(7, 24);
                        int index = r.Next(minutes.Count);
                        string min = minutes[index];
                        reserve.DateReservation = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}"); //se crea de manera aleatoria la fecha y hora de la reserva

                        reserve.VaccinationPlace = boo.Place;
                        Reservation.Create(reserve);
                        Reservation.Save(); // Se almacena la reserva en la DB.
                        if (!(txtChronicDisease.Text == "")) // Si se agregaron una o mas enfermedades.
                        {
                            string phrase = txtChronicDisease.Text;
                            string[] words = phrase.Split(',');// Se parte la cadena de texto con la lista de enfermedades.

                            foreach (var w in words)
                            {
                                ChronicDisease cdis = new ChronicDisease();
                                cdis.DuiCitizen = person.Dui;
                                cdis.ChronicDisease1 = w;
                                cDisease.Create(cdis);
                                cDisease.Save(); // Se guarda una a una la enfermedad.
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
