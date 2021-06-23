using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void informaciónPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
    }
}
