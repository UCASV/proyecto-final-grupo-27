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
        public frmSideEffect(VaccinationProcess Data)   //en caso que tenga un efecto secundario se reciben los datos del proceso de vacunacción para completarlos en el formulario de efectos secundarios
        {
            InitializeComponent();
            vaccinationProcessData = Data;
        }

        private void frmSideEffect_Load(object sender, EventArgs e)
        {
            cmbSideEffect.DataSource = dbSideEffects.GetAll();  //se agregan los datos de los diferentes efectos secundarios en el selector accediendo a la base de datos
            cmbSideEffect.DisplayMember = "SideEffect1";
            cmbSideEffect.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.IdSideEffects = (cmbSideEffect.SelectedIndex) + 1;   //se guarda el efecto secundario y el tiempo que tardó en experimentarlo
            vaccinationProcessData.TimeSideEffects = Convert.ToInt32(nudTime.Value);

            List<string> minutes = new List<string>() { "00", "15", "30", "45" };
            Random random = new Random();
            int nextDose = random.Next(42,57);
            int hour = random.Next(7, 24);
            int index = random.Next(minutes.Count);
            string min = minutes[index];
            var dateNextDose = vaccinationProcessData.DateVaccination.AddDays(nextDose).ToShortDateString(); 

            vaccinationProcessData.DateSecondDose = Convert.ToDateTime(dateNextDose + " " + $"{hour.ToString()}:{min}");  //se crea de manera aleatoria la cita de la segunda dosis con una hora y fecha aleatorios

            vaccinationProcessData.PlaceSecondDose = dbReservation.GetById(vaccinationProcessData.IdReservation).VaccinationPlace;  //se guarda el lugar de la segunda dosis como el mismo donde se le aplico la primera dosis

            vaccineProccess.Create(vaccinationProcessData);
            vaccineProccess.Save();                                 //se crea el proceso de vacunación y se guarda en la base de datos

            MessageBox.Show($"Su cita para segunda dosis ha sido agendada\nLugar: {vaccinationProcessData.PlaceSecondDose}\nFecha: {vaccinationProcessData.DateSecondDose}", "Gobierno de El Salvador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
