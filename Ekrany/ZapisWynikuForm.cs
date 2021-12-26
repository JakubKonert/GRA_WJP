using System;
using System.IO;
using System.Windows.Forms;
using GRA_WJP.Klasy;

namespace GRA_WJP.Ekrany
{
    /// <summary>
    /// Okno odpowiedzialne za zapisanie wyniku gracza (gdy gracz wygra)
    /// </summary>
    public partial class ZapisWynikuForm : Form
    {
        public ZapisWynikuForm()
        {
            InitializeComponent();
        }

        /**Funkcja odpowiedzialna za dodanie wyniku do pliku tekstowego oraz zamknięcie 
         * okna zapisu*/
        private void ZapisWyniku_Click(object sender, EventArgs e)
        {
            File.AppendAllText
                ("Wyniki.txt", $"{ZapisWynikuTextBox.Text};{Gra.KtoraTura()};{DateTime.Now}\n");
            this.Close();
        }
    }
}
