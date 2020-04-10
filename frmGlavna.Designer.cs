namespace OOP_p
{
    partial class frmPrijava
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
            this.cbKorisnickoIme = new System.Windows.Forms.ComboBox();
            this.cbLozinka = new System.Windows.Forms.ComboBox();
            this.btnVerifikacija = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbKorisnickoIme
            // 
            this.cbKorisnickoIme.FormattingEnabled = true;
            this.cbKorisnickoIme.Location = new System.Drawing.Point(272, 58);
            this.cbKorisnickoIme.Name = "cbKorisnickoIme";
            this.cbKorisnickoIme.Size = new System.Drawing.Size(121, 21);
            this.cbKorisnickoIme.TabIndex = 0;
            // 
            // cbLozinka
            // 
            this.cbLozinka.FormattingEnabled = true;
            this.cbLozinka.Location = new System.Drawing.Point(272, 120);
            this.cbLozinka.Name = "cbLozinka";
            this.cbLozinka.Size = new System.Drawing.Size(121, 21);
            this.cbLozinka.TabIndex = 1;
            // 
            // btnVerifikacija
            // 
            this.btnVerifikacija.Location = new System.Drawing.Point(292, 207);
            this.btnVerifikacija.Name = "btnVerifikacija";
            this.btnVerifikacija.Size = new System.Drawing.Size(75, 23);
            this.btnVerifikacija.TabIndex = 2;
            this.btnVerifikacija.Text = "Verifikacija";
            this.btnVerifikacija.UseVisualStyleBackColor = true;
            this.btnVerifikacija.Click += new System.EventHandler(this.btnVerifikacija_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerifikacija);
            this.Controls.Add(this.cbLozinka);
            this.Controls.Add(this.cbKorisnickoIme);
            this.Name = "frmPrijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKorisnickoIme;
        private System.Windows.Forms.ComboBox cbLozinka;
        private System.Windows.Forms.Button btnVerifikacija;
        private System.Windows.Forms.Button button1;
    }
}

