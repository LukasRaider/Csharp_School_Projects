using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'c09)
//'Zadejte z klávesnice celé kladné číslo větší než dvě, program vypíše všechny jeho dělitele, nepočítaje 1 a sebe sama (použij operátor modulo).
//'Pokud žádný není, oznámí, že se jedná o prvočíslo. Pro kontrolu u čísla 12 jsou dělitele čísla: 2, 3, 4, 6. A číslo 13 je prvočíslo.
//'Pozn.: dělitel nějakého čísla, je takové číslo, kterým je možno dělit beze zbytku. Takže trojka je dělitelem čísla 12, protože se do něj vejde přesně čtyřikrát.
//'Zatímco pětka není dělitele čísla 12, protože se tam vejde dvakrát, ale zůstane zbytek 2.
//'Nápověda: Je třeba ve smyčce spočítat počet dělitelů (tedy při každém nalezení dělitele zvýšit toto počitadlo o jedničku).
//'A po smyčce zjistit, zda je počet nulový: v tom případě se jedná o prvočíslo. 
namespace C {
    internal class C09_vypis_delitele_a_prvocisla {
        public static void Mainx(string[] args) {
            int cislo;
            string ret = "";
            bool jePrvocislo = true;

            Console.Write("Zadejte celé kladné číslo větší než dvě, program vypíše všechny jeho dělitele, nepočítaje 1 a sebe sama. \n\nZadej číslo: ");
            cislo = int.Parse(Console.ReadLine());

            for (int i = 2; i < cislo; ++i) {
                if (cislo % i == 0) {
                    ret = ret + i + "\n";
                    jePrvocislo = false;
                }
            }
            if (jePrvocislo == true) {
                Console.WriteLine("Prvočíslo!");
            }
            else {
                Console.WriteLine(ret);
            }
        }
    }
}
