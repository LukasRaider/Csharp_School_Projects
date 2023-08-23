//'    Náročnější
//'10) Program Doc. Homoly: Dvojrozměrné pole: Naplňte zadáním po řádcích pole 4x4.
//'Potom zjistěte minimum a zobrazte řádkové a sloupcové indexy buněk, na kterých se minimum nachází.
using System;

namespace E {
    internal class E10_matice_4x4_minimum {
        public static void Mainx(string[] args) {
            int[,] pole = new int[4, 4];
            int min, radekMin = 0, sloupeMin = 0;
            Random rnd = new Random();

            Console.WriteLine("matice_4x4_minimum");
            for (int r = 0; r < 4; r++) {                   //r jako radek
                for (int s = 0; s < 4; s++) {               //s jako sloupec
                    pole[r, s] = rnd.Next(1, 1000);          //plnim pole nyhodnymi cisly 
                    Console.Write("{0,5}", pole[r, s] + " ");
                }
                Console.WriteLine();
            }
            //for (int r = 0; r < 4; r++) {                   //druha moznost maplnit pole rucne  
            //    for (int s = 0; s < 4; s++) {
            //        Console.Write("Zadej hodnotu" + (r + 1) + ". řádek a " + (s + 1) + ". sloupec");
            //        pole[r, s] = int.Parse(Console.ReadLine());
            //        Console.Write("{0,5}", pole[r,s]+" ");
            //    }
            //    Console.WriteLine();
            //}
            min = pole[0, 0];
            for (int r = 0; r < 4; r++) {                   //r jako radek
                for (int s = 0; s < 4; s++) {               //s jako sloupec
                    if (pole[r, s] < min) {
                        min = pole[r, s];
                        radekMin = r;
                        sloupeMin = s;
                    }
                }
            }
            //Console.WriteLine("\nV " + (radekMin+1) + ". řádku a " + (sloupeMin+1) + ". sloupec je minimální hodnota:" + min+"\n");
            Console.WriteLine("\nV {0}. řádku a {1}. sloupic je minimální hodnota:{2}", sloupeMin + 1, radekMin + 1, min);
        }
    }
}

