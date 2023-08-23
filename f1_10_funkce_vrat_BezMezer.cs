using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Náročnější
//'    Složité programy Doc. Homoly
//'10) Sestavte funkci BezMezer s jedním parametrem - textovým řetězcem. Výsledkem volání funkce je tentýž textový řetězec, ve kterém
//'však jsou vypuštěny všechny mezery. Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí ho tak, že v něm
//'jsou vypuštěny všechny mezery.
namespace F1 {
    internal class F1_10_funkce_vrat_BezMezer {
        public static void Mainx(string[] args) {
            string retText, vystup = "";

            Console.Write("Program načte textový řetězec a zobrazí ho tak, že v něm jsou vypuštěny všechny mezery\n\nZadej text (např. větu vč. mezer): ");
            retText = Console.ReadLine();
            Console.WriteLine("Funkcí vrácený text bez mezer: {0}", BezMezerF(retText));
            BezMezerS(retText, ref vystup);
            Console.WriteLine("Subrutnou vrácený text bez mezer: {0}", vystup);
        }
        static string BezMezerF(string text) {
            string textBezMezer = "";

            textBezMezer = text.Replace(" ", "");
            return textBezMezer;
        }

        static void BezMezerS(string text, ref string vysledek) {
            string textBezMezer = "";

            textBezMezer = text.Replace(" ", "");
            vysledek = textBezMezer;
        }
    }
}
