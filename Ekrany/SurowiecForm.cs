using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class SurowiecForm : Form, IEkran
    {
        private IEkran Ekran { get; set; }
        private Surowiec Surowiec { get; set; }

        public SurowiecForm(IEkran ekrangra, Surowiec surowiec)
        {
            Ekran = ekrangra;
            Surowiec = surowiec;
            InitializeComponent();
            SurowiecNazwa.Text = surowiec.jakaNazwa().ToString();
            DostepnaPopulacjaSuwak.Text = (Gra.IleDostepnaPopulacja() + Surowiec.PrzydzielonaPopulacja).ToString();
            PopulacjaPrzydzielonaSuwak.Text = Surowiec.PrzydzielonaPopulacja.ToString();
            PopulacjaTrackBar.Minimum = 0;
            PopulacjaTrackBar.Maximum = Gra.IleDostepnaPopulacja() + Surowiec.PrzydzielonaPopulacja;
            PopulacjaTrackBar.Value = Surowiec.PrzydzielonaPopulacja;
            PopulacjaTrackBar.TickFrequency = Gra.IleDostepnaPopulacja() / ((Gra.IleDostepnaPopulacja()/10)+1);
            //"+1" aby zablokować dzielenie przez 0 :P
        }
        //Admin mode cheat mode, dodanie surka
        private void button1_Click(object sender, EventArgs e)
        {
            Surowiec.ZwiekszIloscSurowca(100000);
        }

        public void OdswiezEkran()
        {
            Ekran.OdswiezEkran();
        }

        private void PopulacjaTrackBar_Scroll(object sender, EventArgs e)
        {
            PopulacjaPrzydzielonaSuwak.Text = PopulacjaTrackBar.Value.ToString();
        }

        private void WyjscieSurowiec_Click(object sender, EventArgs e)
        {
            Surowiec.PrzydzielonaPopulacja = PopulacjaTrackBar.Value;

            OdswiezEkran();
            this.Close();
        }
    }
}
