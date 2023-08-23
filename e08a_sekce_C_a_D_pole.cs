using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//    'A předělejte příklady c) a d) na pole. Tedy nezpracovávejte je v první smyčce, ale až v druhé.

namespace E {
    internal class E08a_sekce_C_a_D_pole { 



        //    'c01)Varianta POLE - vypis Sin odloženo



        //        //    'c02)Varianta POLE - nahodna_v_intervalu
        //        static void Main(string[] arsg) {
        //            int[] poleCisel = new int[10];
        //            byte pocetCiselVIntervalu = 0;
        //            Random r = new Random();

        //            for (int i = 0; i < poleCisel.Length; i += 1) {
        //                poleCisel[i] = r.Next(-90, 101);
        //            }
        //            for (int i = 0; i < poleCisel.Length; i += 1) {
        //                if (poleCisel[i] >= 10 && poleCisel[i] <= 50) {
        //                    pocetCiselVIntervalu++;
        //                }
        //            }
        //            Console.WriteLine("Z 10 vygenerovaných císel (od -90 do 100) se jich v intervalu (od 10 do 50) nachází: " + pocetCiselVIntervalu);
        //        }
        //    }
        //}



        ////    '    'c03)Varianta pole - Sportka, cisla se mohou opakovat
        //        static void Main(string[] args) {
        //            int[] poleCisel = new int[5];
        //            byte pocetCiselVIntervalu = 0;
        //            Random r = new Random();

        //            for (int i = 0; i < 5; i++) {
        //                poleCisel[i] = r.Next(1,50);
        //            }
        //            Console.WriteLine("Sportka - Pět náhodných čísel (1-49): ");
        //            foreach (var item in poleCisel)
        //            {
        //                Console.WriteLine(item);
        //            }
        //        }
        //    }
        //}




        //        //    'c04)Varianta POLE - klesajici_posloupnost
        //        static void Main(string[] args) {
        //            const int maxPrvku = 17;
        //            int[] pole = new int[maxPrvku];
        //            int j = 0;

        //            for (int i = 8; i >= -8; i-=1) {   
        //                pole[j] = i;
        //                j++;
        //            }
        //            foreach (var item in pole)
        //            {
        //                Console.WriteLine(item);
        //            }
        //        }
        //    }
        //}



        //        //    'c05)'Varianta POLE - nahodna_cisla
        //        static void Main(string[] args) {
        //            const int maxPrvku = 20;
        //            int[] pole = new int[maxPrvku];
        //            Random rnd = new Random();
        //            int suma = 0;

        //            Console.WriteLine("20 celých náhodných celých čísel v rozsahu <10..50>");
        //            for (int i = 0; i < maxPrvku; i++) {
        //                pole[i] = rnd.Next(10, 51);
        //                Console.WriteLine(pole[i]);
        //            }
        //            foreach (var item in pole) {
        //                suma += item;
        //            }
        //            Console.WriteLine("Průměr čísel se liší od středu intervalu o: " + Math.Round((double)suma / 20 - 30, 2));
        //        }
        //    }
        //}



        //        //    'c06)Varianta POLE - trid_ve_skole
        //        static void Main(string[] args) {
        //            const int maxPrvku = 100;
        //            int[] pole = new int[maxPrvku];
        //            int pocetTrid, suma = 0;

        //            Console.Write("Zadej počet tříd ve škole.(max 100)");
        //            pocetTrid = int.Parse(Console.ReadLine());
        //            for (int i = 0; i < pocetTrid; i++) {
        //                Console.Write("Zadej počet žáků " + (i + 1) + ". třídy: ");
        //                pole[i] = int.Parse(Console.ReadLine());
        //            }
        //            for (int i = 0; i <= pocetTrid; i++) {
        //                suma += pole[i];
        //            }
        //            Console.WriteLine("Do školy chodí celkem " + suma + " žáků.\nVe třídách je průměrně " + (suma / pocetTrid) + " žáků.");
        //        }
        //    }
        //}



        //        //    c07)Varianta POLE - kurz_Kc_k_Euru
        //        static void Main(string[] args) {
        //            const int maxPrvku = 21;
        //            double[] pole = new double[maxPrvku];
        //            Random rnd = new Random();

        //            Console.WriteLine("Minutu po minutě kurz Kč k Euru prvních dvacet minut, po opuštění kurzového závazku ČNB.");
        //            for (int i = 1; i <= 20; i++) {
        //                pole[i] = Math.Round(rnd.NextDouble() * (28 - 26) + 26, 2);
        //                if (i % 5 == 0) {
        //                    Console.Write((pole[i]) + "\n");
        //                }
        //                else {
        //                    Console.Write(pole[i] + "\t");
        //                }
        //            }
        //        }
        //    }
        //}



        //        //    c07b)Varianta POLE - odradkovany_vypis
        //        static void Main(string[] args) {
        //            const int maxPrvku = 22;
        //            double[] pole = new double[maxPrvku];

        //            for (int i = 1; i <= 21; i++) {
        //                pole[i] = i;
        //            }
        //            for (int i = 1; i < 21; i++) {
        //                if (i % 5 == 0) {
        //                    Console.Write("{0,4}",pole[i] + "\n");
        //                }
        //                else {
        //                    Console.Write("{0,4}",pole[i] + " ");
        //                }
        //            }
        //        }
        //    }
        //}



        //        //    'c08)'Varianta POLE - soucet_celych_cisel
        //        static void Main(string[] args) {
        //            const int maxPrvku = 100;
        //            int[] pole = new int[maxPrvku];
        //            int cislo, suma = 0;

        //            Console.Write("Zadej celé kladné číslo.(max {0}): ", maxPrvku - 1);
        //            cislo = int.Parse(Console.ReadLine());

        //            for (int i = 0; i <= cislo; i++) {
        //                pole[i] = i;
        //            }
        //            for (int i = 0; i <= cislo; i++) {
        //                suma += pole[i];
        //            }
        //            Console.WriteLine("Součet všech celých čísel (od 1 do {0}) je {1}", cislo, suma);
        //        }
        //    }
        //}



        //    'c09)
        //    'prevod tohoto programu na POLE mi nedava logiku



        //    'c10)Varianta POLE - vypis_delitele_a_prvocisla
        //        static void Main(string[] args) {
        //            const int maxPrvku = 100;
        //            int[] pole = new int[maxPrvku];
        //            int cislo, pocet = 0;
        //            bool jePrvocislo = true;

        //            Console.Write("Zadejte celé kladné číslo větší než dvě(max{0}), program vypíše všechny jeho dělitele, nepočítaje 1 a sebe sama. \n\nZadej číslo: ", maxPrvku - 1);
        //            cislo = int.Parse(Console.ReadLine());
        //            for (int i = 2; i < cislo; ++i) {
        //                if (cislo % i == 0) {
        //                    //ret = ret + i + "\n";
        //                    pole[pocet] = i;
        //                    pocet++;
        //                    jePrvocislo = false;
        //                }
        //            }
        //            if (jePrvocislo == true) {
        //                Console.WriteLine("{0} je prvočíslo!", cislo);
        //            }
        //            else {
        //                Console.WriteLine("Výpis: ");
        //                for (int i = 0; i < pocet; i++) {
        //                    Console.WriteLine(pole[i]);
        //                }
        //            }
        //        }
        //    }
        //}



        ////    'c11)Varianta POLE - ASCII
        //static void Main(string[] args) {
        //    const int maxPrvku = 36;
        //    int[] pole = new int[maxPrvku];
        //    int pocet = 0;

        //    Console.WriteLine("Tabulka ASCII [65-100]\nASCII\tZNAK");
        //    for (int i = 65; i <= 100; ++i) {
        //        pole[pocet] = Convert.ToInt32(i);
        //        ++pocet;
        //    }
        //    for (int i = 0; i < pocet; i++) {
        //        Console.WriteLine(pole[i] + "\t" + Convert.ToChar(pole[i]));
        //    }
        //}
        //    }
        //}



        //        //    'd01)Varianta POLE
        //        static void Main(string[] args) {
        //            const int maxPrvku = 100;
        //            int[] poleZaku = new int[maxPrvku];
        //            int i = 0, iMax, celkem = 0;

        //            Console.WriteLine("Zadávejte počety žáků ve třídách. (0=konec)");
        //            do {
        //                Console.Write("Zadej počet žáků {0}. třídy: ", i + 1);
        //                poleZaku[i] = int.Parse(Console.ReadLine());
        //                i++;
        //            } while (poleZaku[i - 1] != 0);
        //            iMax = i - 1;
        //            for (int j = 0; j < iMax; j++) {
        //                celkem += poleZaku[j];
        //            }
        //            if (celkem == 0) {
        //                Console.WriteLine("Do školy nechodí žádný žák");
        //            }
        //            else {
        //                Console.WriteLine("Celkem žáků ve škole: {0}\nPrůměr žáků ve třídách: {1}", celkem, Math.Round((double)(celkem / iMax), 2));
        //            }
        //        }
        //    }
        //}



        //        //    'd02)Varianta POLE
        //        static void Main(string[] args) {
        //            const int maxPrvku = 100;
        //            int[] poleUctenek = new int[maxPrvku];
        //            int uctenka, suma = 0, drahyNakup = 0, i = 0;

        //            Console.WriteLine("//'Máte schované účtenky z různých nákupů, nevíte ale, kolik účtenek je.\n//'Proto částky na účtenkách budete zadávat postupně, jako poslední zadáte nulu.\n");

        //            Console.Write("Zadejte {0} účtenku: ", i + 1);
        //            poleUctenek[i] = int.Parse(Console.ReadLine());
        //            while (poleUctenek[i] != 0) {
        //                i++;
        //                Console.Write("Zadejte {0} účtenku: ", i + 1);
        //                poleUctenek[i] = int.Parse(Console.ReadLine());
        //            }
        //            for (int j = 0; j < i; j++) {
        //                suma += poleUctenek[j];
        //                if (poleUctenek[j] >100) {
        //                    drahyNakup++;
        //                }
        //            }
        //            Console.WriteLine("Utratili jste {0},- Kč\nNákupů nad 100 Kč bylo: {1}", suma,drahyNakup);
        //        }
        //    }
        //}



        //        //    'd03)Varianta POLE
        //        static void Main(string[] args) {
        //            const int maxPrvku = 100;
        //            int[] pole = new int[maxPrvku];
        //            int limit, posloupnost;

        //            Console.Write("Zadejte první, druhy člen a počet kroků celočíselné lineární posloupnosti.\nProgram zobrazí pod sebou všechny prvky posloupnosti.\n\nZadej první člen: ");
        //            pole[0] = int.Parse(Console.ReadLine());
        //            Console.Write("Zadej drůhý člen: ");
        //            pole[1] = int.Parse(Console.ReadLine());
        //            Console.Write("Zadej počet kroků posloupnosti: ");
        //            limit = int.Parse(Console.ReadLine());
        //            Console.WriteLine("\nVypis posloupnosti: ");

        //            if (pole[0] < pole[1]) {
        //                posloupnost = pole[1] - pole[0];
        //                for (int i = 1; i <= limit ; i++) {
        //                    pole[i] = pole[i - 1]+posloupnost;
        //                    Console.WriteLine("{0}.\t{1}", i, pole[i-1]);
        //                }
        //            }
        //            else {
        //                posloupnost = pole[0] - pole[1];
        //                for (int i = 1; i <= limit ; i++) {
        //                    pole[i] = pole[i - 1]-posloupnost;
        //                    Console.WriteLine("{0}.\t{1}", i, pole[i - 1]);
        //                }
        //            }
        //        }
        //    }
        //}



        //        //    'd04)Varianta POLE
        //        static void Main(string[] args) {
        //            const int maxPrvku = 100;
        //            int[] poleVyska = new int[maxPrvku];
        //            string[] poleJmen = new string[maxPrvku];
        //            int maxVyska, i = 0, iMax;
        //            string maxJmeno;
        //            bool asonJenedZak;

        //            Console.WriteLine("Program postupně čte nejprve jméno a pak výšku žáka. Prázdné jméno načítání ukončuje.\r\nPoté zobrazí jméno a výšku nejvyššího žáka.\n");

        //            Console.Write("Zadej jméno žáka: ");
        //            poleJmen[i] = Console.ReadLine();
        //            Console.Write("Zadej výšku žáka [cm]: ");
        //            poleVyska[i] = int.Parse(Console.ReadLine());
        //            maxJmeno = poleJmen[i];
        //            maxVyska = poleVyska[i];
        //            if (poleJmen[i] == "") {
        //                asonJenedZak = false;
        //            }
        //            else {
        //                asonJenedZak = true;
        //            }
        //            while (poleJmen[i] != "") {
        //                i++;
        //                Console.Write("\nZadej jméno žáka: ");
        //                poleJmen[i] = Console.ReadLine();
        //                if (poleJmen[i] != "") {
        //                    Console.Write("Zadej výšku žáka [cm]: ");
        //                    poleVyska[i] = int.Parse(Console.ReadLine());
        //                    if (poleVyska[i] > maxVyska) {
        //                        maxJmeno = poleJmen[i];
        //                        maxVyska = poleVyska[i];
        //                    }
        //                }
        //            }
        //            if (asonJenedZak) {
        //                Console.WriteLine("Nejvyšší je {0} s výškou {1} cm.", maxJmeno, maxVyska);
        //            }
        //            else {
        //                Console.WriteLine("\nNebyl zadán žádný žák!");
        //            }
        //        }
        //    }
        //}





        //        //    'd05)Varianta POLE
        //        static void Main(string[] args) {
        //            double cislo, soucet = 0, max, min, prvni, prumer;
        //            int pocitadlo = 0, pocetSude = 0, pocetVetsich = 0;
        //            const int maxPrvku = 200;
        //            int[] poleSudych = new int[maxPrvku];
        //            double[] poleVetsichNezPrvni = new double[maxPrvku];
        //            double[] poleCisel = new double[maxPrvku];

        //            Console.WriteLine("//'d05)\r\n//'Zadejte několik celých čísel, ukončete nulou (ta již do dat nepatří).\r\n//'Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, minimum, maximum.\r\n//'Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.\r\n//'Případně ještě vypíše ta z nich, která jsou větší, než první číslo.\n\n");

        //            Console.Write("Zadej celé číslo, ukonči 0: ");
        //            cislo = double.Parse(Console.ReadLine());
        //            poleCisel[pocitadlo] = cislo;
        //            prvni = cislo;
        //            min = cislo;
        //            max = cislo;
        //            while (cislo != 0) {
        //                pocitadlo++;
        //                soucet += cislo;
        //                if (cislo > max) {
        //                    max = cislo;
        //                }
        //                if (cislo < min) {
        //                    min = cislo;
        //                }
        //                if (cislo % 2 == 0) {
        //                    poleSudych[pocetSude] = (int)cislo;
        //                    pocetSude++;
        //                }
        //                if (cislo > prvni) {
        //                    poleVetsichNezPrvni[pocetVetsich] = cislo;
        //                    pocetVetsich++;
        //                }
        //                Console.Write("Zadej celé číslo, ukonči 0: ");
        //                cislo = double.Parse(Console.ReadLine());
        //                poleCisel[pocitadlo] = cislo;
        //            }
        //            Console.WriteLine("\nVýpis zadaných čísl: ");
        //            prumer = Math.Round((soucet / (pocitadlo)), 2);
        //            for (int i = 0; i < pocitadlo; i++) {
        //                Console.Write(poleCisel[i] + " ");
        //            }
        //            Console.WriteLine("\nPočet: {0}\nSoučet: {1}\nPrůměr: {2}\nMinimum: {3}\nMaximum: {4}", pocitadlo, soucet, prumer, min, max);
        //            Console.WriteLine("Počet sudých: {0}\nVýpis sudých čísel: ", pocetSude);
        //            for (int i = 0; i < pocetSude; i++) {
        //                Console.Write(poleSudych[i] + " ");
        //            }
        //            Console.WriteLine("\nVýpis větší než první zadané: ");
        //            for (int i = 0; i < pocetVetsich; i++) {
        //                Console.Write(poleVetsichNezPrvni[i] + " ");
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}



        //    'd06)Varianta Pole - převod na pole nedava logiku


        //    'd07)Varianta POLE - převod na pole nedava logiku


        //    'd08)Varianta Pole - převod na pole nedava logiku



        //    'd09)Varianta POLE

        //static void Main(string[] args) {
        //    const int maxPrvku = 100;
        //    double[] poleTeplot = new double[maxPrvku];
        //    double teplota, suma = 0, min, poradiMinima = 0;
        //    int i = 0;

        //    Console.WriteLine("Zadávej postupně teplotu vody (C°) s přesností na desetinu.\nZadávání ukončí zadáním teploty přesahující 100°. Voda vyvařila!\n\n");

        //    Console.Write("Zadejte teplotu: ");
        //    teplota = double.Parse(Console.ReadLine());
        //    poleTeplot[i] = teplota;
        //    min = teplota;
        //    poradiMinima++;
        //    i++;
        //    while (teplota <= 100) {
        //        Console.Write("Zadejte teplotu: ");
        //        teplota = double.Parse(Console.ReadLine());
        //        poleTeplot[i] = teplota;
        //        i++;
        //    }
        //    Console.WriteLine("Výpis teplot: ");
        //    for (int j = 0; j < i; j++) {
        //        Console.Write(poleTeplot[j] + "°C ");
        //        suma += poleTeplot[j];
        //        if (poleTeplot[j] < min) {
        //            min = poleTeplot[j];
        //            poradiMinima++;
        //        }
        //    }
        //    Console.WriteLine("\nMinimalni teplota: {0}°C\nPořadí zadání minimální teploty: {1}\nPrůměrá teplota: {2}°C", min, poradiMinima, Math.Round((suma / i), 2));
        //}
    }
}




//    'd10)   Hotovo, programy jsou v tomto modulu výše