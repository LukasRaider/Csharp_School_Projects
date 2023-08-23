using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//c10)
//Vytvořte program pro zkoušení malé násobilky.
//Program zadává náhodně násobení čísel od 1 do 10, např. 5*6=, 8*4= atd.
//Uživatel napíše výsledek. Pokud to je špatně, napíše počítač správný výsledek.
//Celkem 10 příkladů, nakonec se zobrazí počet chyb.
namespace C {
    internal class C10_mala_nasobilka {
        public static void Mainx(string[] args) {
            double cinitel1, cinitel2, soucin, tipVysledek;
            int pocitadlo = 0;
            Random rnd = new Random();

            Console.WriteLine("Zkouška z malé násobilky");
            for (int i = 1; i <= 10; i++) {
                cinitel1 = (rnd.Next(1, 11));
                cinitel2 = (rnd.Next(1, 11));
                soucin = cinitel1 * cinitel2;
                Console.Write("Zadej výsledek příkladu " + cinitel1 + " x " + cinitel2 + " = ");
                tipVysledek = int.Parse(Console.ReadLine());
                if (soucin == tipVysledek) {
                    Console.WriteLine("Správná odpověď.");
                }
                else {
                    Console.WriteLine(tipVysledek + " je chyba, správný výsledek " + cinitel1 + " x " + cinitel2 + " = " + soucin);
                    pocitadlo++;
                }
            }
            Console.WriteLine("Počet chyb " + pocitadlo + " z 10 příkladů.");
        }
    }
}

