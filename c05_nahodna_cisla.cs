using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'c05)
//'Vygenerujte 20 celých náhodných celých čísel v rozsahu <10..50>.
//'Zjistěte, o kolik se jejich střední hodnota (průměr) liší od středu intervalu, tedy od 30.

//'Krokujte klávesou F8 příklad č. 5 z této sekce. Zobrazte si okno Locals Window (viz nabídka View) a sledujte, jak se postupně mění hodnoty proměnných.
//'(Pozn. toto vám při zkoušce může velmi pomoct v řešení problémů.)
namespace C {
    internal class C05_nahodna_cisla {
        public static void Mainx(string[] args) {
            Random rnd = new Random();
            int suma = 0, rndCisla;
            string ret = "";

            for (int i = 0; i < 20; ++i) {
                rndCisla = rnd.Next(10, 51);
                suma = suma + rndCisla;
                ret = ret + rndCisla + "\n";
            }
            Console.WriteLine("20 celých náhodných celých čísel v rozsahu <10..50>\n" + (ret) + "\nPrůměr čísel se liší od středu intervalu o: " + Math.Round((double)suma / 20 - 30, 2));
        }
    }
}
