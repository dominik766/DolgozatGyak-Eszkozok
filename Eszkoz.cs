using System;
using System.Collections.Generic;
using System.Text;

namespace Eszkozok
{
    internal class Eszkoz
    {
        // belső tárolók
        private int napiDij;
        private int keszlet;
        private int osszesRegisztraltEszkoz = 0;

        // tulajdonságok ( properties ) 
        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public string Kategoria { get; set; }


        // nem lehet negativ szam
        // rovidebb iffel feladva
        // set => napiDij kisebb mint 0 ? igaz = allitsa 0-ra : hamis = maradjon meg
        public int NapiDij { get => napiDij; set => napiDij = value < 0 ? 0 : value; }


        // nem lehet egynel kisebb
        // ugyanaz a method
        public int Keszlet { get => keszlet; set => keszlet = value < 1 ? 1 : value; }


        // csak olvashato property, tehat nincs set ag
        public int OsszesRegisztraltEszkoz { get => osszesRegisztraltEszkoz; }

        // konstruktorok

        // 1
        // konstruktor lancolassal meghivja a masikat
        // ... : this() => zarojelbe a masik konstruktor parameterei, ilyen esetbe az alapertekeket itt meg lehet adni
        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij) : this(azonosito, nev, kategoria, napiDij, 1) {  }

        // 2
        // a konstruktor parametereibe a belso tarolok mennek!
        public Eszkoz(string azonosito, string nev, string kategoria, int napiDij, int keszlet)
        {
            // eloszor a property (nagybetus), aztan a belsotarolo (kisbetus)
            // tulajdonsagok beallitasa
            Azonosito = azonosito;
            Nev = nev;
            Kategoria = kategoria;
            NapiDij = napiDij;
            Keszlet = keszlet;
            // hozzaadunk 1-et az osszhoz
            // a belso tarolohoz!!!
            osszesRegisztraltEszkoz++;
        }

        // metodusok

        // 1
        // ToString()
    }
}
