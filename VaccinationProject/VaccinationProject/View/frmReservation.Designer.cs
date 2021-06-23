
namespace VaccinationProject.View
{
    partial class frmReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.picTopLogo = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.lblReservation = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.picBannerMinSal = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTopLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerMinSal)).BeginInit();
            this.SuspendLayout();
            // 
            // picTopLogo
            // 
            this.picTopLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.picTopLogo.Image = global::VaccinationProject.Properties.Resources.unnamed;
            this.picTopLogo.Location = new System.Drawing.Point(-1, -4);
            this.picTopLogo.Name = "picTopLogo";
            this.picTopLogo.Size = new System.Drawing.Size(637, 52);
            this.picTopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopLogo.TabIndex = 0;
            this.picTopLogo.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtName.Location = new System.Drawing.Point(136, 235);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(369, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Nombre ";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // txtPhoneN
            // 
            this.txtPhoneN.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneN.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPhoneN.Location = new System.Drawing.Point(136, 453);
            this.txtPhoneN.Name = "txtPhoneN";
            this.txtPhoneN.Size = new System.Drawing.Size(149, 26);
            this.txtPhoneN.TabIndex = 2;
            this.txtPhoneN.Text = "Teléfono";
            this.txtPhoneN.Click += new System.EventHandler(this.txtPhoneN_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEmail.Location = new System.Drawing.Point(136, 382);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(369, 26);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Correo Electrónico";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdress.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAdress.Location = new System.Drawing.Point(136, 307);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(369, 26);
            this.txtAdress.TabIndex = 4;
            this.txtAdress.Text = "Dirección";
            this.txtAdress.Click += new System.EventHandler(this.txtAdress_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtId.Location = new System.Drawing.Point(136, 529);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(369, 26);
            this.txtId.TabIndex = 5;
            this.txtId.Text = "Identificador";
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // txtDui
            // 
            this.txtDui.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDui.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDui.Location = new System.Drawing.Point(291, 453);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(121, 26);
            this.txtDui.TabIndex = 7;
            this.txtDui.Text = "DUI\r\n";
            this.txtDui.Click += new System.EventHandler(this.txtDui_Click);
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblReservation.Location = new System.Drawing.Point(124, 118);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(397, 45);
            this.lblReservation.TabIndex = 8;
            this.lblReservation.Text = "RESERVA DE CITAS";
            this.lblReservation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservar.Location = new System.Drawing.Point(342, 598);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(163, 47);
            this.btnReservar.TabIndex = 9;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAge.Location = new System.Drawing.Point(418, 453);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(87, 26);
            this.txtAge.TabIndex = 10;
            this.txtAge.Text = "Edad";
            this.txtAge.Click += new System.EventHandler(this.txtAge_Click);
            // 
            // picBannerMinSal
            // 
            this.picBannerMinSal.Image = global::VaccinationProject.Properties.Resources.BannerMinisterio;
            this.picBannerMinSal.Location = new System.Drawing.Point(471, 703);
            this.picBannerMinSal.Name = "picBannerMinSal";
            this.picBannerMinSal.Size = new System.Drawing.Size(149, 71);
            this.picBannerMinSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBannerMinSal.TabIndex = 11;
            this.picBannerMinSal.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(136, 598);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 47);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Atrás";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(632, 786);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picBannerMinSal);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picTopLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservación";
            ((System.ComponentModel.ISupportInitialize)(this.picTopLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerMinSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTopLogo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.PictureBox picBannerMinSal;
        private System.Windows.Forms.Button btnBack;
    }
}