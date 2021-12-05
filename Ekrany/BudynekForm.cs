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

        public BudynekForm(IEkran ekrangra, IBudynek Budynek)
        {
            Ekran = ekrangra;
            this.Budynek = Budynek;
            InitializeComponent();
            nazwa_budynku.Text = Budynek.nazwa.ToString();
            Level_budynku.Text = $"LVL: {Budynek.lvl.ToString()}";
            Pojemnosc_budynku.Text = $"Pojemonść: {Budynek.pojemnosc.ToString()}";
            OdswiezEkran();
        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
            Budynek.Upgrade();
            OdswiezEkran();
        }

        public void OdswiezEkran()
        {
            Ekran.OdswiezEkran();
            Level_budynku.Text = $"LVL: {Budynek.lvl.ToString()}";
            Pojemnosc_budynku.Text = $"Pojemonść: {Budynek.pojemnosc.ToString()}";
            if (Budynek.nazwa == Enums.BudynekEnum.Kopalnia)
            {
                Wymagania_ulepszenia.Text = $"Cena: {Budynek.nazwaSurowcaGlowna}:" +
                $" {Budynek.lvl * Budynek.wspolczynnikUlepszeniaGlowny}";
            }
            else
            {
                Wymagania_ulepszenia.Text = $"Cena: {Budynek.nazwaSurowcaGlowna}:" +
                    $" {Budynek.lvl * Budynek.wspolczynnikUlepszeniaGlowny}, {Budynek.nazwaSurowcaPoboczna}:" +
                    $" {Budynek.lvl * Budynek.wspolczynnikUlepszeniaPoboczny}";
            }
            UstawienieDostepnosciPrzycisku();
        }

        private void Wyjscie_budynek_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UstawienieDostepnosciPrzycisku()
        {
            if(Budynek.lvl >=5) Wymagania_ulepszenia.Text = "";
            if ((Budynek.MowliwoscUpgradu()) && Budynek.lvl < 5)
            {
                Upgrade.Enabled = true;
                Wymagania_ulepszenia.ForeColor = Color.Green;
            }
            else
            {
                Upgrade.Enabled = false;
                Wymagania_ulepszenia.ForeColor = Color.Red;

            }
        }
    }
}
