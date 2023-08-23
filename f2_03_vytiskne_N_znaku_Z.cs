using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//'f2_3) Cvičení na subrutinu: Napište subrutinu, která vytiskne řádek obsahující N znaků Z.
//'Údaje N a Z jsou vstupními parametry subrutiny. Pozn.: toto nelze provést jako funkci! Pozn.: použití MsgBox v subrutině či funkci je výjimečné, nepoužívejte tento postup v jiných programech.
namespace F2 {
    internal class F2_03_vytiskne_N_znaku_Z {
        public static void Mainx(string[] args) {
            tisk(5, "c");
        }

        static void tisk(int N, string Z) {
            for (int i = 1; i <= N; i++) {
                Console.Write(Z);
            }
        }
    }
}