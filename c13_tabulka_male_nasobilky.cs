using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'Dvojitý cyklus For
//'13) Vypište tabulku malé násobilky.Bude 10 sloupců (+záhlaví) a 10 řádků (+záhlaví). Tedy první sloupec a první řádek jsou
//'záhlaví:
//'   1   2   3   4   5   6   7   8   9   10      toto je záhlaví
//'1  1   2   3   4   5   6   7   8   9   10
//'2  2   4   6   8   10  12  14  16  18  20
//'3  3   6   9   12  15  18  21  24  27  30
//'4 atd.
namespace C {
    internal class C13_tabulka_male_nasobilky {
        public static void Mainx(string[] args) {
            int r, s;                      //r je počitadlo řádků, s sloupců
            Console.Write("       ");        //vycpávka, aby záhlaví nebylo posunuté
            for (s = 1; s <= 10; s++)
                Console.Write("{0,5}", s);   //záhlaví sloupců
            Console.WriteLine("\n");         //odřádkování za záhlavím a volný řádek
            for (r = 1; r <= 10; r++) {
                Console.Write("{0,5}: ", r); //záhlaví řádků
                for (s = 1; s <= 10; s++)
                    Console.Write("{0,5}", r * s);
                Console.WriteLine();
            }


            //int soucin;
            //string vypis = "Tabulka male násobilky\n\n";

            //for (byte r = 1; r <= 10; ++r) {            //r=radek, s=sloupec
            //    for (byte s = 1; s <= 10; ++s) {
            //        soucin = r * s;
            //        if (soucin < 10) {
            //            vypis += "  " + soucin;
            //        }
            //        else {
            //            vypis += " " + soucin;
            //        }
            //    }
            //    vypis += "\n";
            //}
            //Console.WriteLine(vypis);
        }
    }
}

