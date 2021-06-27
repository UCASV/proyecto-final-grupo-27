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

namespace VaccinationProject
{
    public partial class frmSideEffect : Form
    {
        private VaccinationProcess vaccinationProcessData = new VaccinationProcess();
        private SideEffectServices dbSideEffects = new SideEffectServices();
        private ReservationServices dbReservation = new ReservationServices();
        private VaccinationProcessServices vaccineProccess = new VaccinationProcessServices();
        public frmSideEffect(VaccinationProcess Data)
        {
            InitializeComponent();
            vaccinationProcessData = Data;
        }

        private void frmSideEffect_Load(object sender, EventArgs e)
        {
            cmbSideEffect.DataSource = dbSideEffects.GetAll();
            cmbSideEffect.DisplayMember = "SideEffect1";
            cmbSideEffect.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.IdSideEffects = (cmbSideEffect.SelectedIndex) + 1;
            vaccinationProcessData.TimeSideEffects = Convert.ToInt32(nudTime.Value);

            Random random = new Random();

            int nextDose = random.Next(42,57);
            vaccinationProcessData.DateSecondDose = vaccinationProcessData.DateVaccination.AddDays(nextDose);
            vaccinationProcessData.PlaceSecondDose = dbReservation.GetById(vaccinationProcessData.IdReservation).VaccinationPlace;

            vaccineProccess.Create(vaccinationProcessData);
            vaccineProccess.Save();

            MessageBox.Show($"Su cita para segunda dosis ha sido agendada\nLugar: {vaccinationProcessData.PlaceSecondDose}\nFecha: {vaccinationProcessData.DateSecondDose}", "Gobierno de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
