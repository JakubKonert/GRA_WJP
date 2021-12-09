using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using GRA_WJP.Klasy;
using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class GraForm : Form, IEkran
    {
        private Form OknoRodzic;
        public GraForm(Form OknoRodzic)
        {
            Gra.ResetGra();
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();
            OdswiezEkran();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dom_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Dom);
        }

        private void Kopalnia_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Kopalnia);
        }

        private void Tartak_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Tartak);
        }

        private void Farma_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Farma);
        }

        private void Jedzenie_Click(object sender, EventArgs e)
        {
            Gra.WyswietlSurowiec(this, SurowiecEnum.Jedzenie);
        }

        private void Drewno_Click(object sender, EventArgs e)
        {

            Gra.WyswietlSurowiec(this, SurowiecEnum.Drewno);
        }

        private void Zloto_Click(object sender, EventArgs e)
        {
            Gra.WyswietlSurowiec(this, SurowiecEnum.Zloto);
        }

        //odswieżanie ekranu, co każdą czynność gracza, aktualizacja wyswietlanych ilosci surowca/danych
        public void OdswiezEkran()
        {
            JedzenieButton.Text = $"{SurowiecEnum.Jedzenie}:\n {Gra.IloscSurowca(SurowiecEnum.Jedzenie)} / {Gra.MaksSurowca(BudynekEnum.Farma)}";
            DrewnoButton.Text = $"{SurowiecEnum.Drewno}:\n {Gra.IloscSurowca(SurowiecEnum.Drewno)} / {Gra.MaksSurowca(BudynekEnum.Tartak)}";
            ZlotoButton.Text = $"{SurowiecEnum.Zloto}:\n {Gra.IloscSurowca(SurowiecEnum.Zloto)} / {Gra.MaksSurowca(BudynekEnum.Kopalnia)}";
            PopulacjaLabel.Text = $"Populacja:\n {Gra.IleDostepnaPopulacja()} / {Gra.IlePopulacja()} / {Gra.MaksSurowca(BudynekEnum.Dom)}";
            TuraLabel.Text = $"Tura: \n {Gra.KtoraTura()} / {Gra.IlemaxTur()}";
        }
        //albo nastepna tura, albo okno konca gry
        private void Koniec_tury_Click(object sender, EventArgs e)
        {
            if (Gra.NastepnaTura())
                new PodsumowanieTuryForm(this).ShowDialog();
            else
            {
                this.Close();
                new KoniecForm(OknoRodzic).ShowDialog();
            }
        }
    }
}
