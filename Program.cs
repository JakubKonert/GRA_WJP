using System;
using System.Windows.Forms;
using GRA_WJP.Ekrany;

namespace GRA_WJP
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //cóż można powiedzieć? start gry i tyle
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenuForm());
        }
    }
}
