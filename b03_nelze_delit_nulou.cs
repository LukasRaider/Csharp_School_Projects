using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'b03)
//'Úkolem je pro danou dvojici císel x,y spocítat hodnotu výrazu 1/(x*y). Pokud by ale byl jmenovatel nulový, tak nepocítat
//'(aby nedošlo k havárii programu), ale vypsat varovné hlášení.
namespace B {
    internal class B03_nelze_delit_nulou {
        public static void Mainx(string[] args) {
            double X, Y;
            Console.Write("Pro vyraz 1/(x*y), zadej hodnotu X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Pro vyraz 1/(x*y), zadej hodnotu Y: ");
            Y = double.Parse(Console.ReadLine());
            if (X * Y == 0) {
                Console.WriteLine("Nelze delit, jmenovatel(x*y)=0");
            }
            else {
                Console.WriteLine("Vyraz  1/(x*y)  je roven " + ((double)1 / (X * Y)));
            }
        }
    }
}