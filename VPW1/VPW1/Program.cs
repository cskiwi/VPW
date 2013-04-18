using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _10_C0_1___MinMax {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        private static void Main(string[] args) {

            stdout.WriteLine("qsdfqsdf" + (true ^ true ? 1 : 0) + " " + (false ^ false ? 1 : 0));
            // Krijg aantal opgaven
            int aantalOpgaven = int.Parse(stdin.ReadLine());

            // Declareer x aantal vars
            int revo;
            bool[] bol;
            string input;

            // Lees de opgaven
            for (int k = 0; k < aantalOpgaven; k++) {
                input = stdin.ReadLine();
                revo = int.Parse(stdin.ReadLine());

                int len = input.Length;
                bol = new bool[len+2];

                for (int r = 0; r < len; r++) {
                    bol[r+1] = input[r] == '1';
                }

                for (int r = 0; r < revo; r++) {
                    for (int i = len; i > 0; i--) {
                        bol[i+1]= bol[i];
                    }
                    bol[0]=bol[1];
                    bol[len+1]=bol[len];

                    for (int i = 0; i < len; i++) {
                        bol[i] ^= bol[i+2];
                    }
                }
                for (int i = 0; i < len; i++) {
                    stdout.Write(bol[i]?1:0);
                }

                if (k < aantalOpgaven - 1)
                    stdout.WriteLine();
            }

            stdout.Write("");
        }
    }
}