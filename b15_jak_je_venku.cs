using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Select Case
//'15) Program se zeptá, jak je venku, nabídne vám: úmorné vedro, zima, déšť, mlha, tma, chumelenice, atd.
//'Podle toho vám navrhne, co máte dělat, např. dobře se obléci, jít na plovárnu atd. Nepoužívejte příkaz IF.
namespace B {
    internal class B15_jak_je_venku {
        public static void Mainx(string[] args) {
            int jakJeVenku;
            Console.Write("Jak je venku?\n1 - úmorné vedro\n2 - zima\n3 - déšť\n4 - tma\n5 - chumelenice\n6 - smogova situace\nVyber jednu z možností: ");
            jakJeVenku = int.Parse(Console.ReadLine());
            Console.WriteLine(VratOdpovednaPocasi(jakJeVenku));
        }
        static string VratOdpovednaPocasi(int cislo) {
            switch (cislo) {
                case 1: return "\nJdi k vode."; break;
                case 2: return "\nTeple se oblec."; break;
                case 3: return "\nNazapomen si destnik."; break;
                case 4: return "\nJe noc, nikam nechod."; break;
                case 5: return "\nPozor na huste snezeni."; break;
                case 6: return "\nNevetrat a nechodit ven."; break;
                default: return "\nNabyla vybrýna žádná z uvedených možností.";
            }
        }
    }
}



