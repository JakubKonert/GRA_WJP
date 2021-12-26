using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    /// <summary>
    /// Klasa odpowiedzialna stworzenie obiektu budynku Kopalnia
    /// Dziedziczy po interfejsie IBudynek
    /// </summary>
    public class Kopalnia : IBudynek
    {
        /**Konstruktor klasy Kopalnia, przypisuje konretne wartości polom tej klasy*/
        public Kopalnia(int lvl, int pojemnosc, int pojemnoscLvl ,
            int wspolczynnikUlepszeniaGlowny, String NazwaSurowcaGlowna)
        {
            this.lvl = lvl;
            this.pojemnosc = pojemnosc;
            this.Nazwa = BudynekEnum.Kopalnia;
            this.wspolczynnikUlepszeniaGlowny = wspolczynnikUlepszeniaGlowny;
            this.pojemnoscLvl = pojemnoscLvl;
            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
        }

        /**Pole odpowiedzialne za lvl Kopalni*/
        public int lvl { get; set; }

        /**Pole odpowiedzialne za pojemnosc Kopalni*/
        public int pojemnosc { get; set; }

        /**Pole odpowiedzialne za nazwę Kopalni*/
        public BudynekEnum Nazwa { get; set; }

        /**Pole odpowiedzialne za współczynnik ceny w głównym surowca potrzebnego do ulepszenia
         * Kopalni*/
        public int wspolczynnikUlepszeniaGlowny { get; set; }

        /**Pole odpowiedzialne za współczynnik ceny w pobocznego surowca potrzebnego do ulepszenia
         * Kopalni*/
        public int wspolczynnikUlepszeniaPoboczny { get; set; }
 
        /**Pole odpowiedzialne za nazwę głównego surowca potrzebnego do ulepszenia Kopalni*/
        public String NazwaSurowcaGlowna { get; set; }

        /**Pole odpowiedzialne za nazwę pobocznego surowca potrzebnego do ulepszenia Kopalni*/
        public String NazwaSurowcaPoboczna { get; set; }

        /**Pole odpowiedzialne za ilość zwiększania pojemności Kopalni co lvl*/
        public int pojemnoscLvl { get; set; }

        /**Funkcja odpowiedzialna za odejmowanie surowców z "konta" gracza, o ile budynek nie
         * posiada już maksymalnego lvl. Ponadto zwiększa ilość pojemności w Kopalnia oraz 
         * zwiększa jego lvl*/
        public void Upgrade()
        {
            if (lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, lvl * wspolczynnikUlepszeniaGlowny);
            pojemnosc += pojemnoscLvl;
            lvl++;
        }

        /**Funkcja odpowiedzialna za sprawdzenie, czy gracza stać na ulepszenie Kopalni*/
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto)
            - (lvl * wspolczynnikUlepszeniaGlowny) >= 0);
    }
}
