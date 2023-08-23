using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
//'f03)
//'Napište šifrovací funkci, které se předá písmeno a která vrátí následující písmeno v anglické abecedě.
//'Tedy znak, jehož pozice v ASCII tabulce je o jedno vyšší S jedinou výjimkou: pro „z“ vrátí „a“.
//'Poté program zdokonalte tak, aby se funkci předalo i číslo n a funkce pak v ASCII tabulce posouvá o n pozic.
//'Tedy například pro n=2 převede: a->c, y->a, z->b
namespace F1 {
    internal class F1_03_ASCII_sifrovani { //f1_03a_ASCII_sifrovani
        public static void Mainx(string[] args) {
            char znak;
            int vystup;

            Console.Write("Šifrování znaků\n\nZadej písmeno: ");
            znak = char.Parse(Console.ReadLine());

            vratSifraS(znak, out vystup);
            Console.WriteLine("Vráceno Subrutinou: {0} se zašifroval na {1}", znak, (char)vystup);
            Console.WriteLine("Vráceno funkci: {0} se zašifroval na {1}", znak, (char)vratSifraF(znak));
        }

        static void vratSifraS(char x, out int vysledek) {
            int sifra;
            vysledek = 0;

            sifra = Convert.ToChar(x) + 1;
            if (sifra != 91 && sifra != 123) {
                vysledek = sifra;
            }
            else if (sifra == 91) {
                vysledek = 65; //vyjimka Z=A
            }
            else if (sifra == 123) {
                vysledek = 97; //vyjimka z=a
            }
        }
        static int vratSifraF(char x) {
            int sifra;

            sifra = Convert.ToChar(x) + 1;
            if (sifra != 91 && sifra != 123) {
                return sifra;
            }
            else if (sifra == 91) {
                return 65; //vyjimka Z=A
            }
            else if (sifra == 123) {
                return 97; //vyjimka z=a
            }
            else
                return -1;
        }
    }
}