using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//'c04)
//'Vypište klesající posloupnost čísel od 8 do -8.
//'Varianta: vypište stejnou posloupnost, ale pouze každé druhé (sudé) číslo. (Nepoužívejte if.)
namespace C {
    internal class C04_klesajici_posloupnost {
        public static void Mainx(string[] args) {
            string ret = "";
            for (int i = 8; i >= -8; i -= 1) {         //pro variantu výpisu pouze sude čísel stačí nastavit Step -2
                ret = ret + i + "\n";
            }
            Console.WriteLine("Klesající posloupnost čísel od 8 do -8\n" + ret);
        }
    }
}
