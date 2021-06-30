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
		// Se inicializan atributos que seran utilizados y seran enviados como referencia a los distintos formularios.
        private BoothServices Booth = new BoothServices();
        private ManagerServices Manager = new ManagerServices();
        private RegisterServices Register = new RegisterServices();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            cmbBooth.DataSource = Booth.GetAll(); // Se puebla el comboBox con las direcciones de las cabinas almacenadas en la DB.
            cmbBooth.DisplayMember = "Place";
            cmbBooth.ValueMember = "Id";

            this.ttLogIn.SetToolTip(cmbBooth, "Dirección de la cabina a la que ingresará");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var man = Manager.GetByUserandPass(txtUser.Text, txtPass.Text);
            var boo = Booth.GetById(cmbBooth.SelectedIndex + 1);


            if (txtUser.Text == "" || txtPass.Text == "") // Validacion si se intenta iniciar sesion con los campos de usuario y contraseña vacios.
            {
                MessageBox.Show("Rellene todos los campos para iniciar sesion correctamente", "Ministerio de Salud",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (man is null) // validacion si se ingresan datos invalidos en los campos de usuario y contraseña.
            { 
                MessageBox.Show("Gestor no encontrado. Datos inválidos. " +
                    "Vuelve a ingresar los datos", "Ministerio de Salud",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (man.UserName == txtUser.Text && man.Pass == txtPass.Text) // Si el usuario y contraseña ingresados corresponden a uno almacenado en la DB
            {																   // procedemos a agregar los datos a la tabla de registro de inicio de sesion.
                MessageBox.Show($"Bienvenido/a {man.EmployeeName}", "Ministerio de Salud",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Register reg = new Register();
                reg.IdManager = man.Id;
                reg.IdBooth = boo.Id;
                reg.DateLogin = DateTime.Now;
                Register.Create(reg);
                Register.Save();
                frmMain window = new frmMain(man, boo);
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

