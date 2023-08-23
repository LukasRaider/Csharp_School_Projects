using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'A12) Sestavte program, který se zeptá na průměr vašeho kruhového bazénu a poté na jeho výšku (obojí v metrech).
//'Poté zobrazí, kolik tun vody se Do něj vejde (1 m3 vody = 1 tuna). (program Doc. Homoly)
namespace A {
    internal class A12_ObjemValce {
        public static void Mainx(string[] args) {
            byte prumerBazenu, hloubkaBazenu;
            Console.Write("Zadej průměr bazénu (m): ");
            prumerBazenu = byte.Parse(Console.ReadLine());
            Console.Write("Zadej hloubku bazénu (m): ");
            hloubkaBazenu = byte.Parse(Console.ReadLine());
            Console.WriteLine("V bazénu je " + vratObjemValce(prumerBazenu, hloubkaBazenu) + " tun vody");
        }
        static float vratObjemValce(byte d, byte v) {
            float r = d / 2;
            return (float)Math.Round((float)Math.PI * r * r * v, 2);
        }
    }
}

