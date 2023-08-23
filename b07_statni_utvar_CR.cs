using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b07)
//'Uživatel zadá letopocet (od roku 1600). Program vrátí název státního útvaru, ve kterém jsme se tehdy nacházeli (Rakousko,
//'Rakousko-Uhersko, Ceskoslovenská republika, Protektorát Böhmen und Mähren atd.). Rešte pomocí else if.
namespace B {
    internal class B07_statni_utvar_CR {
        public static void Mainx(string[] args) {
            int letoPocet;

            Console.WriteLine("Státního útvar, ve kterém jsme se nacházeli (od roku 1600)");
            Console.Write("Zadej letopočet: ");
            letoPocet = int.Parse(Console.ReadLine());
            Console.WriteLine(VratUtvarCR(letoPocet));
        }

        public static string VratUtvarCR(int rok) {
            if (rok >= 1600 && rok <= 1803) {
                return "Habsburská monarchie: 1526 - 1804";
            }
            else if (rok >= 1804 && rok <= 1866) {
                return "Rakouské císarství: 1804 - 1867";
            }
            else if (rok >= 1867 && rok <= 1917) {
                return "Rakousko-Uhersko: 1867 - 1918";
            }
            else if (rok >= 1918 && rok <= 1938) {
                return "Ceskoslovenská republika: 1918 - 1939";
            }
            else if (rok >= 1939 && rok <= 1944) {
                return "Protektorát Cechy a Morava: 1939 - 1945";
            }
            else if (rok >= 1945 && rok <= 1989) {
                return "CSSR: 1945 - 1990";
            }
            else if (rok >= 1990 && rok <= 1992) {
                return "CSFR: 1990 - 1992";
            }
            else if (rok >= 1993 && rok <= 2023) {
                return "CR: 1993 - 2023";
            }
            else if (rok >= 2024) {
                return "Neumím veštit z koule.\nNejvyšší možný letopocet, který mùže být zadán je r. 2023.";
            }
            else {
                return null;
            }
        }
    }
}
