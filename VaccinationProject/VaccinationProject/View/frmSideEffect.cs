/*using System;
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
        private SideEffectServices dbSideEffects;
        public frmSideEffect(VaccinationProcess Data)
        {
            InitializeComponent();
            vaccinationProcessData = Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vaccinationProcessData.IdSideEffects = 
        }

        private void frmSideEffect_Load(object sender, EventArgs e)
        {
            cmbSideEffect.DataSource = dbSideEffects.GetAll();
        }
    }
}
*/