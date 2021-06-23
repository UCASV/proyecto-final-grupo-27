using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationProject.View
{
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
                txtName.Text = "";
        }

        private void txtAdress_Click(object sender, EventArgs e)
        {
            txtAdress.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtPhoneN_Click(object sender, EventArgs e)
        {
            txtPhoneN.Text = "";
        }

        private void txtDui_Click(object sender, EventArgs e)
        {
            txtDui.Text = "";
        }

        private void txtId_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }

        private void txtAge_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
        }
    }
}
