using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using GRA_WJP.Klasy;
using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    /// <summary>
    /// Okno gry - przypisuje funkcjonalności danym przyciskom oraz wypisuje podstawowe dane
    /// jednakże samej logiki tutaj nie ma, aby oddzielić logikę od wyglądu
    /// </summary>
    public partial class GraForm : Form, IEkran
    {
        /**Pole przyjmujące za wartość okno "StartMenu", aby można było je dalej przesyłać
         * lub wykorzystać*/
        private Form OknoRodzic;

        /**Konstruktor okna gry, restetuje gre (poprzez przypisanie domyślnych wartości), 
         * przypisuje wartość do pola "OknoRodzic" oraz odświeża ekran, aby zachowane były
         * aktualne wartości*/
        public GraForm(Form OknoRodzic)
        {
            Gra.ResetGra();
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();
            OdswiezEkran();
        }

        /**Funkcja powodująca wyświetlenie okna zarządzania domem, po wciśnieciu budynku "Dom"*/
        private void Dom_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Dom);
        }

        /**Funkcja powodująca wyświetlenie okna zarządzania kopalnią, po wciśnieciu budynku 
         * "Kopalnia"*/
        private void Kopalnia_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Kopalnia);
        }

        /**Funkcja powodująca wyświetlenie okna zarządzania tartakiem, po wciśnieciu budynku 
         * "Tartak"*/
        private void Tartak_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Tartak);
        }

        /**Funkcja powodująca wyświetlenie okna zarządzania farmą, po wciśnieciu budynku "Farma"*/
        private void Farma_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Farma);
        }

        /**Funkcja powodująca wyświetlenie okna zarządzania jedzeniem, po wciśnieciu surowca 
         * "Jedzenie"*/
        private void Jedzenie_Click(object sender, EventArgs e)
        {
            Gra.WyswietlSurowiec(this, SurowiecEnum.Jedzenie);
        }

        /**Funkcja powodująca wyświetlenie okna zarządzania drewnem, po wciśnieciu surowca
         * "Drewno"*/
        private void Drewno_Click(object sender, EventArgs e)
        {

            Gra.WyswietlSurowiec(this, SurowiecEnum.Drewno);
        }

        /**Funkcja powodująca wyświetlenie okna zarządzania złotem, po wciśnieciu surowca "Złoto"*/
        private void Zloto_Click(object sender, EventArgs e)
        {
            Gra.WyswietlSurowiec(this, SurowiecEnum.Zloto);
        }

        /**Funkcja odpowiedzialna za odświeżanie danych dotyczących stanu surowców, ludzi oraz 
         * stosunku tur gracza*/
        public void OdswiezEkran()
        {
            JedzenieButton.Text = $"{SurowiecEnum.Jedzenie}:\n " +
                $"{Gra.IloscSurowca(SurowiecEnum.Jedzenie)} / {Gra.MaksSurowca(BudynekEnum.Farma)}";

            DrewnoButton.Text = $"{SurowiecEnum.Drewno}:\n {Gra.IloscSurowca(SurowiecEnum.Drewno)}" +
                $" / {Gra.MaksSurowca(BudynekEnum.Tartak)}";

            ZlotoButton.Text = $"{SurowiecEnum.Zloto}:\n {Gra.IloscSurowca(SurowiecEnum.Zloto)}" +
                $" / {Gra.MaksSurowca(BudynekEnum.Kopalnia)}";

            PopulacjaLabel.Text = $"Populacja:\n {Gra.IleDostepnaPopulacja()} /" +
                $" {Gra.IlePopulacja()} / {Gra.MaksSurowca(BudynekEnum.Dom)}";

            TuraLabel.Text = $"Tura: \n {Gra.KtoraTura()} / {Gra.IlemaxTur()}";
        }

        /**Funkcja odpowiedzialna za koniec tury + sprawdza czy ma nastąpić następna tura czy
         * już koniec gry (przegrana lub wygrana)*/
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

        /**Funkcja nasłuchująca czy został wciśnięty przycisk (w tym przypadku'q') i jeśli tak, ma 
         zostać wyświetlone okno pauzy gry*/
        private void GraForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q') new PauzaForm(OknoRodzic, this).ShowDialog();
        }
    }
}
