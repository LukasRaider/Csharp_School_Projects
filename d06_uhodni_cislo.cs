using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'d06)
//'Upraveno podle Doc. Homoly: Sestavte program, který si myslí (náhodně vygeneruje) celé číslo z intervalu <1,10>.
//'Pak ho vy hádáte (zadáváte z klávesnice), dokud se nestrefíte. Počítač vypíše, na který pokus se to podařilo.
namespace D_ {
    internal class D06_uhodni_cislo {
        public static void Mainx(string[] args) {
            int nahodne, pocitadlo = 1, tip;
            Random rnd = new Random();

            Console.WriteLine("//'d06)\r\n//'Upraveno podle Doc. Homoly: Sestavte program, který si myslí (náhodně vygeneruje) celé číslo z intervalu <1,10>.\r\n//'Pak ho vy hádáte (zadáváte z klávesnice), dokud se nestrefíte. Počítač vypíše, na který pokus se to podařilo.\n\n");

            nahodne = rnd.Next(1, 11);
            //Console.WriteLine(nahodne);
            Console.Write("Hádej číslo od 1 do 10: ");
            tip = int.Parse(Console.ReadLine());
            while (tip != nahodne) {
                Console.Write("Neuhodl jsi.\nHádej znovu číslo od 1 do 10: ");
                tip = int.Parse(Console.ReadLine());
                pocitadlo++;
            }
            Console.WriteLine("Uhodli jste na {0} pokus", pocitadlo);
        }
    }
}
