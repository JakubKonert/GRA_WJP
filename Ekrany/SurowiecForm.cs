using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Klasy;
using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class SurowiecForm : Form, IEkran
    {
        private IEkran EkranGra { get; set; }
        private Surowiec Surowiec { get; set; }

        public SurowiecForm(IEkran EkranGra, Surowiec Surowiec)
        {
            this.EkranGra = EkranGra;
            this.Surowiec = Surowiec;
            InitializeComponent();
            SurowiecNazwaLabel.Text = Surowiec.JakaNazwa().ToString();
            //obsluga suwaka w okienku przydzielania populacji do danego surowca
            DostepnaPopulacjaSuwakLabel.Text = (Gra.IleDostepnaPopulacja() + Surowiec.IlePrzydzielonaPopulacja()).ToString();
            PopulacjaPrzydzielonaSuwakLabel.Text = Surowiec.IlePrzydzielonaPopulacja().ToString();
            PopulacjaTrackBar.Minimum = 0;
            PopulacjaTrackBar.Maximum = Gra.IleDostepnaPopulacja() + Surowiec.IlePrzydzielonaPopulacja();
            PopulacjaTrackBar.Value = Surowiec.IlePrzydzielonaPopulacja();
            PopulacjaTrackBar.TickFrequency = Gra.IleDostepnaPopulacja() / ((Gra.IleDostepnaPopulacja() / 10) + 1);
            //"+1" aby zablokować dzielenie przez 0 :P
        }
        public void OdswiezEkran()
        {
            EkranGra.OdswiezEkran();
        }
        //wyswietlanie aktualnie wybranej liczby na suwaku
        private void PopulacjaTrackBar_Scroll(object sender, EventArgs e)
        {
            PopulacjaPrzydzielonaSuwakLabel.Text = PopulacjaTrackBar.Value.ToString();
        }
        //zapisanie danych i zamkniecie okna 
        private void WyjscieSurowiec_Click(object sender, EventArgs e)
        {
            Surowiec.UstawIloscPrzydzielonejPopulacji(PopulacjaTrackBar.Value);

            OdswiezEkran();
            this.Close();
        }
    }
}
