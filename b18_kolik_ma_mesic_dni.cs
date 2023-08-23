using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//'    Select Case
//'18) Zadejte číslo měsíce (1 až 12). Program vypíše, kolik má měsíc dní (únor má zjednodušeně 28 dní). Proveďte pomocí if i Case .
namespace B {
    internal class B18_kolik_ma_mesic_dni {
        public static void Mainx(string[] args) {
            byte cisloMesice;
            string pocetDni;
            Console.Write("Kolik má měsíc dní\nZadejte číslo měsíce (1 až 12): ");
            cisloMesice = byte.Parse(Console.ReadLine());
            Console.WriteLine("Vráceno pomocí switch: " + VratDnyMesice_SelectCase(cisloMesice));
            Console.WriteLine("Vráceno pomocí if: " + VratDnyMesice_if(cisloMesice));
        }
        public static string VratDnyMesice_SelectCase(byte cislo) {
            switch (cislo) {
                case 1: return "Leden ma 31 dnu"; break;
                case 2: return "Unor ma 28 dnu"; break;
                case 3: return "Brezen ma 31 dnu"; break;
                case 4: return "Duben ma 30 dnu"; break;
                case 5: return "Kveten ma 31 dnu"; break;
                case 6: return "Cerven ma 30 dnu"; break;
                case 7: return "Cervenec ma 31 dnu"; break;
                case 8: return "Srpen ma 31 dnu"; break;
                case 9: return "Zari ma 30 dnu"; break;
                case 10: return "Rijen ma 31 dnu"; break;
                case 11: return "Listopad ma 30 dnu"; break;
                case 12: return "Prosinec ma 31 dnu"; break;
                default: return "Byla zadána špatná hodnota";
            }
        }
        public static string VratDnyMesice_if(byte cislo) {
            if (cislo == 1) return "Leden ma 31 dnu";
            else if (cislo == 2) return "Unor ma 28 dnu";
            else if (cislo == 3) return "Brezen ma 31 dnu";
            else if (cislo == 4) return "Duben ma 30 dnu";
            else if (cislo == 5) return "Kveten ma 31 dnu";
            else if (cislo == 6) return "Cerven ma 30 dnu";
            else if (cislo == 7) return "Cervenec ma 31 dnu";
            else if (cislo == 8) return "Srpen ma 31 dnu";
            else if (cislo == 9) return "Zari ma 30 dnu";
            else if (cislo == 10) return "Rijen ma 31 dnu";
            else if (cislo == 11) return "Listopad ma 30 dnu";
            else if (cislo == 12) return "Prosinec ma 31 dnu";
            else return "Byla zadána špatná hodnota";
        }
    }
}

