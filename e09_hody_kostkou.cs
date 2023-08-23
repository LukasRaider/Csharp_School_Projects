using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'e09)Sestavte program, který se nejprve zeptá na počet hodů kostkou.
//'Pak tolikrát "hodí kostkou" a zobrazí, kolikrát padla jednotlivá čísla celkem a percentuelně. (program Doc. Homoly)
namespace E {
    internal class E09_hody_kostkou {
        public static void Mainx(string[] args) {
            double pocetHodu;
            int[] pole = new int[100000];
            int[] vyskyty = new int[6];
            Random rnd = new Random();

            Console.Write("Kolikrat se ma hodit kostkou? (max. 100 000x): ");
            pocetHodu = int.Parse(Console.ReadLine());
            for (int i = 0; i < pocetHodu; i++) {
                pole[i] = rnd.Next(1, 7);
                Console.Write(pole[i] + " ");
            }
            for (int i = 0; i < pocetHodu; i++) {
                vyskyty[pole[i] - 1] += 1;
            }
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine((i + 1) + " padlo " + vyskyty[i] + "x, což je " + Math.Round(vyskyty[i] / pocetHodu * 100, 3) + "%");
            }
        }
    }
}