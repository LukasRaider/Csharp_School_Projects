using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a05)
//Zadejte cástku penez, které jsou uloženy v bance, rocní úrok a délku uložení (pocet roku). Vypocítejte, kolik bude v bance
//po uplynutí uvedené doby. Nepocítejte úroky z úroku. Modelový príklad: 1000 Kc na 2 roky s úrokem 1 % rocne = 1020 Kc
namespace A {
    public class A05_uspory {
        public static void Mainx(string[] args) {
            byte roky;
            float castka, urok;

            Console.Write("Zadej uloženou castku penez (Kc): ");
            castka = float.Parse(Console.ReadLine());
            Console.Write("Zadej pocet let úschovy: ");
            roky = byte.Parse(Console.ReadLine());
            Console.Write("Zadej rocní úrokovou sazbu (%): ");
            urok = float.Parse(Console.ReadLine());
            Console.WriteLine("Vlozili jste do banky " + castka + " Kc" + " na " + roky + " rok(u) s rocnim urokem " + urok + " %\n Po uplynutí doby bude v bance " + ((float)castka + (castka * roky * urok / 100)) + " Kc");
        }
    }
}


