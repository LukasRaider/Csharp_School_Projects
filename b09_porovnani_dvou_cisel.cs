using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b09)
//'Zadejte dvě čísla, počítač napíše "První číslo je větší (nebo menší)" (příliš lehké)
namespace B {
    internal class B09_porovnani_dvou_cisel {
        public static void Mainx(string[] args) {
            double a, b;
            Console.WriteLine("Zadejte dvě čísla, počítač napíše \"První číslo je větší (nebo menší)\"");
            Console.Write("Zadej první číslo: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Zadej druhé číslo: ");
            b = double.Parse(Console.ReadLine());
            if (a > b) {
                Console.WriteLine("První číslo je větši");
            }
            else if (a == b) {
                Console.WriteLine("První číslo se rovna druhému");
            }
            else {
                Console.WriteLine("První číslo je menší");
            }
        }
    }
}
