using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'14) Zadejte a,b,c. Program vypočte kořeny kvadratické rovnice a*x^2 + b*x + c = 0. Pokud si už ze školy nepamatujete, tak
//'hledejte na Wikipedii heslo Diskriminant. Pozn.: na videu 034.MTS od desáté minuty To doc. Homola vysvětluje. Tento
//'program je těžší, můžete jej nechat na později.
//'Teorie: Řešením jsou v závislosti na řešení diskriminantu D buď dvě různá čísla (při kladném D), nebo jeden dvojnásobný
//'kořen (D = 0) nebo dvě komplexně sdružená čísla (při D&lt;0). D=b 2 -4ac.
//'Tedy pro D=0 bude řešením zdvojený kořen -b/2a
//'Otestujte na následujících vzorových datech:
//'Dvě reálná řešení budou pro (x-1)(x-2)=X 2 -3x+2, tedy parametry budou 1, -3, 2
//'Zdvojený kořen bude pro (x-2)(x-2)=X 2 -4x+4, tedy parametry budou 1, -4, 4
//'A komplexně sdružený kořen bude pro x 2 +2x+3, tedy parametry 1, 2, 3, řešení pak bude
//'Pokud někdo výše uvedenému nerozumí (ani s pomocí výše uvedeného videa), tak program přeskočte. V kurzu nehraje
//'matematika hlavní roli.
namespace B {
    internal class B14_Diskriminant_doc_Homola {
        public static void Mainx(string[] args) {
            double cislo1, cislo2, cislo3;
            object[] pole = new object[3];
            Console.WriteLine("Kvadratické rovnice a*x^2 + b*x + c = 0");
            Console.Write("Zadej a: ");
            cislo1 = double.Parse(Console.ReadLine());
            Console.Write("Zadej b: ");
            cislo2 = double.Parse(Console.ReadLine());
            Console.Write("Zadej c: ");
            cislo3 = double.Parse(Console.ReadLine());
            pole = (object[])Kvadr(cislo1, cislo2, cislo3);
            Console.WriteLine("Koreny kvadraticke rovnice jsou:\n" + pole[0] + "\n" + pole[1] + "\n" + pole[2]);
        }
        static object Kvadr(double a, double b, double c) {
            object[] V = new object[3];
            double D, Z1, Z2;
            D = b * b - 4 * a * c;
            Z1 = -b / (2 * a);
            Z2 = System.Math.Sign(System.Math.Abs(D)) / (2 * a);
            if (System.Math.Abs(D) < 1.0E-19) {
                V[0] = Z1;
                V[1] = Z1;
                V[2] = "Dvojnásobný";
            }
            else if (D > 0) {
                V[0] = Z1 + Z2;
                V[1] = Z1 - Z2;
                V[2] = "Realné číslo";
            }
            else {
                V[0] = Z1;
                V[1] = Z2;
                V[2] = "Komplexní";
            }
            return V;
        }
    }
}






