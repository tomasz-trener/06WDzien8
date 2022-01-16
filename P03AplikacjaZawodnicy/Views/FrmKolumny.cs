using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AplikacjaZawodnicy.Views
{
    public partial class FrmKolumny : Form
    {
        FrmZawodnicy frmZawodnicy;

        public CheckedListBox ChlbKolumny
        {
            get { return chlbKolumny; }
        }

        public FrmKolumny(FrmZawodnicy frmZawodnicy)
        {
            this.frmZawodnicy = frmZawodnicy;
            InitializeComponent();
        }

        private void chlbKolumny_SelectedValueChanged(object sender, EventArgs e)
        {
            frmZawodnicy.Odswiez();
        }
    }
}
