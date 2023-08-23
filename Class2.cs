using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Class2
    {
        static void Main(string[] args)
        {
            int[] pole = new int[1];
            int i = 0, soucetS = 0;

            Console.Write("Zadejávej cisla (0=konec): ");
            pole[0] = int.Parse(Console.ReadLine());
            while (pole[i] != 0)
            {
                i++;
                Array.Resize(ref pole, i + 1);
                Console.Write("Zadejávej cisla (0=konec): ");
                pole[i] = int.Parse(Console.ReadLine());
            }
            Array.Resize(ref pole, i);

            Console.WriteLine("soucet vraceny funkci {0}", vratSoucetF(pole));
            vratSoucetS(pole, out soucetS);
            {
                Console.WriteLine("soucet vraceny subrutinou {0}", soucetS);
            }
        }
        static int vratSoucetF(int[] x)
        {
            int soucet = 0;
            for (int i = 0; i < x.Length; i++)
                soucet += x[i];
            {
                return soucet;
            }
        }
        static void vratSoucetS(int[] x, out int vysledek)
        {
            int soucet = 0;
            for (int i = 0; i < x.Length; i++)
                soucet += x[i];
            {
                vysledek = soucet;
            }
        }
    }
}
