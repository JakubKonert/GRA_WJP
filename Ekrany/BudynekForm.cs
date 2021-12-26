using GRA_WJP.Ekrany.Interfejsy;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    /// <summary>
    /// Okno, które jest otwierane gdy gracz chce ulepszyć dany budynek
    /// Dane są przesyłane z głównego okna gry, dlatego 1 okno obsługuje wszystkie
    /// rodzaje budynków
    /// </summary>
    public partial class BudynekForm : Form, IEkran
    {
        /**Pole interfejsu, z którego pobierane są dane na temat kontretnego budynku,
         * który dziedziczy interfejs IBudynek*/
        private IBudynek Budynek { get; set; }

        /**Pole interfejsu, które pozwala wywołać potem funkcje należące do okna gry
         * (Odświeżenie ekrany) aby główne okno gry się na bieżąco odświeżał0*/
        private IEkran Ekran { get; set; }

        /**W konstruktorze oprócz przypisania danych do pól, następuje również wyświetlenie 
         * podstawowych parametrów dotyczących danego budynku*/
        public BudynekForm(IEkran ekrangra, IBudynek Budynek)
        {
            this.Ekran = ekrangra;
            this.Budynek = Budynek;
            InitializeComponent();
            NazwaBudynkuLabel.Text = Budynek.Nazwa.ToString();
            LevelBudynkuButton.Text = $"LVL: {Budynek.lvl.ToString()}";
            PojemnoscBudynkuLabel.Text = $"Pojemonść: {Budynek.pojemnosc.ToString()}";
            OdswiezEkran();
        }

        /**Wywołanie funkcji ulepzenie budynku oraz odświeżenie okna, aby gracz był na bieżąco
         * ze zmianami*/
        private void Upgrade_Click(object sender, EventArgs e)
        {
            Budynek.Upgrade();
            OdswiezEkran();
        }

        /**Funkcja odpowiedzialna za odświeżanie ekranu, aby gracz był na bieżąco ze zmianami w
         * grze Budynek "Kopalnia" został wyodrębniony w if ze względu na to, że do jego ulepszenia
        potrzebny jest tylko jeden surowiec*/
        public void OdswiezEkran()
        {
            Ekran.OdswiezEkran();
            LevelBudynkuButton.Text = $"LVL: {Budynek.lvl.ToString()}";
            PojemnoscBudynkuLabel.Text = $"Pojemonść: {Budynek.pojemnosc.ToString()}";
            if (Budynek.Nazwa == Enums.BudynekEnum.Kopalnia)
            {
                WymaganiaUlepszeniaButton.Text = $"Cena: {Budynek.NazwaSurowcaGlowna}:" +
                $" {Budynek.lvl * Budynek.wspolczynnikUlepszeniaGlowny}";
            }
            else
            {
                WymaganiaUlepszeniaButton.Text = $"Cena: {Budynek.NazwaSurowcaGlowna}:" +
                    $" {Budynek.lvl * Budynek.wspolczynnikUlepszeniaGlowny}, {Budynek.NazwaSurowcaPoboczna}:" +
                    $" {Budynek.lvl * Budynek.wspolczynnikUlepszeniaPoboczny}";
            }
            UstawienieDostepnosciPrzycisku();
        }
        /**Zamknięcie okna dotyczącego budynku*/
        private void Wyjscie_budynek_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**Funkcja odpowiedzialna za sprawdzenie czy gracz może ulepszyć dany budynek, 
         Jeśli tak: przycisk ma być dostępny i zielony napis ceny surowców potrzenych do ulepszenia
        w Przeciwnym wypadku: przycisk ma być wyłączony i czerwony napis ceny surowców potrzebnych 
        do ulepszenia*/
        private void UstawienieDostepnosciPrzycisku()
        {
            if (Budynek.lvl >= 5) WymaganiaUlepszeniaButton.Text = "";
            if ((Budynek.MowliwoscUpgradu()) && Budynek.lvl < 5)
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
