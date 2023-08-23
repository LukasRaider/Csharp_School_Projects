using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace D_ {
    internal class D10_sekce_C {
        //d10_sekce_c
        //    '''c01)Varianta WHILE - c01_vypis_kroky_sinus - odloženo
        //       public  static void Main(string[] args) {
        //        }
        //    }
        //}



        //    '''c02)Varianta WHILE - c02_nahodna_v_intervalu
        //      public  static void Main(string[] args) {
        //            int cislo, i = 0, pocetVIntervalu = 0;
        //            Random rnd = new Random();

        //            Console.WriteLine("Vypis vygenerovaných nahodnych čísel: ");
        //            do {
        //                cislo = rnd.Next(-90, 101);
        //                Console.WriteLine(cislo + " ");
        //                if (cislo >= 10 && cislo >= 50) {
        //                    pocetVIntervalu++;
        //                }
        //                i++;
        //            } while (i < 10);
        //            Console.WriteLine("Z 10 vygenerovaných čísel <-90 do 100> se v intervalu <10 do 50> nachází: {0} ", pocetVIntervalu);
        //        }
        //    }
        //}



        //        //    '''c03)Varianta WHILE - c03_Sportka
        //       public  static void Main(string[] args) {
        //            int i = 0;
        //            Random rnd = new Random();

        //            Console.WriteLine("Sportka - Pět náhodných čísel (1-49): ");
        //            while (i < 5) {
        //                Console.WriteLine(rnd.Next(1,50));
        //                i++;
        //            }
        //        }
        //    }
        //}



        //        //    '''c04)Varianta WHILE - klesajici_posloupnost -8 do 8
        //       public  static void Main(string[] args) {
        //            int i = 8;

        //            do {
        //                Console.WriteLine(i);
        //                i -= 1;     //pro vypis pouze sudých stačí zmenit 1 za 2
        //            } while (i>= -8);
        //        }
        //    }
        //}



        //        //    '''c05)Varianta While - Vygenerujte 20 celých náhodných celých čísel v rozsahu <10..50>.
        //      public   static void Main(string[] args) {
        //            int i = 0, suma = 0, cislo;
        //            Random rnd = new Random();

        //            Console.WriteLine("20 náhodných čísel v rozsahu <10..50>: ");
        //            do {
        //                cislo = rnd.Next(10, 51);
        //                Console.WriteLine("{0}.\t{1}", i + 1, cislo);
        //                suma += cislo;
        //                i++;
        //            } while (i < 20);
        //            Console.WriteLine("\nSoučet: {0}\nPrůměr čísel se liší od středu intervalu o: {1}", suma, (double)suma / 20 - 30);
        //        }
        //    }
        //}



        //        //    '''c06)Varianta WHILE - trid_ve_skole
        //      public   static void Main(string[] args) {
        //            int i = 0, pocetTrid, suma = 0, pocetZaku;

        //            Console.Write("Zadej počet tříd ve škole: ");
        //            pocetTrid = int.Parse(Console.ReadLine());

        //            while (i < pocetTrid) {
        //                i++;
        //                Console.Write("Zadej počet žáků {0}. třídy: ", i);
        //                pocetZaku = int.Parse(Console.ReadLine());
        //                suma += pocetZaku;
        //            }
        //            Console.WriteLine("Do školy chodí celkem {0} žákù.\nVe třídách je průměrně {1} žáků.", suma, suma / pocetTrid);
        //        }
        //    }
        //}



        //        //    '''c07)Varianta WHILE - kurz_Kc_k_Euru
        //      public   static void Main(string[] args) {
        //            double kurz;
        //            int i=1;
        //            Random rnd = new Random();

        //            Console.WriteLine("Minutu po minutě kurz Kč k Euru prvních dvacet minut, po opuštění kurzového závazku ČNB.");
        //            do {
        //                kurz = Math.Round(rnd.NextDouble() * (28 - 26) + 26, 2);
        //                if (i % 5 == 0) {
        //                    Console.WriteLine(kurz);
        //                }
        //                else {
        //                    Console.Write(kurz+ "\t");
        //                }
        //                i++;
        //            } while (i<=20);
        //        }
        //    }
        //}



        //        //    '''c07b)Varianta WHILE - odradkovany_vypis
        //      public   static void Main(string[] args) {
        //            int i = 0;

        //            while (i < 20) {
        //                i++;
        //                if (i % 5 == 0) {
        //                    Console.WriteLine("{0,3}", i);
        //                }
        //                else {
        //                    Console.Write("{0,3}", i + " ");
        //                }
        //            }
        //        }
        //    }
        //}



        //        //    '''c08)Varianta WHILE - soucet_celych_cisel
        //      public   static void Main(string[] args) {
        //            int maxCislo, suma = 0, i=0;

        //            Console.Write("Program vypíše součet celých čísel od jedné do udaného čísla.\n\nZadej celé kladné číslo: ");
        //            maxCislo = int.Parse(Console.ReadLine());
        //            do {
        //                suma += i;
        //                i++;
        //            } while (i<=maxCislo);
        //            Console.WriteLine("Soucet cisel: " + suma);
        //        }
        //    }
        //}



        //        //    '''c09)Varianta WHILE - vypis_delitele_a_prvocisla
        //      public   static void Main(string[] args) {
        //            int cislo, i = 2;
        //            string ret = "";
        //            bool jePrvocislo = true;

        //            Console.WriteLine("Zadejte celé kladné číslo větší než dvě.\nProgram vypíše všechny jeho dělitele, \n(nepočítaje 1 a sebe sama)\n\n");

        //            Console.Write("Zadejte celé kladné číslo větší než dvě: ");
        //            cislo = int.Parse(Console.ReadLine());

        //            while (i < cislo) {
        //                if (cislo % i == 0) {
        //                    ret = ret + i + "\n";
        //                    jePrvocislo = false;
        //                }
        //                i++;
        //            }
        //            if (jePrvocislo == true) {
        //                Console.WriteLine("Prvočíslo!");
        //            }
        //            else {
        //                Console.WriteLine("Výpis dělitelů: \n" + ret);
        //            }

        //        }
        //    }
        //}



        //        //    '''c10)Varianta WHILE - mala_nasobilka
        //       public  static void Main(string[] args) {
        //            double cinitel1, cinitel2, soucin, tipVysledek;
        //            int pocitadlo = 0, i = 0;
        //            Random rnd = new Random();

        //            Console.WriteLine("Zkouška z malé násobilky");
        //            do {
        //                cinitel1 = (rnd.Next(1, 11));
        //                cinitel2 = (rnd.Next(1, 11));
        //                soucin = cinitel1 * cinitel2;
        //                Console.Write("Zadej výsledek příkladu " + cinitel1 + " x " + cinitel2 + " = ");
        //                tipVysledek = int.Parse(Console.ReadLine());
        //                if (soucin == tipVysledek) {
        //                    Console.WriteLine("Správná odpověď.");
        //                }
        //                else {
        //                    Console.WriteLine(tipVysledek + " je chyba, správný výsledek " + cinitel1 + " x " + cinitel2 + " = " + soucin);
        //                    pocitadlo++;
        //                }
        //                i++;
        //            } while (i < 10);
        //            Console.WriteLine("Počet chyb " + pocitadlo + " z 10 příkladů.");
        //        }
        //    }
        //}



        //    '''c11)Varianta WHILE + varianta FOR
        //        public static void Main(string[] args) {
        //            int i = 65;
        //            Console.WriteLine("Tabulka ASCII [65-100]\nASCII\tZNAK");

        //            while (i <= 100) {
        //                Console.WriteLine(i + "\t" + Convert.ToChar(i));
        //                i++;
        //            }
        //        }
    }
}



