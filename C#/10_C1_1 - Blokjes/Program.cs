using System.IO;

namespace _10_C1_1___Blokjes {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        static void Main(string[] args) {

            int aantalTorens = int.Parse(stdin.ReadLine());
            int[] totaalBlokken = new int[aantalTorens];


            for (int i = 0; i < aantalTorens; i++) {
                int aantalBlokken = int.Parse(stdin.ReadLine());
                totaalBlokken[i] = 0;
                for (int j = 0; j < aantalBlokken; j++) {
                    totaalBlokken[i] += (j+1) * (j+1) * (j+1);
                }
            }

            for (int i = 0; i < aantalTorens; i++) {
                stdout.WriteLine(totaalBlokken[i]);
            }
        }
    }
}
