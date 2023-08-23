using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'c02)
//'Program vygeneruje deset náhodných celých císel (napr. od -90 do 100). Zjistěte, kolik z nich je v urcitém intervalu (napr. od 10 do 50)
//'S algoritmizací tohoto programu si některí úcastníci nevědí rady. Pokud je to i váš prípad, tak príklad zkuste nejprve vyrešit bez pocítace.
//'Vezměte deset malých papírkù na poznámky a napište na ně náhodně císla od -90 do +100. Nachystejte si i papír, který nadepíšete napr. pocetCiselVIntervalu.
//'Potom vezměte první papírek, prectěte jej,  a pokud je v rozsahu mezi 10 a 50, pak na papír nadepsaný pocetCiselVIntervalu napíšete cárku.
//'Toto proveďte 10x (tedy na jiný papír, nazvaný index, si děláte cárky a až jich bude 10, tak skoncíte).
//'Poté slavnostně oznamte, kolik máte cárek na papíru pocetCiselVIntervalu. A pak to zkuste zapsat ve Visual Basicu.
//'Vlastně stací následující popis prevést do anglictiny:
//'Následující cinnost proveď 10x (tedy zvyšuj pri každém prùchodu hodnotu proměnné index od 1 do 10):
//'nactěte do proměnné (papírku) náhodné císlo v rozsahu <-90, 100>
//'pokud je proměnná v rozsahu mezi 10 a 50, pak zvýšíte hodnotu proměnné pocetCiselVIntervalu o jednicku
//'konec opakované cinnosti oznamte hodnotu proměnné pocetCiselVIntervalu
namespace C {
    internal class C02_nahodna_v_intervalu {
        public static void Mainx(string[] arsg) {
            int[] poleCisel = new int[10];
            byte pocetCiselVIntervalu = 0;
            Random r = new Random();

            for (int i = 0; i < poleCisel.Length; i += 1) {
                poleCisel[i] = r.Next(-90, 101);
            }
            for (int i = 0; i < poleCisel.Length; i += 1) {
                if (poleCisel[i] >= 10 && poleCisel[i] <= 50) {
                    pocetCiselVIntervalu++;
                }
            }
            Console.WriteLine("Z 10 vygenerovaných císel (od -90 do 100) se jich v intervalu (od 10 do 50) nachází: " + pocetCiselVIntervalu);
        }
    }
}
