using P03AplikacjaZawodnicy.ViewModels;
using P03AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P03AplikacjaZawodnicy.Tools;

namespace P03AplikacjaZawodnicy.Views
{
    public partial class FrmZawodnicy : Form
    {
        FrmKolumny fk;
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        public void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();


            if (fk != null)
            {
                string[] kolumny = new string[fk.ChlbKolumny.CheckedItems.Count];
                for (int i = 0; i < fk.ChlbKolumny.CheckedItems.Count; i++)
                    kolumny[i] = fk.ChlbKolumny.CheckedItems[i].ToString();
                zr.Wczytaj(kolumny);
            }
            else
                zr.Wczytaj();


            lbDane.DataSource = zr.Zawodnicy;
            lbDane.DisplayMember = "WybraneKolumny";
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmSzczegoly fs = new FrmSzczegoly(this, TrybOkienka.Stworzenie);
            fs.Show();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            var zaznaczony = (ZawodnikVM)lbDane.SelectedValue;
            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony, TrybOkienka.Edycja);
            fs.Show();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            var zaznaczony = (ZawodnikVM)lbDane.SelectedValue;
            FrmSzczegoly fs = new FrmSzczegoly(this, zaznaczony, TrybOkienka.Usuwanie);
            fs.Show();
        }

        private void btnKolumny_Click(object sender, EventArgs e)
        {
            fk = new FrmKolumny(this);
            fk.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PDFManager pm = new PDFManager();
            string nazwaPliku=  pm.StworzPDF((ZawodnikVM[])lbDane.DataSource);

            string sciezkaDoFolderu = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            webBrowser1.Navigate($@"{sciezkaDoFolderu}\{nazwaPliku}");
        }
    }
}
