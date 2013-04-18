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
            int gewichten,target;
            List<int> waardes,test;

            // Lees de opgaven
            for (int k = 0; k < aantalOpgaven; k++) {

                bool found = false;
                gewichten = int.Parse(stdin.ReadLine());
                waardes = new List<int>();
                test = new List<int>();

                string[] temp=stdin.ReadLine().Split(' ');
                for (int r = 0; r < gewichten; r++) {
                    waardes.Add(int.Parse(temp[r]));
                    test.Add(int.Parse(temp[r]));
                }
                target = int.Parse(stdin.ReadLine());


                for (int g = 0; g < gewichten && !found; g++) {

                    for (int h = g; h < gewichten; h++) {
                        if (waardes[g] + waardes[h] == target && g != h) found = true;
                    }
                }

                stdout.Write(target+" "+(found?"JA":"NEEN"));



                if (k < aantalOpgaven - 1)
                    stdout.WriteLine();

            }
        }
    }
}