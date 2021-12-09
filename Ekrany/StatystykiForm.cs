using GRA_WJP.Klasy;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class StatystykiForm : Form
    {
        private Form OknoRodzic;
        public StatystykiForm(Form OknoRodzic)
        {
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();

            ZaladujStatystyki();
        }

        private void powrot_menu_Click(object sender, EventArgs e)
        {
            OknoRodzic.Visible = true;
            this.Close();
        }
        //wyswietlanie 10 najlepszych wynikow na tablicy, dane czytane z pliku tekstowego, ktory jest 
        //odpowiednio formatowany (split(';'))
        private void ZaladujStatystyki()
        {
            var Wyniki = new List<Wynik>();
            if (File.Exists("Wyniki.txt"))
            {
                foreach (var Wynik in File.ReadAllLines("Wyniki.txt"))
                {
                    var WynikDane = Wynik.Split(';');
                    Wyniki.Add(new Wynik(WynikDane[0], DateTime.Parse(WynikDane[2]), int.Parse(WynikDane[1])));
                }

                Wyniki = Wyniki.OrderBy(w => w.KtoraTuraNumer()).ThenBy(w => w.JakaData()).Take(10).ToList();

                int i = 1;
                foreach (var Wynik in Wyniki)
                {
                    StatystykiTextLabel.Text += $"{i++}. {Wynik.JakaNazwa()}   Tura: {Wynik.KtoraTuraNumer()}   Data: {Wynik.JakaData()}\n";
                }
            }
        }
    }
}
