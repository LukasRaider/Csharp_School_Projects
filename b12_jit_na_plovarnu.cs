using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b12)
//'Program se zeptá, zda je den a zda je horko (odpoved a/n). Pouze v pøípade obou odpovedí kladných vám navrhne jít si zaplavat.
//'Použijte jen jeden pøíkaz IF (ale se složenou podmínkou). Jednodušší varianta: pøedpokládejme, že uživatel bude uvedomele zadávat malá písmena.
//'Složitejší varianta: program bude reagovat stejne na „a“ i „A“
namespace B {
    internal class B12_jit_na_plovarnu {
        public static void Mainx(string[] args) {
            string fazeDne, horko;
            Console.WriteLine("Je vhodná doba jít na plovárnu?");
            Console.Write("Je den? (odpoved a/n): ");
            fazeDne = Console.ReadLine();
            Console.Write("Je horko? (odpoved a/n): ");
            horko = Console.ReadLine();
            if ((fazeDne == "a" || fazeDne == "A") && (horko == "a" || horko == "A")) {
                Console.WriteLine("Bež na plovárnu.");
            }
            else if ((fazeDne == "n" || fazeDne == "N") && (horko == "a" || horko == "A")) {
                Console.WriteLine("Je noc! Plovárnu je zavrena.");
            }
            else if ((fazeDne == "a" || fazeDne == "A") && (horko == "n" || horko == "N")) {
                Console.WriteLine("Je zima nejlepsi doba na otuzovani.");
            }
            else if ((fazeDne == "n" || fazeDne == "N") && (horko == "n" || horko == "N")) {
                Console.WriteLine("Je zima na plavani a navic je noc!");
            }
        }
    }
}
