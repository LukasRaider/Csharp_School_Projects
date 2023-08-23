using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2 {
    internal class F2_11_vraci_zasifrovane_pole_znaku {
        public static void Mainx(string[] args) {
            string[] pole = new string[1], polePoSifrovani;
            string ret = "", retPoSifrovani = "";
            int i = 0;

            Console.Write("Zadej znak (ENTER=konec): ");
            pole[i] = Console.ReadLine();
            ret = pole[i] + " ";

            while (pole[i] != "") {
                i++;
                Array.Resize(ref pole, i + 1);
                Console.Write("Zadej znak (ENTER=konec): ");
                pole[i] = Console.ReadLine();
                if (pole[i] != "") {
                    ret += pole[i];
                }
            }
            Array.Resize(ref pole, i);

            polePoSifrovani = VratZasifrovaneSlovo(pole);

            foreach (var item in polePoSifrovani) {
                Console.WriteLine(item);
            }



        }

        public static string[] VratZasifrovaneSlovo(string[] pole) {
            byte krok = 2;
            string[] poSifrovani = new string[pole.Length];

            for (int i = 0; i < pole.Length; i++) {
                string retNoveSlovo = "";
                foreach (char znak in pole[i]) {
                    char novyZnak = (char)(znak + krok);


                    retNoveSlovo += novyZnak;
                }


                poSifrovani[i] = retNoveSlovo;
            }
            return poSifrovani;
        }
    }
}
    
