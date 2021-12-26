using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Klasy;
using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    /// <summary>
    /// Okno odpowiedzialne za zarządzaniem danym surowcem (przypisywanie mu pracowników)
    /// </summary>
    public partial class SurowiecForm : Form, IEkran
    {
        /**Pole przyjmujące za wartość okno gry, aby można było je dalej wykorzystać*/
        private IEkran EkranGra { get; set; }

        /**Pole przyjmujące za wartość dany surowiec, aby można było odnosić się do konkretnego
         * surowca*/
        private Surowiec Surowiec { get; set; }

        /**Konstruktor okna, który oprócz przypisania odpowiednich wartości do pól tego okna, 
         * wyświetla suwak odpowiedzialny za przypisanie pracowników do danego surowca*/
        public SurowiecForm(IEkran EkranGra, Surowiec Surowiec)
        {
            this.EkranGra = EkranGra;
            this.Surowiec = Surowiec;
            InitializeComponent();
            SurowiecNazwaLabel.Text = Surowiec.JakaNazwa().ToString();

            DostepnaPopulacjaSuwakLabel.Text = (Gra.IleDostepnaPopulacja() +
                Surowiec.IlePrzydzielonaPopulacja()).ToString();

            PopulacjaPrzydzielonaSuwakLabel.Text = Surowiec.IlePrzydzielonaPopulacja().ToString();
            PopulacjaTrackBar.Minimum = 0;

            PopulacjaTrackBar.Maximum = Gra.IleDostepnaPopulacja() + 
                Surowiec.IlePrzydzielonaPopulacja();

            PopulacjaTrackBar.Value = Surowiec.IlePrzydzielonaPopulacja();

            PopulacjaTrackBar.TickFrequency = Gra.IleDostepnaPopulacja() 
                / ((Gra.IleDostepnaPopulacja() / 10) + 1);
            //"+1" aby zablokować dzielenie przez 0 :P
        }

        /**Funkcja odpowiedzialna za odświeżanie okna gry*/
        public void OdswiezEkran()
        {
            EkranGra.OdswiezEkran();
        }

        /**Funkcja odpowiedzialna za wyświetlenie aktualnej wartości przypisanej
         * liczby pracowników*/
        private void PopulacjaTrackBar_Scroll(object sender, EventArgs e)
        {
            PopulacjaPrzydzielonaSuwakLabel.Text = PopulacjaTrackBar.Value.ToString();
        }
        
        /**Funkcja odpowiedzialna za zapisanie danych dotyczących przypisanej liczby
         * pracowników oraz zamknięcie okna zarządzania surowcem*/
        private void WyjscieSurowiec_Click(object sender, EventArgs e)
        {
            Surowiec.UstawIloscPrzydzielonejPopulacji(PopulacjaTrackBar.Value);

            OdswiezEkran();
            this.Close();
        }

        /**Funkcja odpowiedzialna za zamknięcie okna zarządzania surowcem, bez przypisania
         * nowej wartości z suwaka*/
        private void AnulujButton_Click(object sender, EventArgs e)
        {
            OdswiezEkran();
            this.Close();
        }
    }
}
