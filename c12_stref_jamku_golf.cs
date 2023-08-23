using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'12) Sestavte program, který za vás zahraje poslední úder do golfového míčku. Stojíte 3 metry od jamky o průměru 10cm (tedy
//'vzdálenost 2,95 až 3,05) a na ty 3 metry má vaše chvějící se ruka rozptyl ± 1m (tedy náhodná reálná čísla 2 až 4). Kolikrát
//'ze 100 úderů se strefíte? A na kolikátý pokus jste se poprvé strefili? (program Doc. Homoly)
namespace C {
    internal class C12_stref_jamku_golf {
        public static void Mainx(string[] args) {
            double sTrefa;
            int prvnisTrefa = 0, sumasTref = 0;
            string ret = "";
            Random rnd = new Random();

            for (int i = 1; i <= 100; i++) {
                sTrefa = Math.Round(rnd.NextDouble() * (4 - 2) + 2, 2);
                if (sTrefa >= 2.95 && sTrefa <= 3.05) {
                    if (prvnisTrefa == 0) {
                        prvnisTrefa = i;
                    }
                        ret = ret + sTrefa + " na " + i + " úder\n";
                        sumasTref++;
                }
            }
            Console.WriteLine("Posledni jamka golfoveho turnaje\nCelkem stref ze 100 úderů: " + sumasTref + "\nPrvni strefa na " + prvnisTrefa + " úder\n\nStrefy:\n" + ret);
        }
    }
}