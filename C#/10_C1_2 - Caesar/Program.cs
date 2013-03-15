using System;
using System.IO;
using System.Linq;

namespace _10_C1_2___Caesar {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        static void Main(string[] args) {
            int aantal = int.Parse(stdin.ReadLine());
            string[] output = new string[aantal];

            char[] ASCII = { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < aantal; i++) {
                string[] input = stdin.ReadLine().Split(new char[] { ' ' }, 2);
                int C = int.Parse(input[0]);
                char[] charInput = input[1].ToCharArray();
                output[i] = "";
                for (int ch = 0; ch < charInput.Length; ch++) {
                    if (ASCII.Contains(charInput[ch])) {
                        int itemIndex = Convert.ToInt16(charInput[ch]) - 64;
                        if (itemIndex < 0)
                            itemIndex = 0;
                        itemIndex -= C;
                        if (itemIndex < 0)
                            itemIndex += 27;

                        output[i] += ASCII[itemIndex];
                    } else {
                        output[i] += charInput[ch];
                    }
                } 
            }
            for (int ou = 0; ou < output.Length; ou++) {
                stdout.WriteLine(output[ou]);
            }
            stdin.Read();
        }
    }
}