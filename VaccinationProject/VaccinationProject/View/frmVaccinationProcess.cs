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
        private Reservation ReservationData { get; set; }
        private VaccinationProcessServices vaccineProccess;
        
        private VaccinationProcess vaccinationProcessData = new VaccinationProcess();
        public frmVaccinationProcess(/*Reservation UserReservation*/)
        {
            InitializeComponent();
            //this.ReservationData = UserReservation;
        }

        private void btnWaiting_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.DatewWaitingQueue = dtpWaiting.Value;
            MessageBox.Show("Ha sido vacunado correctamente", "Gobierno de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtpVaccine.Enabled = true;
            btnVaccine.Enabled = true;
            dtpWaiting.Enabled = false;
            btnWaiting.Enabled = false;
        }

        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            //dtpWaiting.MinDate = ReservationData.DateReservation;
            //dtpVaccine.MinDate = ReservationData.DateReservation;
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
            else if(message == DialogResult.No)
            {

            }
        }

        private void DateSecondDose()
        {

        }
    }
}
