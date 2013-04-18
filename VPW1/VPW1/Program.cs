using System;
using System.IO;

namespace Cellulair_Automate {
    internal class Program {
        private static readonly TextReader Stdin = Console.In;
        private static readonly TextWriter Stdout = Console.Out;

        private static void Main(string[] args) {
            Stdout.WriteLine("qsdfqsdf" + (true ^ true ? 1 : 0) + " " + (false ^ false ? 1 : 0));
            // Krijg aantal opgaven
            int aantalOpgaven = int.Parse(Stdin.ReadLine());

            // Declareer x aantal vars
            int revo;
            bool[] bol;
            string input;

            // Lees de opgaven
            for (int k = 0; k < aantalOpgaven; k++) {
                input = Stdin.ReadLine();
                revo = int.Parse(Stdin.ReadLine());

                int len = input.Length;
                bol = new bool[len + 2];

                for (int r = 0; r < len; r++) bol[r + 1] = input[r] == '1';

                for (int r = 0; r < revo; r++) {
                    for (int i = len; i > 0; i--) bol[i + 1] = bol[i];
                    bol[0] = bol[1];
                    bol[len + 1] = bol[len];

                    for (int i = 0; i < len; i++) bol[i] ^= bol[i + 2];
                }
                for (int i = 0; i < len; i++) Stdout.Write(bol[i] ? 1 : 0);

                if (k < aantalOpgaven - 1)
                    Stdout.WriteLine();
            }

            Stdout.Write("");
        }
    }
}