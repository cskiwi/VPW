using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _10_C0_1___MinMax {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        private static void Main(string[] args) {

            // Krijg aantal opgaven
            int aantalOpgaven = int.Parse(stdin.ReadLine());

            // Declareer x aantal vars
            int pStart;
            int pLen;
            int posters = aantalOpgaven;
            int[] panel = new int[10000];

            // Lees de opgaven
            for (int k = 0; k < aantalOpgaven; k++) {

                posters =  int.Parse(stdin.ReadLine());
                panel = new int[10000];
                for (int r = 0; r < posters; r++) {
                    string[] temp = stdin.ReadLine().Split(' ');
                    pStart = int.Parse(temp[0]);
                    pLen = int.Parse(temp[1]);
                    for (int p = pStart; p < pLen + pStart; p++) {
                        panel[p] = r + 1;
                    }
                }
                stdout.Write(panel.Distinct().ToList().Count-1);



                if (k < aantalOpgaven - 1)
                    stdout.WriteLine();

            }
        }
    }
}