using GRA_WJP.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class StatystykiForm : Form
    {
        // TO DO: Przekazac 'master' parent i na nim dzialac :)
        public StatystykiForm()
        {
            InitializeComponent();

            ZaladujStatystyki();
        }

        private void powrot_menu_Click(object sender, EventArgs e)
        {
            //Pytanie: powrócenie widzialności menu głównego
            //Menu_form.visible = true;
            this.Close();
        }

        private void ZaladujStatystyki()
        {
            var wyniki = new List<Wynik>();

            foreach (var wynik in File.ReadAllLines("wyniki.txt"))
            {
                var wynikDane = wynik.Split(';');
                wyniki.Add(new Wynik(wynikDane[0], DateTime.Parse(wynikDane[2]), int.Parse(wynikDane[1])));
            }

            wyniki = wyniki.OrderBy(w => w.ktoraTura).ThenBy(w => w.data).Take(10).ToList();

            int i = 1;
            foreach (var wynik in wyniki)
            {
                Statystyki_text.Text += $"{i++}. {wynik.nazwa}\t{wynik.ktoraTura}\t{wynik.data}\n";
            }

        }
    }
}
