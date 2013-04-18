using System.IO;

namespace Cocktails {
    class Program {
        private static TextReader stdin = System.Console.In;
        private static TextWriter stdout = System.Console.Out;

        private static void Main(string[] args) {

            // Krijg aantal opgaven
            int aantalOpgaven = int.Parse(stdin.ReadLine());

            // Declareer x aantal vars
            int[] eenAantal = new int[aantalOpgaven];

            // Lees de opgaven
            for (int k = 0; k < aantalOpgaven; k++) {
                string qsdf = stdin.ReadLine();
                eenAantal[k]= int.Parse(stdin.ReadLine());

                // Lijst in opvage lezen
                for (int j = 0; j < eenAantal[k]; j++) {
                    int invoer = int.Parse(stdin.ReadLine());
                }

            }

            // Los de opgaven op
            for (int k = 0; k < aantalOpgaven; k++) {


                // Loop elk element af
                for (int n = 0; n < eenAantal; n++) {

                    // Krijg element
                    int element = int.Parse(stdin.ReadLine());

                    // Als kleiner dan huidig kleinste element (of bij nog 0 zet eerste waarde)
                    if (element < MinMax[k][0] || MinMax[k][0] == 0)
                        MinMax[k][0] = element;

                    // Als groter dan huidig element
                    if (element > MinMax[k][1])
                        MinMax[k][1] = element;
                }
                stdout.WriteLine("");
            }
        }
    }
}
