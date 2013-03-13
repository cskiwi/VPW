using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VoorbeeldOpgave {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        static void Main(string[] args) {
            int aantal = int.Parse(stdin.ReadLine());
            for (int i = 0; i < aantal; i++) {
                string[] lijn = stdin.ReadLine().Split(' ');
                int k = int.Parse(lijn[0]);
                stdout.WriteLine(lijn[1].Substring(k - 1, 1));
            }
        }
    }
}
