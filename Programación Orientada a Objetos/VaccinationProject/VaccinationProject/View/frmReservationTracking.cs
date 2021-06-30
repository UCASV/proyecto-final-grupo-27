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
		// Atributos a utilizar en este formulario y que se enviaran como referencia a otros
        private ReservationServices reservation;
        private Reservation ReservationReference;
        private VaccinationProcessServices vaccineProccess;
        private Manager manager;
        public frmReservationTracking(Manager manager)
        {
            InitializeComponent();
            reservation = new ReservationServices();
            vaccineProccess = new VaccinationProcessServices();
            this.manager = manager;
        }

        private void frmReservationTracking_Load(object sender, EventArgs e)
        {
            btnProcess.Enabled = false; // Boton de iniciar proceso desabilitado.

            var DS = reservation.GetAll(); // Se obtienen las reservas almacenadas.
			if(DS == null) // Si no hay reservas almacenadas se desabilita el boton de guardar pdf.
			{
				btnProcess.Enabled = false;
			}
            var MappedDS = new List<ReservationVm>();

            DS.ForEach(e => MappedDS.Add(VaccinationProjectMapper.MapReservationToReservationVm(e))); // Se mappea la lista de reservas de la DB para 

            dgvReservationTrack.DataSource = null;													  // poder polbar el Data Grid View
            dgvReservationTrack.DataSource = MappedDS;
        }

        private void btnVerifyCitizen_Click(object sender, EventArgs e)
        {
            string dui = txtDuiCitizen.Text, pattern = @"^\d{8}-\d{1}$";

            if (Regex.IsMatch(dui, pattern)) // Si el DUI ingresado cumple con el formato esperado.
            {
                var reser = new List<Reservation>();
                reser.Add(reservation.GetByDUI(dui)); // Se crea una lista con la resrvacion en especifico para poder poblar el Data Grid View.

                if (reser[0] != null) // Si exite la resrva en la DB.
                {
                    DialogResult answer = MessageBox.Show($"¿Seguro que desea visualizar la reserva del cuidadano?", "Seguimiento de Citas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        var MappedReservation = new List<ReservationVm>();
                        MappedReservation.Add(VaccinationProjectMapper.MapReservationToReservationVm(reser[0]));

                        dgvReservationTrack.DataSource = null;
                        dgvReservationTrack.DataSource = MappedReservation;

                        btnProcess.Enabled = true;
                    }
                }
                else // Sino existe en la DB, se cierra el formulario y muestra el de reservar cita.
                {
                    MessageBox.Show("El Dui ingresado no pertenece a ningun ciudadano almacenado en la base de datos", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    frmReservation window = new frmReservation(manager);
                    this.Hide();
                    window.ShowDialog();
                }
            }
            else if (dui == "" || dui == " " || dui == "  ") // Si se deja el campo de DUI vaio muestra mensaje de error.
            {
                MessageBox.Show("No deje el espacio en blanco", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!Regex.IsMatch(dui, pattern)) // Si lo ingresado al textBox no cumple con formato de DUi muestra error.
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

                sfdPDF.Filter = "Pdf File |*.pdf"; // Se abre un SaveFileDialog para elegir ruta de guardado y nombre del archivo pdf
                if (sfdPDF.ShowDialog() == DialogResult.OK)
                {
                        PdfWriter writer = new PdfWriter(new FileStream(sfdPDF.FileName, FileMode.Create));
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf); // Se crea el documento.

                        Paragraph header = new Paragraph("GOBIERNO DE EL SALVADOR")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(20);
                        document.Add(header); // Se agrega titulo al documento.

                        Paragraph subheader = new Paragraph("CITA VACUNA COVID-19")
                       .SetTextAlignment(TextAlignment.CENTER)
                       .SetFontSize(15);
                        document.Add(subheader); // Se agrega un subtitulo.

                        document.Add(new Paragraph("\n")); // Se agrega un espacio en blanco.

                        LineSeparator ls = new LineSeparator(new SolidLine());
                        document.Add(ls); // Se agrega una linea separadora.

                        document.Add(new Paragraph("\n\n"));// Se agregan dos espacio en blanco.

                        Table table = new Table(dgvReservationTrack.ColumnCount);
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

                        document.Add(table); // Se agrega el contenido del Data Grid View.

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
                    ReservationReference = reservation.GetByDUI(txtDuiCitizen.Text);

                    if(ReservationReference != null && vaccineProccess.GetbyIdreservation(ReservationReference.Id) == null) 
                    {																								 
                        var window = new frmVaccinationProcess(ReservationReference);
                        this.Hide();
                        window.ShowDialog();

                    }
                    else if(vaccineProccess.GetbyIdreservation(ReservationReference.Id) != null) // Si el DUI verid¿ficado posee reserva de segunda dosis
                    {																			 //	no es posible iniciar el proceso de nuevo.			
                        MessageBox.Show("Ya se le ha aplicado la primer dosis al ciudadano", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El DUI ingresado no pertenece a ningun cuidadano", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (txtDuiCitizen.Text == "" || txtDuiCitizen.Text == " " || txtDuiCitizen.Text == "  ") // Si se deja el textBox vacio se muestra mensaje de error.
                {
                    MessageBox.Show("Debe verificar un número de DUI primero", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txtDuiCitizen.Text, pattern)) // Si lo ingresado al textBox no concuerda con el formato de DUi muestra mensaje de error.
                {
                    MessageBox.Show("El dato ingresado no tiene el formato correcto", "Seguimiento de Citas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
