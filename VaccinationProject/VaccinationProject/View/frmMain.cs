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
using VaccinationProject.View;

namespace VaccinationProject
{
    public partial class frmMain : Form
    {
        public Manager manager { get; set; }
        public Booth booth { get; set; }

        private TypeEmployeeServices TypeEmploye = new TypeEmployeeServices();
        public frmMain(Manager manager, Booth booth)
        {
            InitializeComponent();

            this.manager = manager;
            this.booth = booth;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ttSupport.SetToolTip(picBoothInformation, "Consultar la información de la cabina en funcionamiento");
            this.ttSupport.SetToolTip(picManagerInformation, "Consultar la información del gestor");
            this.ttSupport.SetToolTip(btnReservation, "Iniciar un proceso de cita para un ciudadano");
            this.ttSupport.SetToolTip(btnReservationTracking, "Entrar al módulo Seguimiento de Citas");

            tabSupport.Appearance = TabAppearance.FlatButtons;
            tabSupport.ItemSize = new Size(0, 1);
            tabSupport.SizeMode = TabSizeMode.Fixed;
            tabSupport.TabStop = false;

            txtIDManager.Text = manager.Id.ToString();
            txtNameManager.Text = manager.EmployeeName;
            txtMailManager.Text = manager.Email;
            txtTypeEmployee.Text = TypeEmploye.GetById(manager.IdTypeEmployee).TypeEmployee1;
            txtManagerAddress.Text = manager.HomeAddress;

            txtIDBooth.Text = booth.Id.ToString();
            txtBoothAddress.Text = booth.Place;
            txtMailBooth.Text = booth.Email;
            txtPhoneBooth.Text = booth.PhoneNumber;
            txtManagerBooth.Text = booth.ManagerBooth;
        }
        private void picBoothInformation_Click(object sender, EventArgs e)
        {
            tabSupport.SelectedIndex = 1;
        }

        private void picManagerInformation_Click(object sender, EventArgs e)
        {
            tabSupport.SelectedIndex = 2;
        }

        private void mstPrincipalPage_Click(object sender, EventArgs e)
        {
            tabSupport.SelectedIndex = 0;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmReservation window = new frmReservation(manager);
            window.ShowDialog();
        }

        private void btnReservationTracking_Click(object sender, EventArgs e)
        {
            frmReservationTracking window = new frmReservationTracking(manager);
            window.ShowDialog();
        }

        private void mstLogOut_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Close();
                frmLogIn window = new frmLogIn();
                window.Show();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("¿Seguro que desea salir de la aplicación Soporte?", "Salir",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
