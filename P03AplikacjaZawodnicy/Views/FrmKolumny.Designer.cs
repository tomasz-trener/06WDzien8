
namespace P03AplikacjaZawodnicy.Views
{
    partial class FrmKolumny
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
            this.chlbKolumny = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chlbKolumny
            // 
            this.chlbKolumny.FormattingEnabled = true;
            this.chlbKolumny.Items.AddRange(new object[] {
            "Imie",
            "Nazwisko",
            "Kraj",
            "DataUr",
            "Waga",
            "Wzrost"});
            this.chlbKolumny.Location = new System.Drawing.Point(3, 2);
            this.chlbKolumny.Name = "chlbKolumny";
            this.chlbKolumny.Size = new System.Drawing.Size(120, 94);
            this.chlbKolumny.TabIndex = 0;
            this.chlbKolumny.SelectedValueChanged += new System.EventHandler(this.chlbKolumny_SelectedValueChanged);
            // 
            // FrmKolumny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 97);
            this.Controls.Add(this.chlbKolumny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKolumny";
            this.Text = "Kolumny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbKolumny;
    }
}