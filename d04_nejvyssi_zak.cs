using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'d04)
//'Varianta na b5): Program postupně čte nejprve jméno a pak výšku žáka. Prázdné jméno načítání ukončuje.
//'Poté zobrazí jméno a výšku nejvyššího žáka. Když jsou nejvyšší dva a více stejně vysocí, napíše jen jednoho.
//'Bude zdokonaleno později v sekci e) v BasicCv_těžší
namespace D_ {
    internal class D04_nejvyssi_zak {
        public static void Mainx(string[] args) {
            int vyska, maxVyska;
            string jmeno, maxJmeno;
            bool asonJenedZak;

            Console.WriteLine("Program postupně čte nejprve jméno a pak výšku žáka. Prázdné jméno načítání ukončuje.\r\nPoté zobrazí jméno a výšku nejvyššího žáka.\n");

            Console.Write("Zadej jméno žáka: ");
            jmeno = Console.ReadLine();
            Console.Write("Zadej výšku žáka [cm]: ");
            vyska = int.Parse(Console.ReadLine());
            maxJmeno = jmeno;
            maxVyska = vyska;
            if (jmeno == "") {
                asonJenedZak = false;
            }
            else {
                asonJenedZak = true;
            }
            while (jmeno != "") {
                Console.Write("\nZadej jméno žáka: ");
                jmeno = Console.ReadLine();
                if (jmeno != "") {
                    Console.Write("Zadej výšku žáka [cm]: ");
                    vyska = int.Parse(Console.ReadLine());
                    if (vyska > maxVyska) {
                        maxJmeno = jmeno;
                        maxVyska = vyska;
                    }
                }
            }
            if (asonJenedZak) {
                Console.WriteLine("Nejvyšší je {0} s výškou {1} cm.", maxJmeno, maxVyska);
            }
            else {
                Console.WriteLine("\nNebyl zadán žádný žák!");
            }
        }
    }
}