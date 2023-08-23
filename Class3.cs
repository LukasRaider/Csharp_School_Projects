using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Class3
    {
        static void Mainx(string[] args)
        {
            const int maxPrvku = 100;
            int[] data = new int[maxPrvku];
            int cislo, i = 0, delitel = 0, pocetnah;
            string ret="";
            Random rnd = new Random ();

            Console.Write("zadej kolik chces vygenerovat cisel: ");
            pocetnah = int.Parse(Console.ReadLine());

            for (int j = 0; j < pocetnah; j++)
            {
                data[j] = rnd.Next(1, 100);
                ret += data[j];
                i++;
            }
            Array.Resize(ref data, i); //pole se timto zmensi pouze na pole s hodnotami
            foreach (var item in data)
            {
                Console.WriteLine(item+" ");
            }
            //do
            //{
            //    Console.Write("Zadej číslo. Nula ukončuje: ");
            //    cislo = int.Parse(Console.ReadLine());
            //    if (cislo != 0)
            //    {
            //        if (i >= maxPrvku)
            //        {
            //            Console.WriteLine("Pole je plne.");
            //            break;
            //        }
            //        data[i] = cislo;
            //        i++;
            //    }
            //} while (cislo != 0);
            Array.Resize(ref data, i); //pole se timto zmensi pouze na pole s hodnotami

            Console.Write("Zadej delitele: ");
            delitel = int.Parse(Console.ReadLine());

            Console.WriteLine("Vypis cisel delitelnych {0}", delitel);
            for (int j = 0; j < data.Length; j++)
            {
                if (data[j] % delitel == 0)
                {
                    Console.WriteLine(data[j] + " ");
                }

            }
            {

            }

        }
    }
}

