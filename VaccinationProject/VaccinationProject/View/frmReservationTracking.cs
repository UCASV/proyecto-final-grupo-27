using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationProject.Context;
using VaccinationProject.Controller.Services;
using VaccinationProject.Controller.ViewModel;
using VaccinationProject.View;

namespace VaccinationProject
{
    public partial class frmReservationTracking : Form
    {
        private ReservationServices reservation;
        private Reservation ReservationReference;
        public frmReservationTracking()
        {
            InitializeComponent();
            reservation = new ReservationServices();
        }

        private void frmReservationTracking_Load(object sender, EventArgs e)
        {
            btnProcess.Enabled = false;

            var DS = reservation.GetAll();
            var MappedDS = new List<ReservationVm>();

            DS.ForEach(e => MappedDS.Add(VaccinationProjectMapper.MapReservationToReservationVm(e)));

            dgvReservationTrack.DataSource = null;
            dgvReservationTrack.DataSource = MappedDS;
        }

        private void btnVerifyCitizen_Click(object sender, EventArgs e)
        {
            string dui = txtDuiCitizen.Text, pattern = @"^\d{8}-\d{1}$";

            if (Regex.IsMatch(dui, pattern))
            {
                var reser = reservation.GetById(dui);

                if (reser != null)
                {
                    DialogResult answer = MessageBox.Show($"¿Seguro que desea visualizar la reserva del cuidadano con id {reser.DuiCitizen}?", "Seguimiento de Citas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        var MappedReservation = VaccinationProjectMapper.MapReservationToReservationVm(reser);

                        dgvReservationTrack.DataSource = null;
                        dgvReservationTrack.DataSource = reser;

                        btnProcess.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("El Dui ingresado no pertenece a ningun ciudadano", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dui == "" || dui == " " || dui == "  ")
            {
                MessageBox.Show("No deje el espacio en blanco", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Regex.IsMatch(dui, pattern))
            {
                MessageBox.Show("El dato ingresado no tiene el formato correcto", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show($"¿Seguro que desea guardar el archivo?", "Seguimiento de Citas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {

                sfdPDF.Filter = "Pdf File |*.pdf";
                if (sfdPDF.ShowDialog() == DialogResult.OK)
                {
                        PdfWriter writer = new PdfWriter(new FileStream(sfdPDF.FileName, FileMode.Create));
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        Paragraph header = new Paragraph("GOBIERNO DE EL SALVADOR")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(20);
                        document.Add(header);

                        Paragraph subheader = new Paragraph("CITA VACUNA COVID-19")
                       .SetTextAlignment(TextAlignment.CENTER)
                       .SetFontSize(15);
                        document.Add(subheader);

                        LineSeparator ls = new LineSeparator(new SolidLine());
                        document.Add(ls);

                        document.Add(new Paragraph("\n\n"));

                    Table table = new Table(15);
                        table.SetWidth(UnitValue.CreatePercentValue(100));

                        for (int i = 0; i < dgvReservationTrack.ColumnCount; i++)
                        {
                            Cell headerCells = new Cell()
                                          .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                                          .SetTextAlignment(TextAlignment.CENTER);
                            var gteCell = headerCells.Add(new Paragraph(dgvReservationTrack.Columns[i].HeaderText));
                            table.AddHeaderCell(gteCell);
                        }

                        for (int i = 0; i < dgvReservationTrack.RowCount; i++)
                        {
                            for (int c = 0; c < dgvReservationTrack.ColumnCount; c++)
                            {
                                Cell cells = new Cell()
                                          .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.WHITE)
                                          .SetTextAlignment(TextAlignment.CENTER);

                                var gteCell = cells.Add(new Paragraph(dgvReservationTrack.Rows[i].Cells[dgvReservationTrack.Columns[c].HeaderText].Value.ToString()));
                                table.AddCell(gteCell);
                            }
                        }
                        document.Add(table);

                        document.Close();
                }

                MessageBox.Show("Se ha guardado el archivo pdf con exito", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("¿Seguro que desea iniciar el proceso de vacunación?", "Seguimiento de Citas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                string pattern = @"^\d{8}-\d{1}$";

                if (txtDuiCitizen.Text != null && Regex.IsMatch(txtDuiCitizen.Text, pattern))
                {
                    ReservationReference = reservation.GetById(txtDuiCitizen.Text);

                    if(ReservationReference != null)
                    {
                        var window = new frmVaccinationProcess(ReservationReference);
                        window.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El DUI ingresado no pertenece a ningun cuidadano", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (txtDuiCitizen.Text == "" || txtDuiCitizen.Text == " " || txtDuiCitizen.Text == "  ")
                {
                    MessageBox.Show("Debe verificar un número de DUI primero", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txtDuiCitizen.Text, pattern))
                {
                    MessageBox.Show("El dato ingresado no tiene el formato correcto", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
