using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'a10)
//'Prevedte úhel zadaný v radiánech na stupne. Návod: rešte trojclenkou. Plnému kruhu odpovídá 360 stupnu nebo 2 pí
//'radiánu (približne 6,28 radiánu). Tedy jeden radián je 180/? = 57,296 stupnu. Kdo neví, co jsou radiány, tak tento program
//'nemusí vypracovávat.
namespace A {
    internal class A10_radiany_na_stupne {
        public static void Mainx(string[] args) {
            float uhel;

            Console.Write("Zadej úhel v radiánech: ");
            uhel = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadaný úhel " + uhel + " v radiánech je roven " + vratStupne(uhel) + "°");
        }
        static float vratStupne(float radian) {
            const float rad = (float)(180.0 / System.Math.PI);
            return (float)Math.Round((rad * radian), 4);
        }
    }
}


