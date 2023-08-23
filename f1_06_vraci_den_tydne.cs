using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'f06)
//'Funkce, které se předá číslo 1 až 7 a vrací slovně den v týdnu. Vytvořte variantu s Else if i se Select Case.
namespace F1 {
    internal class F1_06_vraci_den_tydne {
        public static void Mainx(string[] args) {
            byte cisloDne;
            string vystup = "";

            Console.Write("Zadej číslo dne v týdnu (1-7): ");
            cisloDne = byte.Parse(Console.ReadLine());
            Console.WriteLine("Vráceno funkcí: " + vratDenF(cisloDne));
            vratDenS(cisloDne, ref vystup);
            Console.WriteLine("Vráceno subrutinou: " + vystup);
        }

        static string vratDenF(byte x) {
            if (x == 1) return "pondělí";
            if (x == 2) return "úterý";
            if (x == 3) return "středa";
            if (x == 4) return "čtvrtek";
            if (x == 5) return "pátek";
            if (x == 6) return "sobota";
            if (x == 7) return "neděle";
            return null;
        }

        static void vratDenS(byte x, ref string vysledek) {
            switch (x) {
                case 1: vysledek = "pondělí"; break;
                case 2: vysledek = "úterý"; break;
                case 3: vysledek = "středa"; break;
                case 4: vysledek = "čtvrtek"; break;
                case 5: vysledek = "pátek"; break;
                case 6: vysledek = "sobota"; break;
                case 7: vysledek = "neděle"; break;
            }
        }
    }
}
