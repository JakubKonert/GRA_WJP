using GRA_WJP.Enums;

namespace GRA_WJP.Klasy
{
    /// <summary>
    /// Klasa odpowiedzialna za stworzenie nowego surowca
    /// </summary>
    public class Surowiec
    {
        /**Konstruktor klasy odpowiedzialny za przypisanie wartości do pól konkretnego obiektu*/
        public Surowiec(int ilosc, SurowiecEnum Nazwa)
        {
            this.ilosc = ilosc;
            this.Nazwa = Nazwa;
        }

        /**Pole odpowiedzialne za ilość danego surowca*/
        private int ilosc { get; set; }

        /**Pole odpowiedzialne za nazwę danego surowca*/
        private SurowiecEnum Nazwa { get; }

        /**Pole odpowiedzialne za ilość przydzielonej populacji do danego surowca*/
        private int przydzielonaPopulacja { get; set; }

        /**Pole odpowiedzialne za nazwę danego surowca*/
        public SurowiecEnum JakaNazwa() => Nazwa;

        /**Funkcja odpowiedzialna za przypisanie konkretnej wartości surowca*/
        public void UstawIloscSurowca(int ilosc)
        {
            this.ilosc = ilosc;
        }

        /**Funkcja odpowiedzialna za przypisanie konkretnej wartości ilości przypisanych
         * pracowników do danego surowca*/
        public void UstawIloscPrzydzielonejPopulacji(int ilosc)
        {
            this.przydzielonaPopulacja = ilosc;
        }

        /**Funkcja odpowiedzialna za dostęp do zmiennej "przydzielonaPopulacja"*/
        public int IlePrzydzielonaPopulacja() => przydzielonaPopulacja;

        /**Funkcja odpowiedzialna za dostęp do zmiennej "ilosc*/
        public int IleSurowiec() => ilosc;

        /**Funkcja odpowiedzialna za dodanie konkretnej wartości do pola "ilosc" surowca*/
        public void ZwiekszIloscSurowca(int wartosc)
        {
            ilosc += wartosc;
        }
    }
}
