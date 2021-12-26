using GRA_WJP.Klasy;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    /// <summary>
    /// Okno odpowiedzialne za wyświetlanie statystyk gracza 
    /// </summary>
    public partial class StatystykiForm : Form
    {
        /**Pole przyjmujące za wartość okno "StartMenu", aby można było je dalej wykorzystać*/
        private Form OknoRodzic;

        /**Konstruktor statystyk gracza, przypisuje wartość do pola "OknoRodzic" oraz wyświetla
        10 najlepszych wyników*/
        public StatystykiForm(Form OknoRodzic)
        {
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();

            ZaladujStatystyki();
        }

        /**Funkcja odpowiedzialna za zamknięcie okna Statystyk oraz powrót do menu głównego*/
        private void powrot_menu_Click(object sender, EventArgs e)
        {
            OknoRodzic.Visible = true;
            this.Close();
        }

        /**Funkcja odpowiedzialna za wyświetlenie z pliku .txt najlepszych 10 wyników w raz 
         * z danymi, które dany wynik opisują (Liczba porządkowa, nazwa gracza, tura zwycięstwa,
         * data)*/
        private void ZaladujStatystyki()
        {
            var Wyniki = new List<Wynik>();
            if (File.Exists("Wyniki.txt"))
            {
                foreach (var Wynik in File.ReadAllLines("Wyniki.txt"))
                {
                    var WynikDane = Wynik.Split(';');
                    Wyniki.Add(new Wynik(WynikDane[0], DateTime.Parse(WynikDane[2]),
                        int.Parse(WynikDane[1])));
                }

                Wyniki = Wyniki.OrderBy(w => w.KtoraTuraNumer()).ThenBy(w => w.JakaData()).
                    Take(10).ToList();

                int i = 1;
                foreach (var Wynik in Wyniki)
                {
                    StatystykiTextLabel.Text += $"{i++}. {Wynik.JakaNazwa()} " +
                        $"  Tura: {Wynik.KtoraTuraNumer()}   Data: {Wynik.JakaData()}\n";
                }
            }
        }
    }
}
