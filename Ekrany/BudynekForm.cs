using GRA_WJP.Ekrany.Interfejsy;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class BudynekForm : Form, IEkran
    {
        private IBudynek Budynek { get; set; }
        private IEkran Ekran { get; set; }
        
        //wyswietlenie danych na temat konretnego budynku, ktory jest wysylany jako argument
        public BudynekForm(IEkran ekrangra, IBudynek Budynek)
        {
            Ekran = ekrangra;
            this.Budynek = Budynek;
            InitializeComponent();
            NazwaBudynkuLabel.Text = Budynek.Nazwa.ToString();
            LevelBudynkuButton.Text = $"LVL: {Budynek.Lvl.ToString()}";
            PojemnoscBudynkuLabel.Text = $"Pojemonść: {Budynek.Pojemnosc.ToString()}";
            OdswiezEkran();
        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
            Budynek.Upgrade();
            OdswiezEkran();
        }

        public void OdswiezEkran()
        {
            //odswiezenie ekranu po wcisnieciu upgrade, aby gracz na biezaco widzial cene kolejnego upgradu
            Ekran.OdswiezEkran();
            LevelBudynkuButton.Text = $"LVL: {Budynek.Lvl.ToString()}";
            PojemnoscBudynkuLabel.Text = $"Pojemonść: {Budynek.Pojemnosc.ToString()}";
            if (Budynek.Nazwa == Enums.BudynekEnum.Kopalnia)
            {
                WymaganiaUlepszeniaButton.Text = $"Cena: {Budynek.NazwaSurowcaGlowna}:" +
                $" {Budynek.Lvl * Budynek.WspolczynnikUlepszeniaGlowny}";
            }
            else
            {
                WymaganiaUlepszeniaButton.Text = $"Cena: {Budynek.NazwaSurowcaGlowna}:" +
                    $" {Budynek.Lvl * Budynek.WspolczynnikUlepszeniaGlowny}, {Budynek.NazwaSurowcaPoboczna}:" +
                    $" {Budynek.Lvl * Budynek.WspolczynnikUlepszeniaPoboczny}";
            }
            UstawienieDostepnosciPrzycisku();
        }

        private void Wyjscie_budynek_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //blokada, aby gracz nie mogl wcisnac przycisku jesli nie spelnia wymagan, lvl budynku max 5, cena
        //w surowcach
        private void UstawienieDostepnosciPrzycisku()
        {
            if (Budynek.Lvl >= 5) WymaganiaUlepszeniaButton.Text = "";
            if ((Budynek.MowliwoscUpgradu()) && Budynek.Lvl < 5)
            {
                UpgradeButton.Enabled = true;
                WymaganiaUlepszeniaButton.ForeColor = Color.Green;
            }
            else
            {
                UpgradeButton.Enabled = false;
                WymaganiaUlepszeniaButton.ForeColor = Color.Red;
            }
        }
    }
}
