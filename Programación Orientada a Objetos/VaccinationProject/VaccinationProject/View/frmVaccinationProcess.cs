using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationProject.Context;
using VaccinationProject.Controller.Services;

namespace VaccinationProject.View
{
    public partial class frmVaccinationProcess : Form
    {
        private Reservation reservationData = new Reservation();
        private VaccinationProcessServices vaccineProccess = new VaccinationProcessServices();
        private VaccinationProcess vaccinationProcessData = new VaccinationProcess();
        public frmVaccinationProcess(Reservation UserReservation)   //guardando los datos de la reserva para acceder a ellos
        {
            InitializeComponent();
            reservationData = UserReservation;
        }
        private void btnWaiting_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.DatewWaitingQueue = dtpWaiting.Value;    //guardando la hora a la que el ciudadano ingresa a la fila de espera
            MessageBox.Show("Ha sido vacunado correctamente", "Gobierno de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtpVaccine.Enabled = true;
            btnVaccine.Enabled = true;
            dtpWaiting.Enabled = false;
            btnWaiting.Enabled = false;

            dtpVaccine.MinDate = vaccinationProcessData.DatewWaitingQueue;  //configurando el seleccionador de fecha y hora para que sea como minimo el mismo dia y la hora a la que ingresa a la fila de espera
            dtpVaccine.MaxDate = Convert.ToDateTime(vaccinationProcessData.DatewWaitingQueue.ToShortDateString()+ " " + "23:59"); //como maximo el mismo dia a las 23:59
        }

        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            vaccinationProcessData.IdReservation = reservationData.Id; 
            var shortDateValue = reservationData.DateReservation.ToShortDateString();
            dtpWaiting.MinDate = reservationData.DateReservation;                        //configurando el seleccionador de fecha y hora para que sea el como minimo el mismo guardado en la reserva de la persona
            dtpWaiting.MaxDate = Convert.ToDateTime(shortDateValue + " " + "23:59");     // como maximo el mismo dia a las 23:59

            dtpVaccine.MinDate = reservationData.DateReservation;
            dtpVaccine.MaxDate = Convert.ToDateTime(shortDateValue + " " + "23:59");
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.DateVaccination = dtpVaccine.Value;
            DialogResult message = MessageBox.Show("¿Presenta algún efecto secundario?", "Gobierno de El Salvador", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(message == DialogResult.Yes)                                 //en caso que seleccione la opcion que tiene un efecto secundario se le abrira una nueva ventana
            {                                                               //para ingresar la informacion de los efectos secundarios
                var window = new frmSideEffect(vaccinationProcessData);
                this.Hide();
                window.ShowDialog();
            }
            else 
            {
                List<string> minutes = new List<string>() { "00", "15", "30", "45" };
                Random random = new Random();
                int nextDose = random.Next(42, 57);
                int hour = random.Next(7, 24);
                int index = random.Next(minutes.Count);
                string min = minutes[index];
                var dateNextDose = vaccinationProcessData.DateVaccination.AddDays(nextDose).ToShortDateString();

                vaccinationProcessData.DateSecondDose = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}");    //se crea de manera aleatoria la cita de la segunda dosis con una hora y fecha aleatorios

                vaccinationProcessData.PlaceSecondDose = reservationData.VaccinationPlace;  //se guarda el lugar de la segunda dosis como el mismo donde se le aplico la primera dosis

                vaccineProccess.Create(vaccinationProcessData);
                vaccineProccess.Save();                                          //se crea el proceso de vacunación y se guarda en la base de datos

                MessageBox.Show($"Su cita para segunda dosis ha sido agendada\nLugar: {vaccinationProcessData.PlaceSecondDose}\nFecha: {vaccinationProcessData.DateSecondDose}", "Gobierno de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);         
                this.Hide();
            }
        }
    }
}
