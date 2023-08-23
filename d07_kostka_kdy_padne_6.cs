using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//'d07)
//'Program hází kostkou tak dlouho, dokud nepadne šestka. Potom vypíše, kolik hodù bylo potřeba.
namespace D_ {
    internal class D07_kostka_kdy_padne_6 {       //d07_kostka_kdy_padne_6
        public static void Mainx(string[] args) {
            int hodKostkou, pocitadlo = 0;
            Random rnd = new Random();

            Console.WriteLine("//'d07)\r\n//'Program hází kostkou tak dlouho, dokud nepadne šestka. Potom vypíše, kolik hodù bylo potřeba.\n\n");

            Console.WriteLine("Vypis hodů:");
            do {
                hodKostkou = rnd.Next(1, 7);
                Console.Write(hodKostkou + " ");
                pocitadlo++;
            } while (hodKostkou != 6);
            Console.WriteLine("padla na {0} hod kostkou", pocitadlo);
        }
    }
}

