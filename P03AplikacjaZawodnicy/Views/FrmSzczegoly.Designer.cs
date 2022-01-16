
namespace P03AplikacjaZawodnicy.Views
{
    partial class FrmSzczegoly
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.dtpDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.txtPotwierdzenie = new System.Windows.Forms.TextBox();
            this.panKontrolkiZawodnika = new System.Windows.Forms.Panel();
            this.panKontrolkiZawodnika.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(20, 19);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(165, 20);
            this.txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(20, 64);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(165, 20);
            this.txtNazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(20, 110);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(165, 20);
            this.txtKraj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kraj";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(20, 204);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(165, 20);
            this.txtWaga.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Waga";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(20, 254);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(165, 20);
            this.txtWzrost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wzrost";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(106, 303);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // dtpDataUrodzenia
            // 
            this.dtpDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUrodzenia.Location = new System.Drawing.Point(20, 156);
            this.dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            this.dtpDataUrodzenia.Size = new System.Drawing.Size(165, 20);
            this.dtpDataUrodzenia.TabIndex = 13;
            // 
            // txtPotwierdzenie
            // 
            this.txtPotwierdzenie.Location = new System.Drawing.Point(16, 332);
            this.txtPotwierdzenie.Name = "txtPotwierdzenie";
            this.txtPotwierdzenie.Size = new System.Drawing.Size(165, 20);
            this.txtPotwierdzenie.TabIndex = 14;
            this.txtPotwierdzenie.Visible = false;
            // 
            // panKontrolkiZawodnika
            // 
            this.panKontrolkiZawodnika.Controls.Add(this.txtWaga);
            this.panKontrolkiZawodnika.Controls.Add(this.label1);
            this.panKontrolkiZawodnika.Controls.Add(this.dtpDataUrodzenia);
            this.panKontrolkiZawodnika.Controls.Add(this.txtImie);
            this.panKontrolkiZawodnika.Controls.Add(this.label2);
            this.panKontrolkiZawodnika.Controls.Add(this.txtWzrost);
            this.panKontrolkiZawodnika.Controls.Add(this.txtNazwisko);
            this.panKontrolkiZawodnika.Controls.Add(this.label6);
            this.panKontrolkiZawodnika.Controls.Add(this.label3);
            this.panKontrolkiZawodnika.Controls.Add(this.txtKraj);
            this.panKontrolkiZawodnika.Controls.Add(this.label5);
            this.panKontrolkiZawodnika.Controls.Add(this.label4);
            this.panKontrolkiZawodnika.Location = new System.Drawing.Point(16, 12);
            this.panKontrolkiZawodnika.Name = "panKontrolkiZawodnika";
            this.panKontrolkiZawodnika.Size = new System.Drawing.Size(198, 287);
            this.panKontrolkiZawodnika.TabIndex = 15;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 362);
            this.Controls.Add(this.panKontrolkiZawodnika);
            this.Controls.Add(this.txtPotwierdzenie);
            this.Controls.Add(this.btnZapisz);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.Load += new System.EventHandler(this.FrmSzczegoly_Load);
            this.panKontrolkiZawodnika.ResumeLayout(false);
            this.panKontrolkiZawodnika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private System.Windows.Forms.TextBox txtPotwierdzenie;
        private System.Windows.Forms.Panel panKontrolkiZawodnika;
    }
}