
namespace VaccinationProject.View
{
    partial class frmVaccinationProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaccinationProcess));
            this.btnVaccine = new System.Windows.Forms.Button();
            this.btnWaiting = new System.Windows.Forms.Button();
            this.dtpVaccine = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpWaiting = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVaccine
            // 
            this.btnVaccine.BackColor = System.Drawing.SystemColors.Control;
            this.btnVaccine.Enabled = false;
            this.btnVaccine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaccine.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVaccine.Location = new System.Drawing.Point(327, 309);
            this.btnVaccine.Name = "btnVaccine";
            this.btnVaccine.Size = new System.Drawing.Size(123, 39);
            this.btnVaccine.TabIndex = 1;
            this.btnVaccine.Text = "Guardar ";
            this.btnVaccine.UseVisualStyleBackColor = false;
            // 
            // btnWaiting
            // 
            this.btnWaiting.BackColor = System.Drawing.SystemColors.Control;
            this.btnWaiting.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWaiting.Location = new System.Drawing.Point(327, 238);
            this.btnWaiting.Name = "btnWaiting";
            this.btnWaiting.Size = new System.Drawing.Size(123, 39);
            this.btnWaiting.TabIndex = 0;
            this.btnWaiting.Text = "Guardar";
            this.btnWaiting.UseVisualStyleBackColor = false;
            // 
            // dtpVaccine
            // 
            this.dtpVaccine.CustomFormat = "yyyy/MMM/dd HH:mm";
            this.dtpVaccine.Enabled = false;
            this.dtpVaccine.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpVaccine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVaccine.Location = new System.Drawing.Point(77, 312);
            this.dtpVaccine.Name = "dtpVaccine";
            this.dtpVaccine.Size = new System.Drawing.Size(192, 27);
            this.dtpVaccine.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora de aplicacion de vacuna:";
            // 
            // dtpWaiting
            // 
            this.dtpWaiting.CustomFormat = "yyyy/MMM/dd HH:mm";
            this.dtpWaiting.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpWaiting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWaiting.Location = new System.Drawing.Point(77, 241);
            this.dtpWaiting.Name = "dtpWaiting";
            this.dtpWaiting.Size = new System.Drawing.Size(192, 27);
            this.dtpWaiting.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hora de ingreso a la fila de espera:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VaccinationProject.Properties.Resources.BannerMinisterio;
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(532, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpVaccine);
            this.Controls.Add(this.dtpWaiting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVaccine);
            this.Controls.Add(this.btnWaiting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Vacunación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVaccine;
        private System.Windows.Forms.Button btnWaiting;
        private System.Windows.Forms.DateTimePicker dtpVaccine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpWaiting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}