using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
////    Náročnější
////15) Uživatel zadá několik slov (bez diakritiky). Program zapíše tento text v Morseově abecedě. Oddělovačem znaků bude lomítko.
////Zadat všechna slova do jednoho inputboxu, oddělená normálně mezerami. A mezera se překládá taky jako lomítko.
////Tedy na hranicích slov budou vlastně dvě lomítka.- (Nutná znalost Morseovy abecedy).

////15b) Zdokonalení programu: text bude v souboru, Morseovka se zapíše Do jiného souboru.
////Další program bude naopak načíst Morseovku a převádět na běžný text.
////(Práce se soubory - pokročilejší látka, bere se až v prezenčním kurzu.Tedy v přípravném kurzu nevypracovávat.)
namespace E {
    internal class E15_Morseova_abeceda {
        public static void Mainx(string[] args) {

            string[] poleMoresovka = new string[123];
            string retSlova, novyZnak;
            char znak;


            poleMoresovka[32] = "/";        //mezera
            poleMoresovka[48] = "–––––/";   //0
            poleMoresovka[49] = ".––––/";   //1
            poleMoresovka[50] = "..–––/";   //2
            poleMoresovka[51] = "...––/";   //3
            poleMoresovka[52] = "....–/";   //4
            poleMoresovka[53] = "...../";   //5
            poleMoresovka[54] = "–..../";   //6
            poleMoresovka[55] = "––.../";   //7
            poleMoresovka[56] = "–––../";   //8 
            poleMoresovka[57] = "––––./";   //9
            poleMoresovka[65] = ".–/";      //A
            poleMoresovka[66] = "–.../";    //B
            poleMoresovka[67] = "–.–./";    //C
            poleMoresovka[68] = "–../";     //D
            poleMoresovka[69] = "./";       //E
            poleMoresovka[70] = "..–./";    //F
            poleMoresovka[71] = "––./";     //G
            poleMoresovka[72] = "..../";    //H
            poleMoresovka[73] = "../";      //I
            poleMoresovka[74] = ".–––/";    //J
            poleMoresovka[75] = "–.–/";     //K
            poleMoresovka[76] = ".–../";    //L
            poleMoresovka[77] = "––/";      //M
            poleMoresovka[78] = "–./";      //N
            poleMoresovka[79] = "–––/";     //O
            poleMoresovka[80] = ".––./";    //P
            poleMoresovka[81] = "––.–/";    //Q
            poleMoresovka[82] = ".–./";     //R
            poleMoresovka[83] = ".../";     //S
            poleMoresovka[84] = "–/";       //T
            poleMoresovka[85] = "..–/";     //U
            poleMoresovka[86] = "...–/";    //V
            poleMoresovka[87] = ".––/";     //W
            poleMoresovka[88] = "–..–/";    //X
            poleMoresovka[89] = "–.––/";    //Y
            poleMoresovka[90] = "––../";    //Z
            poleMoresovka[97] = ".–/";      //a
            poleMoresovka[98] = "–.../";    //b
            poleMoresovka[99] = "–.–./";    //c
            poleMoresovka[100] = "–../";    //d
            poleMoresovka[101] = "./";      //e
            poleMoresovka[102] = "..–./";   //f
            poleMoresovka[103] = "––./";    //g
            poleMoresovka[104] = "..../";   //h
            poleMoresovka[105] = "../";     //i
            poleMoresovka[106] = ".–––/";   //j
            poleMoresovka[107] = "–.–/";    //k
            poleMoresovka[108] = ".–../";   //l
            poleMoresovka[109] = "––/";     //m
            poleMoresovka[110] = "–./";     //n
            poleMoresovka[111] = "–––/";    //o
            poleMoresovka[112] = ".––./";   //p
            poleMoresovka[113] = "––.–/";   //q
            poleMoresovka[114] = ".–./";    //r
            poleMoresovka[115] = ".../";    //s
            poleMoresovka[116] = "–/";      //t
            poleMoresovka[117] = "..–/";    //u
            poleMoresovka[118] = "...–/";   //v
            poleMoresovka[119] = ".––/";    //w
            poleMoresovka[120] = "–..–/";   //x
            poleMoresovka[121] = "–.––/";   //y
            poleMoresovka[122] = "––../";   //z

            Console.WriteLine("Morseova abeceda - převodník\nZadejte několik slov (bez diakritiky), oddělená mezerami");
            retSlova = Console.ReadLine();
            retSlova = " " + retSlova;

            for (int i = 0; i < retSlova.Length; i++) {
                znak = retSlova[i];
                novyZnak = poleMoresovka[znak];
                Console.Write(novyZnak);
            }
            Console.WriteLine();
        }
    }
}