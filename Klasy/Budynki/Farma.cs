using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    /// <summary>
    /// Klasa odpowiedzialna stworzenie obiektu budynku Farma
    /// Dziedziczy po interfejsie IBudynek
    /// </summary>
    public class Farma : IBudynek
    {
        /**Konstruktor klasy Farma, przypisuje konretne wartości polom tej klasy*/
        public Farma(int lvl, int pojemnosc, int pojemnoscLvl,
        int wspolczynnikUlepszeniaPoboczny, int wspolczynnikUlepszeniaGlowny,
            String NazwaSurowcaGlowna, String NazwaSurowcaPoboczna)
        {
            this.lvl = lvl;
            this.pojemnosc = pojemnosc;
            this.Nazwa = BudynekEnum.Farma;
            this.wspolczynnikUlepszeniaPoboczny = wspolczynnikUlepszeniaPoboczny;
            this.wspolczynnikUlepszeniaGlowny = wspolczynnikUlepszeniaGlowny;
            this.pojemnoscLvl = pojemnoscLvl;
            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
            this.NazwaSurowcaPoboczna = NazwaSurowcaPoboczna;
        }

        /**Pole odpowiedzialne za lvl Farmy*/
        public int lvl { get; set; }

        /**Pole odpowiedzialne za pojemnosc Farmy*/
        public int pojemnosc { get; set; }

        /**Pole odpowiedzialne za nazwę Farmy*/
        public BudynekEnum Nazwa { get; set; }

        /**Pole odpowiedzialne za współczynnik ceny w pobocznego surowca potrzebnego do 
         * ulepszenia Farmy*/
        public int wspolczynnikUlepszeniaPoboczny { get; set; }

        /**Pole odpowiedzialne za współczynnik ceny w głównym surowca potrzebnego do 
         * ulepszenia Farmy*/
        public int wspolczynnikUlepszeniaGlowny { get; set; }

        /**Pole odpowiedzialne za nazwę głównego surowca potrzebnego do ulepszenia Farmy*/
        public String NazwaSurowcaGlowna { get; set; }

        /**Pole odpowiedzialne za nazwę pobocznego surowca potrzebnego do ulepszenia Farmy*/
        public String NazwaSurowcaPoboczna { get; set; }

        /**Pole odpowiedzialne za ilość zwiększania pojemności Farmy co lvl*/
        public int pojemnoscLvl { get; set; }

        /**Funkcja odpowiedzialna za odejmowanie surowców z "konta" gracza, o ile budynek nie 
         * posiada już maksymalnego lvl. Ponadto zwiększa ilość pojemności w Farmy oraz zwiększa 
         * jego lvl*/
        public void Upgrade()
        {
            if (lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, lvl * wspolczynnikUlepszeniaPoboczny);
            Gra.OdejmijSurowiec(SurowiecEnum.Jedzenie, lvl * wspolczynnikUlepszeniaGlowny);
            pojemnosc += pojemnoscLvl;
            lvl++;
        }

        /**Funkcja odpowiedzialna za sprawdzenie, czy gracza stać na ulepszenie Farmy*/
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto)
            - (lvl * wspolczynnikUlepszeniaPoboczny) >= 0)
            && (Gra.IloscSurowca(SurowiecEnum.Jedzenie)
            - (lvl * wspolczynnikUlepszeniaGlowny) >= 0);
    }
}
