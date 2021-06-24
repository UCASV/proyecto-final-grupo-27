
namespace VaccinationProject.View
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblGob = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.cmbBooth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::VaccinationProject.Properties.Resources.SoloLogoGobnayik;
            this.picLogo.Location = new System.Drawing.Point(164, -5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(195, 187);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUser.Location = new System.Drawing.Point(134, 333);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(271, 26);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuario";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPass.Location = new System.Drawing.Point(134, 389);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(271, 26);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Contraseña";
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            // 
            // lblGob
            // 
            this.lblGob.AutoSize = true;
            this.lblGob.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblGob.Location = new System.Drawing.Point(117, 198);
            this.lblGob.Name = "lblGob";
            this.lblGob.Size = new System.Drawing.Size(314, 90);
            this.lblGob.TabIndex = 3;
            this.lblGob.Text = "GOBIERNO DE \r\nEL SALVADOR";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.Location = new System.Drawing.Point(164, 510);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(195, 52);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Ingresar";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // cmbBooth
            // 
            this.cmbBooth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooth.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbBooth.FormattingEnabled = true;
            this.cmbBooth.Location = new System.Drawing.Point(134, 449);
            this.cmbBooth.Name = "cmbBooth";
            this.cmbBooth.Size = new System.Drawing.Size(271, 28);
            this.cmbBooth.TabIndex = 5;
            this.cmbBooth.Click += new System.EventHandler(this.cmbBooth_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(532, 625);
            this.Controls.Add(this.cmbBooth);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblGob);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblGob;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.ComboBox cmbBooth;
    }
}