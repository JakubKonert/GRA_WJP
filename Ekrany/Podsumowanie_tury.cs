using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Klasy;
using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class Podsumowanie_tury : Form, IEkran
    {
        private IEkran Ekran { get; set; }
        private bool Wygrana { get; set; }

        //wartosci testowe

        /* private float wspolczynnikZyskZloto = 0.3F;
         private float wspolczynnikZyskJedzenie = 0.6F;
         private float wspolczynnikStratJedzenie = 0.2F;
         private float wspolczynnikZyskDrewno = 0.6F;
         private float wspolczynnikStratDrewno = 0.2F; */

        //testowe
        private float wspolczynnikZyskZloto = 4F;
        private float wspolczynnikZyskJedzenie = 4F;
        private float wspolczynnikStratJedzenie = 0F;
        private float wspolczynnikZyskDrewno = 4F;
        private float wspolczynnikStratDrewno = 0F;

        private int wspolczynnikZmianPopulacja = 10;

        public Podsumowanie_tury(IEkran ekrangra)
        {
            InitializeComponent();
            Ekran = ekrangra;

            koniec_tury.Text = $"Podsumowanie tury: {Gra.ktoraTura()-1}";

            stosunek_tur.Text = $"Stosunek tur: {Gra.ktoraTura()-1} / {Gra.ilemaxTur()}";

            populacja_tura.Text = $"Populacja: {(Gra.NastepnaTuraZmianaWartosciPopulacji(Enums.SurowiecEnum.Jedzenie, wspolczynnikZmianPopulacja)).ToString()}";

            jedzenie_tura.Text = $"Jedzenie: {(Gra.NastepnaTuraZmianaWartosciSurowca(Enums.SurowiecEnum.Jedzenie, Enums.BudynekEnum.Farma, wspolczynnikStratJedzenie, wspolczynnikZyskJedzenie)).ToString()} ";

            drewno_tura.Text = $"Drewno: {(Gra.NastepnaTuraZmianaWartosciSurowca(Enums.SurowiecEnum.Drewno, Enums.BudynekEnum.Tartak, wspolczynnikStratDrewno, wspolczynnikZyskDrewno)).ToString()}";

            zloto_tura.Text = $"Złoto: {(Gra.NastepnaTuraZmianaWartosciSurowca(Enums.SurowiecEnum.Zloto, Enums.BudynekEnum.Kopalnia, wspolczynnikZyskZloto)).ToString()}";

            ZdarzenieLosoweLabel.Text = Gra.ZdarzenieLosowe();
        }

        private void Następna_tura_Click(object sender, EventArgs e)
        {
            OdswiezEkran();
            this.Close();
        }

        public void OdswiezEkran()
        {
            Ekran.OdswiezEkran();
        }
    }
}
