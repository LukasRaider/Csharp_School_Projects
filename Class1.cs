using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Class1
    {
        static void Mainx(string[] args)        {
                const int maxPrvku = 100;
                int[] data = new int[maxPrvku];
                int cislo, i = 0, delitel=0;

                do
                {
                    Console.Write("Zadej číslo. Nula ukončuje: ");
                    cislo = int.Parse(Console.ReadLine());
                    if (cislo != 0)
                    {
                        data[i] = cislo;
                        i++;
                    }
            } while ((cislo != 0) );
            Array.Resize(ref data, i); //pole se timto zmensi pouze na pole s hodnotami

            Console.Write("Zadej delitele: ");
            delitel = int.Parse(Console.ReadLine());

            Console.WriteLine("Vypis cisel delitelnych {0}",delitel);
            for (int j = 0;j < data.Length;j++)
            {
                if (data[j] % delitel == 0) {
                    Console.WriteLine(data[j]+" ");
                } 
            }
            {
            }
            }
        }
}
