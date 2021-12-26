using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    /// <summary>
    /// Klasa odpowiedzialna stworzenie obiektu budynku Dom
    /// Dziedziczy po interfejsie IBudynek
    /// </summary>
    public class Dom : IBudynek
    {
        /**Konstruktor klasy Dom, przypisuje konkretne wartości polom tej klasy*/
        public Dom(int lvl, int pojemnosc, int pojemnoscLvl,
            int wspolczynnikUlepszeniaGlowny, int wspolczynnikUlepszeniaPoboczny,
            String NazwaSurowcaGlowna, String NazwaSurowcaPoboczna)
        {
            this.lvl = lvl;
            this.pojemnosc = pojemnosc;
            this.Nazwa = BudynekEnum.Dom;
            this.wspolczynnikUlepszeniaGlowny = wspolczynnikUlepszeniaGlowny;
            this.wspolczynnikUlepszeniaPoboczny = wspolczynnikUlepszeniaPoboczny;
            this.pojemnoscLvl = pojemnoscLvl;
            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
            this.NazwaSurowcaPoboczna = NazwaSurowcaPoboczna;
        }

        /**Pole odpowiedzialne za lvl Domu*/
        public int lvl { get; set; }

        /**Pole odpowiedzialne za pojemnosc Domu*/
        public int pojemnosc { get; set; }

        /**Pole odpowiedzialne za nazwę Domu*/
        public BudynekEnum Nazwa { get; set; }

        /**Pole odpowiedzialne za współczynnik ceny w głównym surowca potrzebnego do 
         * ulepszenia Domu*/
        public int wspolczynnikUlepszeniaGlowny { get; set; }

        /**Pole odpowiedzialne za współczynnik ceny w pobocznego surowca potrzebnego do
         * ulepszenia Domu*/
        public int wspolczynnikUlepszeniaPoboczny { get; set; }

        /**Pole odpowiedzialne za nazwę głównego surowca potrzebnego do ulepszenia Domu*/
        public String NazwaSurowcaGlowna { get; set; }

        /**Pole odpowiedzialne za nazwę pobocznego surowca potrzebnego do ulepszenia Domu*/
        public String NazwaSurowcaPoboczna { get; set; }

        /**Pole odpowiedzialne za ilość zwiększania pojemności Domu co lvl*/
        public int pojemnoscLvl { get; set; }

        /**Funkcja odpowiedzialna za odejmowanie surowców z "konta" gracza, o ile budynek nie
         * posiada już maksymalnego lvl. Ponadto zwiększa ilość pojemności w Domu oraz zwiększa
         * jego lvl*/
        public void Upgrade()
        {
            if (lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Drewno, lvl * wspolczynnikUlepszeniaGlowny);
            Gra.OdejmijSurowiec(SurowiecEnum.Jedzenie, lvl * wspolczynnikUlepszeniaPoboczny);
            pojemnosc += pojemnoscLvl;
            lvl++;
        }

        /**Funkcja odpowiedzialna za sprawdzenie, czy gracza stać na ulepszenie Domu*/
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Drewno)
            - (lvl * wspolczynnikUlepszeniaGlowny) >= 0)
            && (Gra.IloscSurowca(SurowiecEnum.Jedzenie) 
            - (lvl * wspolczynnikUlepszeniaPoboczny) >= 0);
    }
}
