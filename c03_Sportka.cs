using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'c03)
//'Vytvořte program, který táhne 5 čísel Sportky (čísla 1 až 49).
//'čísla se (na rozdíl od Sportky) mohou opakovat.
namespace C {
    internal class C03_Sportka {
        public static void Mainx(string[] args) {
            string ret = "";
            Random rnd = new Random();

            for (int i = 0; i < 5; i++) {
                ret = ret + rnd.Next(1, 50) + "\n";
            }
            Console.WriteLine("Sportka - pět náhodných čísel (1-49) \n" + ret);
        }
    }
}
