using System;
using System.Collections.Generic;
using System.Text;

namespace Eszkozok
{
    public static class KoltsegKalkulator
    {
        public static double BerletiDijKedvezmennyel(double alapAr, int napokSzama)
        {
            if (napokSzama < 7) { return alapAr * napokSzama; } else { return alapAr * napokSzama * 0.85}
        }
    }
}
