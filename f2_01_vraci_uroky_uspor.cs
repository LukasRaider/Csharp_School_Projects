using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//'1) Zadejte ve smyčce do pole úspory několika osob. Poté se program zeptá, jaká je roční úroková míra.
//    'Pole předejte funkci, která vrátí pole po započítání úroků.
//    'Původní pole nesmí být voláním funkce ovlivněno (To platí i pro všechny další příklady).
namespace F2 {
    internal class F2_01_vraci_uroky_uspor {
        public static void Mainx(string[] args) {
            float[] poleUspor = new float[1], poleNoveUsporyS, poleNoveUsporyF;
            byte i = 0;
            string ret = "", retNoveUsporyS = "", retNoveUsporyF = "";
            float urokovaSazba;

            Console.WriteLine("Zadejte ve smyčce do pole úspory několika osob. Poté se program zeptá, jaká je roční úroková míra.\n\n");

            Console.Write("Zadejávej výše úspor (0=konec): ");
            poleUspor[0] = float.Parse(Console.ReadLine());
            ret += poleUspor[0] + " ";

            while (poleUspor[i] != 0) {
                i++;
                Array.Resize(ref poleUspor, i + 1);
                Console.Write("Zadejávej výše úspor (0=konec): ");
                poleUspor[i] = float.Parse(Console.ReadLine());
                if (poleUspor[i] != 0) {
                    ret += poleUspor[i] + " ";
                }
            }
            Array.Resize(ref poleUspor, i);

            Console.Write("Zadej roční úrokovou míru: ");
            urokovaSazba = float.Parse(Console.ReadLine());

            Console.WriteLine("Výpis úspor před úročením:\n" + ret);
            Console.WriteLine("Úspory po úročení (roční úroková míra " + urokovaSazba + "%):");

            poleNoveUsporyF = vratUrokyF(poleUspor, urokovaSazba);
            for (int j = 0; j < poleNoveUsporyF.Length; j++) {
                retNoveUsporyF += poleNoveUsporyF[j] + " ";
            }
            Console.WriteLine("Funkce: " + retNoveUsporyF);

            vratUrokyS(poleUspor, urokovaSazba, out poleNoveUsporyS);
            for (int j = 0; j < poleNoveUsporyS.Length; j++) {
                retNoveUsporyS += poleNoveUsporyS[j] + " ";
            }
            Console.WriteLine("Subrutina: " + retNoveUsporyS);
        }


        static float[] vratUrokyF(float[] pole, float procenta) {
            float[] novePole = new float[pole.Length];
            byte i;

            for (i = 0; i < pole.Length; i++) {
                novePole[i] = pole[i] + (pole[i] * procenta / 100);
            }
            return novePole;
        }

        static void vratUrokyS(float[] pole, float procenta, out float[] vysledek) {
            float[] novePole = new float[pole.Length];
            byte i;

            for (i = 0; i < pole.Length; i++) {
                novePole[i] = pole[i] + (pole[i] * procenta / 100);
            }
            vysledek = novePole;
        }
    }
}

