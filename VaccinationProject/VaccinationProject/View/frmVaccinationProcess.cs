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
        public frmVaccinationProcess(Reservation UserReservation)
        {
            InitializeComponent();
            reservationData = UserReservation;
        }
        private void btnWaiting_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.DatewWaitingQueue = dtpWaiting.Value;
            MessageBox.Show("Ha sido vacunado correctamente", "Gobierno de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtpVaccine.Enabled = true;
            btnVaccine.Enabled = true;
            dtpWaiting.Enabled = false;
            btnWaiting.Enabled = false;

            dtpVaccine.MinDate = vaccinationProcessData.DatewWaitingQueue;
            dtpVaccine.MaxDate = Convert.ToDateTime(vaccinationProcessData.DatewWaitingQueue.ToShortDateString()+ " " + "23:59");
        }

        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            vaccinationProcessData.IdReservation = reservationData.Id;
            var shortDateValue = reservationData.DateReservation.ToShortDateString();
            dtpWaiting.MinDate = reservationData.DateReservation;
            dtpWaiting.MaxDate = Convert.ToDateTime(shortDateValue + " " + "23:59");

            dtpVaccine.MinDate = reservationData.DateReservation;
            dtpVaccine.MaxDate = Convert.ToDateTime(shortDateValue + " " + "23:59");
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.DateVaccination = dtpVaccine.Value;
            DialogResult message = MessageBox.Show("¿Presenta algun effecto secundario?", "Gobierno de El Salvador", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(message == DialogResult.Yes)
            {
                var window = new frmSideEffect(vaccinationProcessData);
                this.Hide();
                window.Show();
            }
            else 
            {
                Random random = new Random();
                int nextDose = random.Next(42, 57);
                vaccinationProcessData.DateSecondDose = vaccinationProcessData.DateVaccination.AddDays(nextDose);
                vaccinationProcessData.PlaceSecondDose = reservationData.VaccinationPlace;

                vaccineProccess.Create(vaccinationProcessData);
                vaccineProccess.Save();

                MessageBox.Show($"Su cita para segunda dosis a sido agendada\nLugar: {vaccinationProcessData.PlaceSecondDose}\nFecha: {vaccinationProcessData.DateSecondDose}", "Gobierno de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var window = new frmMain();
                this.Hide();
                window.Show();
            }
        }
    }
}
