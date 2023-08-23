using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'    Náročnější
//'    Složité programy Doc. Homoly
//'9) Sestavte funkci ObratText s jedním parametrem - textovým řetězcem. Výsledkem volání funkce je tentýž textový řetězec, ale má znaky
//'v obráceném pořadí. Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí ho v obráceném pořadí znaků.
namespace F1 {
    internal class F1_09_funkce_vrat_ObratText {
        public static void Mainx(string[] args) {
            string retText, vystup = "";

            Console.Write("Program načte textový řetězec a zobrazí ho v obráceném pořadí znaků\n\nZadej text: ");
            retText = Console.ReadLine();

            Console.WriteLine("Funkcí vrácený obrácený text: {0}", ObratTextF(retText));
            ObratTextS(retText, ref vystup);
            Console.WriteLine("Subrutinou vrácený obrácený text: {0}", vystup);
        }

        static string ObratTextF(string retezec) {
            string retPozpatku = "";

            for (int j = retezec.Length - 1; j >= 0; j--) {
                retPozpatku += retezec[j];
            }
            return retPozpatku;
        }

        static void ObratTextS(string retezec, ref string retPozpatku) {

            for (int j = retezec.Length - 1; j >= 0; j--) {
                retPozpatku += retezec[j];
            }
        }
    }
}