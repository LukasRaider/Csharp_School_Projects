using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a03)
//Zadejte teplotu v 6, 12 a 18 hodin. Zobrazí se prumerná denní teplota.
namespace A {
    internal class A03_prumer_teplot {
        public static void Mainx(string[] args) {

            float tep_1, tep_2, tep_3;
            Console.Write("Zadej teplotu v 6:00 (°C): ");
            tep_1 = float.Parse(Console.ReadLine());
            Console.Write("Zadej teplotu ve 12:00 (°C): ");
            tep_2 = float.Parse(Console.ReadLine());
            Console.Write("Zadej teplotu v 18:00 (°C): ");
            tep_3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Průměrná denní teplota je: " + ((tep_1 + tep_2 + tep_3) / 3) + " °C");
        }
    }
}




