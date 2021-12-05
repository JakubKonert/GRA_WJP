using GRA_WJP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA_WJP.Klasy
{
    public class Surowiec
    {

        public Surowiec(int ilosc, SurowiecEnum nazwa)
        {
            this.ilosc = ilosc;
            this.nazwa = nazwa;
        }

        public int ilosc { get; set; }
        private SurowiecEnum nazwa { get; }
        public int PrzydzielonaPopulacja;

        public SurowiecEnum jakaNazwa() => nazwa;

        public void ZwiekszIloscSurowca(int wartosc)
        {
            ilosc += wartosc;
        }
    }
}
