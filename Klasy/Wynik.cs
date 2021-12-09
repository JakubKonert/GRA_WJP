using System;

namespace GRA_WJP.Klasy
{
    class Wynik
    {
        public Wynik(string Nazwa, DateTime Data, int KtoraTura)
        {
            this.Nazwa = Nazwa;
            this.Data = Data;
            this.KtoraTura = KtoraTura;
        }

        // #enkapsulacja, dane jakie mają być zapisywane podczas zapisu wyniku (tylko dla zwycięstwa)
        private String Nazwa { get; }
        private DateTime Data { get; }
        private int KtoraTura { get; }

        public int KtoraTuraNumer() => KtoraTura;
        public String JakaNazwa() => Nazwa;
        public DateTime JakaData() => Data;
    }
}
