using System.IO;
using System.Linq;

namespace _10_C1_4___ptaal {
    class program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        static void Main(string[] args) {
            int aantal = int.Parse(stdin.ReadLine());
            string output = "";

            char[] specials = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < aantal; i++) {
                string input = stdin.ReadLine();
                for (int ch = 0; ch < input.Length; ch++) {
                    int loc = 0;
                    if (input[ch] == 'i' && input[ch + 1] == 'j') {
                        output += "ij";
                        ch+= 4;
                    } else if (specials.Contains(input[ch])) {
                        loc = input.IndexOf('p', ch);
                        output += input.Substring(ch, loc - ch);
                        ch = loc + loc - ch; ;
                    } else
                        output += input[ch];
                }
                output += "\n";

            }
            stdout.WriteLine(output);
        }
    }
}
