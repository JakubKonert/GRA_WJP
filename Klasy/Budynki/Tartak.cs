using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    /// <summary>
    /// Klasa odpowiedzialna za stworzenie obiektu budynku Tartak
    /// Dziedziczy po interfejsie IBudynek
    /// </summary>
    public class Tartak : IBudynek
    {
        /**Konstruktor klasy Tartak, przypisuje konretne wartości polom tej klasy*/
        public Tartak(int lvl, int pojemnosc, int pojemnoscLvl, int wspolczynnikUlepszeniaPoboczny,
            int wspolczynnikUlepszeniaGlowny,
            String NazwaSurowcaGlowna, String NazwaSurowcaPoboczna)
        {
            this.lvl = lvl;
            this.pojemnosc = pojemnosc;
            this.Nazwa = BudynekEnum.Tartak;
            this.wspolczynnikUlepszeniaPoboczny = wspolczynnikUlepszeniaPoboczny;
            this.wspolczynnikUlepszeniaGlowny = wspolczynnikUlepszeniaGlowny;
            this.pojemnoscLvl = pojemnoscLvl;

            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
            this.NazwaSurowcaPoboczna = NazwaSurowcaPoboczna;
        }

        /**Pole odpowiedzialne za lvl Tartaku*/
        public int lvl { get; set; }

        /**Pole odpowiedzialne za pojemnosc Tartaku*/
        public int pojemnosc { get; set; }

        /**Pole odpowiedzialne za nazwę Tartaku*/
        public BudynekEnum Nazwa { get; }

        /**Pole odpowiedzialne za nazwę głównego surowca potrzebnego do ulepszenia Tartaku*/
        public String NazwaSurowcaGlowna { get; }

        /**Pole odpowiedzialne za nazwę pobocznego surowca potrzebnego do ulepszenia Tartaku*/
        public String NazwaSurowcaPoboczna { get; }

        /**Pole odpowiedzialne za współczynnik ceny w głównym surowca potrzebnego do ulepszenia 
         * Tartaku*/
        public int wspolczynnikUlepszeniaPoboczny { get; }

        /**Pole odpowiedzialne za współczynnik ceny w pobocznego surowca potrzebnego do ulepszenia
         * Tartaku*/
        public int wspolczynnikUlepszeniaGlowny { get; }

        /**Pole odpowiedzialne za ilość zwiększania pojemności Tartaku co lvl*/
        public int pojemnoscLvl { get; set; }

        /**Funkcja odpowiedzialna za odejmowanie surowców z "konta" gracza, o ile budynek nie 
         * posiada już maksymalnego lvl. Ponadto zwiększa ilość pojemności w Tartaku oraz zwiększa 
         * jego lvl*/
        public void Upgrade()
        {
            if (lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, lvl * wspolczynnikUlepszeniaPoboczny);
            Gra.OdejmijSurowiec(SurowiecEnum.Drewno, lvl * wspolczynnikUlepszeniaGlowny);
            pojemnosc += pojemnoscLvl;
            lvl++;
        }
        
        /**Funkcja odpowiedzialna za sprawdzenie, czy gracza stać na ulepszenie Tartaku*/
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto) 
            - (lvl * wspolczynnikUlepszeniaPoboczny) >= 0) && 
            (Gra.IloscSurowca(SurowiecEnum.Drewno) - (lvl * wspolczynnikUlepszeniaGlowny) >= 0);
    }
}
