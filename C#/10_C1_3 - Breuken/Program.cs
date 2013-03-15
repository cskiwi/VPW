using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _10_C1_3___Breuken {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        static void Main(string[] args) {
            int aantal = int.Parse(stdin.ReadLine());
            string output = "";

            for (int a = 0; a < aantal; a++) {
                string[] input = stdin.ReadLine().Split(' ');

                List<char> noemer = new List<char>(input[0].ToCharArray());
                List<char> teller = new List<char>(input[1].ToCharArray());

                // gett common letters
                var listCommon = noemer.Intersect(teller).ToArray();

                // filter dubbles
                foreach (char ch in listCommon) {
                    while (noemer.Contains(ch) && teller.Contains(ch)) {
                        noemer.Remove(ch);
                        teller.Remove(ch);
                    }
                }


                // noemer deel
                if (noemer.Count == 0)
                    output += "1";
                else {
                    noemer.Sort();
                    foreach (char c in noemer)
                        output += c;
                }

                // space
                output += ' ';

                // teller deel
                if (teller.Count == 0)
                    output += "1";
                else {
                    teller.Sort();
                    foreach (char c in teller)
                        output += c;
                }
                output += "\n\r";
            }
            stdout.WriteLine(output);
        }
    }
}
