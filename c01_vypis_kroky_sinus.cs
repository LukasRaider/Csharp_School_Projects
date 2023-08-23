using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//'c01)
//'Vypište tabulku x funkce sinus(x) pro x od 0 do 2*PI s krokem 0,1.
//'Výpis bude vypadat napø. takto:
//'Sin(0, 0) = 0
//'sin(0,1) = 0,0998
//'atd.
//'Nevadí, když místo 0,0998 bude ,0998atic System.Net.Mime.MediaTypeNames;

namespace C {
    internal class C01_vypis_kroky_sinus {
        public static void Mainx(string[] args) {
            string s = "";
            for (double i = 0; i < (Math.PI * 2); i += 0.1) {
                s = s + "Sin(" + Math.Round(i, 1) + ")= " + Math.Round((Math.Sin(i)), 4) + "\n";
            }
            Console.WriteLine(s);
        }
    }
}

