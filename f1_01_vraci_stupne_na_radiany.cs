using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//'f01)
//    'Napište funkci, která převádí stupně a minuty na radiány.
//    'Proměnné se předávají přes parametry podprogramu, v hlavním programu použijte jiné názvy proměnných než v podprogramu.
//    'Návod: řešte trojčlenkou. Plnému kruhu odpovídá 360 stupňů nebo 2 pí radiánů (přibližně 6,28 radiánů).
namespace F1 {
    internal class F1_01_vraci_stupne_na_radiany {
        public static void Mainx(string[] args) {
            int stupne, minuty;
            float vystup;

            Console.WriteLine("//f01)\r\n//Funkce převádí stupně a minuty na radiány.\r\n");

            Console.Write("Zadej uhel ve stupnich(°): ");
            stupne = int.Parse(Console.ReadLine());
            Console.Write("Zadej kolik ma uhel minut('): ");
            minuty = int.Parse(Console.ReadLine());
            prevodRadianyS(stupne, minuty, out vystup);
            Console.WriteLine("Vráceno funkci\nÚhel {0}°{1}' se rovná {2} radiánů", stupne, minuty, prevodRadianyF(stupne, minuty));
            Console.WriteLine("Vráceno subrutinou\nÚhel {0}°{1}' se rovná {2} radiánů", stupne, minuty, Math.Round(vystup, 4));
        }

        static float prevodRadianyF(int x, int y) {
            return ((x * 60) + y) * (180 / (float)Math.PI / 60);
        }

        static void prevodRadianyS(int x, int y, out float vysledek) {
            vysledek = ((x * 60) + y) * (180 / (float)Math.PI / 60);
        }
    }
}
