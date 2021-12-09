using GRA_WJP.Enums;

namespace GRA_WJP.Klasy
{
    public class Surowiec
    {
        //funkcje i pola samoopisuja sie
        public Surowiec(int Ilosc, SurowiecEnum Nazwa)
        {
            this.Ilosc = Ilosc;
            this.Nazwa = Nazwa;
        }
        private int Ilosc { get; set; }
        private SurowiecEnum Nazwa { get; }
        private int PrzydzielonaPopulacja { get; set; }

        public SurowiecEnum JakaNazwa() => Nazwa;
        public void ZmienIloscPrzydzielonejPopulacji(int Wartosc)
        {
            PrzydzielonaPopulacja += Wartosc;
        }

        public void UstawIloscSurowca(int Ilosc)
        {
            this.Ilosc = Ilosc;
        }
        public void UstawIloscPrzydzielonejPopulacji(int Ilosc)
        {
            this.PrzydzielonaPopulacja = Ilosc;
        }
        public int IlePrzydzielonaPopulacja() => PrzydzielonaPopulacja;
        public int IleSurowiec() => Ilosc;
        public void ZwiekszIloscSurowca(int Wartosc)
        {
            Ilosc += Wartosc;
        }
    }
}
