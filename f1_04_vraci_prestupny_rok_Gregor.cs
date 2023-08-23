using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'f04)
//'Napište funkci, které se předá rok (čtyřciferný) a která vrací logickou hodnotu „True“, pokud je rok přestupný (má 366 dní místo 365).
//'Pro jednoduchost stačí řešit podle Juliánského kalendáře (gregoriánský bude za úkol později).
//'Potřebná teorie: Podle Juliánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi
//'Modifikace programu: funkce, která místo True-False bude vracet přímo délku roku (tedy 365 nebo 366), tedy celočíselný datový typ.
//'___________________________________________________________________________________________________________________________________
//' POZOR ZADANI
//'4) Napište funkci, které se předá rok (čtyřciferný) a která vrací logickou hodnotu "True", pokud je rok přestupný
//'(přepracujte z Juliánského kalendáře z BasicCv.doc na Gregoriánský). Řešte dvěma způsoby: dvěma podmínkami
//'(či if-else) i jednou složenou podmínkou.
//'Potřebná teorie: Podle gregoriánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi. Ale roky
//'dělitelné stem jsou přestupné jenom tehdy, jsou-li dělitelné také 400. Přestupnými roky jsou proto například roky
//'1600, 2000, 2400 apod., zatímco roky 1700, 1800, 1900, 2100 atd. přestupné nejsou. (zdroj: wikipedia)
//'___________________________________________________________________________________________________________________________________
namespace F1 {
    internal class F1_04_vraci_prestupny_rok_Gregor {
        public static void Mainx(string[] args) {
            int rok;
            bool vystup;

            Console.Write("Zadej letopočet: ");
            rok = int.Parse(Console.ReadLine());
            vratPrestupnyRokS(rok, out vystup);
            if (vratPrestupnyRokF(rok) == true) {
                Console.WriteLine("Funkce.Zadaný rok {0}, je přestupý, má 366 dnů", rok);
            }
            else {
                Console.WriteLine("Funkce.Zadaný rok {0}, není přestupý, má 365 dnů", rok);
            }
            if (vystup == true) {
                Console.WriteLine("Subrutina.Zadaný rok {0}, je přestupý, má 366 dnů", rok);
            }
            else {
                Console.WriteLine("Subrutina.Zadaný rok {0}, není přestupý, má 365 dnů", rok);
            }
        }

        static bool vratPrestupnyRokF(int letopocet) {

            if (letopocet % 4 == 0 && letopocet % 400 == 0) {
                return true;
            }
            else if (letopocet % 100 == 0) {
                return false;
            }
            else if (letopocet % 4 == 0) {
                return true;
            }
            else {
                return false;
            }
        }
        static void vratPrestupnyRokS(int letopocet, out bool vysledek) {

            if (letopocet % 4 == 0 && letopocet % 400 == 0) {
                vysledek = true;
            }
            else if (letopocet % 100 == 0) {
                vysledek = false;
            }
            else if (letopocet % 4 == 0) {
                vysledek = true;
            }
            else {
                vysledek = false;
            }
        }
    }
}