using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
//a07)
//Zadejte pocet sudu a množství litru v sudu (ve všech je stejne). Kolik litru je celkem? (príliš lehké)
namespace A {
    internal class A07_Objem_sudu {
        public static void Mainx(string[] args) {
            int sud;
            float objem;

            Console.Write("Zadej pocet sudů (Ks): ");
            sud = int.Parse(Console.ReadLine());
            Console.Write("Zadej objem jednoho sudu (l): ");
            objem = float.Parse(Console.ReadLine());
            Console.WriteLine("Celkový objem " + sud + " sudů je " + (sud * objem) + " litrů.");
        }
    }
}
