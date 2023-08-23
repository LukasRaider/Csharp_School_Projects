using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b04)
//'Zadejte tri císla, pocítac zjistí, které je nejvetší a které nejmenší. Aby program nebyl príliš dlouhý, tak nemusíte uvažovat
//'prípady, že by nejaká dve císla byla stejne velká. Tento program je težší, mužete jej nechat na pozdeji.
namespace B {
    internal class B04_nejvetsi_nejmensi_cislo {
        public static void Mainx(string[] args) {
            double cislo, max, min;
            max = 0; min = 0;

            Console.WriteLine("Zadejte tři čísla, počítac zjistí, které je nejvetší a které nejmenší.");
            Console.Write("Zadej číslo: ");
            cislo = double.Parse(Console.ReadLine());
            max = cislo;
            min = cislo;
            Console.Write("Zadej číslo: ");
            cislo = double.Parse(Console.ReadLine());
            if (cislo >= max) { max = cislo; }
            if (cislo <= min) { min = cislo; }
            Console.Write("Zadej číslo: ");
            cislo = double.Parse(Console.ReadLine());
            if (cislo >= max) { max = cislo; }
            if (cislo <= min) { min = cislo; }
            Console.WriteLine("Nejvetší zadané číslo je: " + max + "\nNejmenší zadané číslo je: " + min);
        }
    }
}
