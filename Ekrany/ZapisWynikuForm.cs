using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using GRA_WJP.Klasy;

namespace GRA_WJP.Ekrany
{
    public partial class ZapisWynikuForm : Form
    {
        public ZapisWynikuForm()
        {
            InitializeComponent();
        }

        //zapis do pliku tekstowego wyniku gracza przy utrzymaniu konwencji, ze kazda dana jest odseparowana
        //srednikiem
        private void ZapisWyniku_Click(object sender, EventArgs e)
        {
            File.AppendAllText("Wyniki.txt", $"{ZapisWynikuTextBox.Text};{Gra.KtoraTura()};{DateTime.Now}\n");
            this.Close();
        }
    }
}
