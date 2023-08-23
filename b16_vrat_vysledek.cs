using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Select Case
//'16) Uživatel zadá dvě čísla. Poté se objeví nabídka, zda chce sčítat, odčítat, násobit, dělit nebo končit.
//'Poté se objeví výsledek vybrané operace se zadanými čísly nebo program skončí.
namespace B {
    internal class B16_vrat_vysledek {
        public static void Mainx(string[] args) {
            double cislo1, cislo2;
            string typOperace;

            Console.Write("Zadej prvni cislo: ");
            cislo1 = double.Parse(Console.ReadLine());
            Console.Write("Zadej druhe cislo: ");
            cislo2 = double.Parse(Console.ReadLine());
            Console.Write("\nPro scitani zadej +\nPro odcitani zadej -\nPro nasobeni zadej *\nPro deleni zadej /\nPro ukonceni progaramu zadej ENTER\nVyber operaci: ");
            typOperace = Console.ReadLine();
            Console.WriteLine(vratOperaciAvysledek(cislo1, cislo2, typOperace));
        }
        static object vratOperaciAvysledek(double hodnota1, double hodnota2, string znak) {
            switch (znak) {
                case "+": return hodnota1 + hodnota2; break;
                case "-": return hodnota1 - hodnota2; break;
                case "*": return hodnota1 * hodnota2; break;
                case "/": return System.Math.Round((double)hodnota1 / hodnota2, 2); break;
                default: return "Nebyla vybrána správná volba";
            }
        }
    }
}

