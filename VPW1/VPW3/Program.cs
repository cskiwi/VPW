using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BinairyPuzzel {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        private static void Main(string[] args) {

            // Krijg aantal opgaven
            int aantalOpgaven = int.Parse(stdin.ReadLine());

            // Declareer x aantal vars
            int[] grootte = new int[aantalOpgaven];
            List<bool[,]> grids = new List<bool[,]>();

            // Lees de opgaven
            for (int k = 0; k < aantalOpgaven; k++) {

                int size = int.Parse(stdin.ReadLine());
                grootte[k] = size;
                bool[,] grid = new bool[size, size];


                for (int i = 0; i < size; i++) {
                    string temp = stdin.ReadLine();
                    for (int j = 0; j < size; j++) {
                        grid[i, j] = temp[j]=='1';
                    }
                }
                grids.Add(grid);
            }

            // Los de opgaven op
            for (int k = 0; k < aantalOpgaven; k++) {

                int size = grootte[k];
                bool[,] grid = grids[k];
                //Grid overlopen
                int inarow = 0;
                bool darow = true;
                bool good = true;

                //check rij en kolom
                for (int i = 0; i < size; i++) {
                    int somRij = 0;
                    int somKol = 0;
                    for (int j = 0; j < size; j++) {
                        somRij += grid[i, j] ? 1 : 0;
                        somKol += grid[j, i] ? 1 : 0;
                    }
                    good = good && somRij == size / 2;
                    good = good && somKol == size / 2;
                    stdout.Write(grid[0, i] ? "1" : "0");
                }
                stdout.Write(good?" juist":" fout");

                if (k < aantalOpgaven - 1)
                    stdout.WriteLine();
            }

            stdout.Write(" ");
        }
    }
}