using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    public class Farma : IBudynek
    {
        public Farma(int Lvl, int Pojemnosc, int PojemnoscLvl,
        int WspolczynnikUlepszeniaPoboczny, int WspolczynnikUlepszeniaGlowny,
            String NazwaSurowcaGlowna, String NazwaSurowcaPoboczna)
        {
            this.Lvl = Lvl;
            this.Pojemnosc = Pojemnosc;
            this.Nazwa = BudynekEnum.Farma;
            this.WspolczynnikUlepszeniaPoboczny = WspolczynnikUlepszeniaPoboczny;
            this.WspolczynnikUlepszeniaGlowny = WspolczynnikUlepszeniaGlowny;
            this.PojemnoscLvl = PojemnoscLvl;
            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
            this.NazwaSurowcaPoboczna = NazwaSurowcaPoboczna;
        }

        public int Lvl { get; set; }
        public int Pojemnosc { get; set; }
        public BudynekEnum Nazwa { get; set; }

        public int WspolczynnikUlepszeniaPoboczny { get; set; }
        public int WspolczynnikUlepszeniaGlowny { get; set; }
        public String NazwaSurowcaGlowna { get; set; }
        public String NazwaSurowcaPoboczna { get; set; }
        public int PojemnoscLvl { get; set; }

        //upgrade kosztuje surowce, wiec trzeba je odjac z konta gracza
        public void Upgrade()
        {
            if (Lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, Lvl * WspolczynnikUlepszeniaPoboczny);
            Gra.OdejmijSurowiec(SurowiecEnum.Jedzenie, Lvl * WspolczynnikUlepszeniaGlowny);
            Pojemnosc += PojemnoscLvl;
            Lvl++;
        }
        //funkcja sprawdza czy upgrade jest w ogole mozliwy, a tym samym czy powinien byc dostepny dla gracza
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto) - (Lvl * WspolczynnikUlepszeniaPoboczny) >= 0)
            && (Gra.IloscSurowca(SurowiecEnum.Jedzenie) - (Lvl * WspolczynnikUlepszeniaGlowny) >= 0);
    }
}
