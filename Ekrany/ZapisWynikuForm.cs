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
using GRA_WJP.Klasy;
using Microsoft.VisualBasic;

namespace GRA_WJP.Ekrany
{
    public partial class ZapisWynikuForm : Form
    {

        private static List<Wynik> Wyniki = new List<Wynik>();


        public ZapisWynikuForm()
        {
            InitializeComponent();
            string nazwa = "Wygrana";
            Wyniki.Add(new Wynik(nazwa, DateTime.Now, Gra.ktoraTura()));
        }

        private void ZapisWyniku_Click(object sender, EventArgs e)
        {
            File.AppendAllText("wyniki.txt", $"{zapisWynikuTextBox.Text};{Gra.ktoraTura()};{DateTime.Now}\n");
            this.Close();
        }
    }
}
