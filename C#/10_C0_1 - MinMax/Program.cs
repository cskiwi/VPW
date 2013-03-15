using System.IO;

namespace _10_C0_1___MinMax {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        private static void Main(string[] args) {

            // Krijg aantal lijsten
            int aantalLijsten = int.Parse(stdin.ReadLine());
            int[][] MinMax = new int[aantalLijsten][];

            // Loop elke lijst af
            for (int k = 0; k < aantalLijsten; k++) {

                // Elementen in lijst
                int aantalElementen = int.Parse(stdin.ReadLine());

                // Creer array er voor
                MinMax[k] = new int[2];

                // Loop elk element af
                for (int n = 0; n < aantalElementen; n++) {

                    // Krijg element
                    int element = int.Parse(stdin.ReadLine());

                    // Als kleiner dan huidig kleinste element (of bij nog 0 zet eerste waarde)
                    if (element < MinMax[k][0] || MinMax[k][0] == 0)
                        MinMax[k][0] = element;

                    // Als groter dan huidig element
                    if (element > MinMax[k][1])
                        MinMax[k][1] = element;
                }
            }

            // output result
            foreach (int[] list in MinMax)
                stdout.WriteLine("" + list[0] + " " + list[1]);
        }
    }
}
