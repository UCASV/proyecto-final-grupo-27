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
    public partial class frmLogIn : Form
    {
        private BoothServices Booth = new BoothServices();
        private ManagerServices Manager = new ManagerServices();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            cmbBooth.DataSource = Booth.GetAll();
            cmbBooth.DisplayMember = "Place";
            cmbBooth.ValueMember = "Id";

            this.ttLogIn.SetToolTip(cmbBooth, "Dirección de la cabina a la que ingresará");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            var man = Manager.GetByUserandPass(txtUser.Text, txtPass.Text);
          
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Rellene todos los campos para iniciar sesion correctamente", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (man is null)
            { 
                MessageBox.Show("Gestor no encontrado. Datos inválidos. " +
                    "Vuelve a ingresar los datos", "Ministerio de Salud",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (man.UserName == txtUser.Text && man.Pass == txtPass.Text)
            {
                MessageBox.Show($"Bienvenido/a {man.EmployeeName}", "Ministerio de Salud",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain window = new frmMain(man, Booth.GetById(cmbBooth.SelectedIndex + 1));
                window.Show();
                this.Hide();
            }
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Salir",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
 }

