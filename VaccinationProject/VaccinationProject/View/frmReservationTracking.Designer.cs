
namespace VaccinationProject
{
    partial class frmReservationTracking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationTracking));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuiCitizen = new System.Windows.Forms.TextBox();
            this.dgvReservationTrack = new System.Windows.Forms.DataGridView();
            this.btnVerifyCitizen = new System.Windows.Forms.Button();
            this.btnSavePdf = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI Ciudadano:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // txtDuiCitizen
            // 
            this.txtDuiCitizen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuiCitizen.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuiCitizen.Location = new System.Drawing.Point(160, 192);
            this.txtDuiCitizen.Name = "txtDuiCitizen";
            this.txtDuiCitizen.Size = new System.Drawing.Size(159, 23);
            this.txtDuiCitizen.TabIndex = 1;
            this.txtDuiCitizen.UseWaitCursor = true;
            // 
            // dgvReservationTrack
            // 
            this.dgvReservationTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationTrack.Location = new System.Drawing.Point(32, 251);
            this.dgvReservationTrack.Name = "dgvReservationTrack";
            this.dgvReservationTrack.RowTemplate.Height = 25;
            this.dgvReservationTrack.Size = new System.Drawing.Size(287, 200);
            this.dgvReservationTrack.TabIndex = 2;
            this.dgvReservationTrack.UseWaitCursor = true;
            // 
            // btnVerifyCitizen
            // 
            this.btnVerifyCitizen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnVerifyCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCitizen.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyCitizen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerifyCitizen.Location = new System.Drawing.Point(357, 181);
            this.btnVerifyCitizen.Name = "btnVerifyCitizen";
            this.btnVerifyCitizen.Size = new System.Drawing.Size(99, 42);
            this.btnVerifyCitizen.TabIndex = 3;
            this.btnVerifyCitizen.Text = "Verificar DUI";
            this.btnVerifyCitizen.UseVisualStyleBackColor = false;
            this.btnVerifyCitizen.UseWaitCursor = true;
            // 
            // btnSavePdf
            // 
            this.btnSavePdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnSavePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePdf.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSavePdf.Location = new System.Drawing.Point(357, 326);
            this.btnSavePdf.Name = "btnSavePdf";
            this.btnSavePdf.Size = new System.Drawing.Size(99, 43);
            this.btnSavePdf.TabIndex = 4;
            this.btnSavePdf.Text = "Guardar PDF";
            this.btnSavePdf.UseVisualStyleBackColor = false;
            this.btnSavePdf.UseWaitCursor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProcess.Location = new System.Drawing.Point(187, 490);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(132, 25);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Iniciar Proceso";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VaccinationProject.Properties.Resources.BannerMinisterio;
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // frmReservationTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(499, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnSavePdf);
            this.Controls.Add(this.btnVerifyCitizen);
            this.Controls.Add(this.dgvReservationTrack);
            this.Controls.Add(this.txtDuiCitizen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReservationTracking";
            this.Text = "Seguimiento de Cita";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuiCitizen;
        private System.Windows.Forms.DataGridView dgvReservationTrack;
        private System.Windows.Forms.Button btnVerifyCitizen;
        private System.Windows.Forms.Button btnSavePdf;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

