
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
            this.lblReservation = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.picBannerMinSal = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDui = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTopLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannerMinSal)).BeginInit();
            this.SuspendLayout();
            // 
            // picTopLogo
            // 
            this.picTopLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.picTopLogo.Image = global::VaccinationProject.Properties.Resources.unnamed;
            this.picTopLogo.Location = new System.Drawing.Point(-1, -3);
            this.picTopLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTopLogo.Name = "picTopLogo";
            this.picTopLogo.Size = new System.Drawing.Size(557, 39);
            this.picTopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopLogo.TabIndex = 0;
            this.picTopLogo.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtName.Location = new System.Drawing.Point(119, 176);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Nombre";
            this.txtName.Size = new System.Drawing.Size(323, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtPhoneN
            // 
            this.txtPhoneN.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneN.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPhoneN.Location = new System.Drawing.Point(119, 340);
            this.txtPhoneN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneN.Name = "txtPhoneN";
            this.txtPhoneN.PlaceholderText = "Teléfono";
            this.txtPhoneN.Size = new System.Drawing.Size(131, 22);
            this.txtPhoneN.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEmail.Location = new System.Drawing.Point(119, 286);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Correo Electrónico";
            this.txtEmail.Size = new System.Drawing.Size(323, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdress.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAdress.Location = new System.Drawing.Point(119, 230);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.PlaceholderText = "Dirección";
            this.txtAdress.Size = new System.Drawing.Size(323, 22);
            this.txtAdress.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtId.Location = new System.Drawing.Point(119, 397);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Identificador";
            this.txtId.Size = new System.Drawing.Size(323, 22);
            this.txtId.TabIndex = 5;
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblReservation.Location = new System.Drawing.Point(122, 87);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(320, 37);
            this.lblReservation.TabIndex = 8;
            this.lblReservation.Text = "RESERVA DE CITAS";
            this.lblReservation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservar.Location = new System.Drawing.Point(299, 448);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(143, 35);
            this.btnReservar.TabIndex = 9;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAge.Location = new System.Drawing.Point(366, 340);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.PlaceholderText = "Edad";
            this.txtAge.Size = new System.Drawing.Size(77, 22);
            this.txtAge.TabIndex = 10;
            // 
            // picBannerMinSal
            // 
            this.picBannerMinSal.Image = global::VaccinationProject.Properties.Resources.BannerMinisterio;
            this.picBannerMinSal.Location = new System.Drawing.Point(421, 506);
            this.picBannerMinSal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBannerMinSal.Name = "picBannerMinSal";
            this.picBannerMinSal.Size = new System.Drawing.Size(130, 53);
            this.picBannerMinSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBannerMinSal.TabIndex = 11;
            this.picBannerMinSal.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(119, 448);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Atrás";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDui
            // 
            this.txtDui.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDui.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDui.Location = new System.Drawing.Point(256, 340);
            this.txtDui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDui.Name = "txtDui";
            this.txtDui.PlaceholderText = "DUI";
            this.txtDui.Size = new System.Drawing.Size(106, 22);
            this.txtDui.TabIndex = 13;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(553, 562);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picBannerMinSal);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblReservation);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picTopLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.PictureBox picBannerMinSal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDui;
    }
}