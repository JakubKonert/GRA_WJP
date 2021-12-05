using GRA_WJP.Enums;
using GRA_WJP.Klasy;
using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class Koniec : Form
    {
        private Form _parent;
        public Koniec(Form parent)
        {
            _parent = parent;
            InitializeComponent();
            if (Gra.czyWygrana() == MozliweKonceTuryEnum.Zwyciestwo)
            {
                Statystyki_koniec.Enabled = true;
                WygranaPrzegrana.Text = "Zwycięstwo";
                TuraKonca.Text = $"Udało Ci się osiągnąć cel w {Gra.ktoraTura()} turze!";
            }
            else if (Gra.czyWygrana() == MozliweKonceTuryEnum.Przegrana)
            {
                WygranaPrzegrana.Text = "Przegrana";
                TuraKonca.Visible = false;
                Statystyki_koniec.Visible = false;
            }
        }

        private void Wyjscie_koniec_Click(object sender, EventArgs e)
        {
            _parent.Close();
        }

        private void Powrot_koniec_Click(object sender, EventArgs e)
        {
            _parent.Show();
            this.Close();
        }
        //zapisanie wyniku
        private void Statystyki_koniec_Click(object sender, EventArgs e)
        {
            new ZapisWynikuForm().ShowDialog();
        }
    }
}
