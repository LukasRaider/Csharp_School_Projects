using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'a11)
//'Sestavte program, který se zeptá na délku bežecké trati v metrech a poté na cas bežce na této trati ve vterinách. Poté
//'zobrazí, jakou prumernou rychlostí v [km/hod] bežec bežel. (program Doc. Homoly)
namespace A {
    internal class A11_prumerna_rychlost {
        public static void Mainx(string[] args) {
            float trat, cas;
            Console.Write("Zadej délku trati (m): ");
            trat = float.Parse(Console.ReadLine());
            Console.Write("Zadej zabehnutý cas v sekundách na uvedené trati: ");
            cas = float.Parse(Console.ReadLine());
            Console.WriteLine("Bežec bežel prumernou rychlostí " + vratPrumRychlost(trat, cas) + " km/h");
        }
        static float vratPrumRychlost(float D, float t) {
            const float prevod = (float)3.6;
            return D / t * prevod;
        }
    }
}


