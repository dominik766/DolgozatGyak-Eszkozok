using Eszkozok;
Console.WriteLine("program elindult...");
List<Eszkoz> eszkozok = new List<Eszkoz>();
if (File.Exists("eszkozok.txt"))
{
    foreach (string aktsor in File.ReadAllLines("csomagok.txt")){
        if (!string.IsNullOrWhiteSpace(aktsor)){
            string[] adatok = aktsor.Split(';');

            if (adatok.Count() == 4) {
                // 4 adatos konstruktor
                if (int.TryParse(adatok[3], out int NapiDij)){
                    Eszkoz aktualis = new Eszkoz(adatok[0], adatok[1], adatok[2], NapiDij);
                    eszkozok.Add(aktualis);
                } else { Console.WriteLine("valami nem működött, a sort átugrottam."); continue; }
            } else if (adatok.Count() == 5) 
            {
                if (int.TryParse(adatok[4], out int Keszlet) && int.TryParse(adatok[3], out int NapiDij))
                {
                    Eszkoz aktualis = new Eszkoz(adatok[0], adatok[1], adatok[2], NapiDij, Keszlet);
                } 
                else { Console.WriteLine("valami nem működött, a sort átugrottam."); continue; }
            };
        }
    }
} else { Console.WriteLine("fájl nem található."); }