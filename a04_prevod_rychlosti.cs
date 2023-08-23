using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//a04)
//Zadejte rychlost v m/s a prevedte na km/hod.
namespace A {
    internal class A04_prevod_rychlosti {
        public static void Mainx(string[] args) {
            float rychlost;
            Console.Write("Zadej rychlost (m/s): ");
            rychlost = float.Parse(Console.ReadLine());
            Console.WriteLine("Rychlost " + rychlost + " m/s se rovná " + rychlost * 3.6 + " Km/hod.");
        }
    }
}

