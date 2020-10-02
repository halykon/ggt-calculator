using System;

namespace ggt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                // Return if there are too few args
                if (args.Length < 1){ Console.WriteLine("Malformed input"); return; }
                
                // TryParse the input from the CLI
                var x = int.TryParse(args[0], out var a);
                var y = int.TryParse(args[1], out var b);
            
                // Return if the input wasn't parsed successfully
                if (!x || !y) { Console.WriteLine("Malformed input"); return; }
            
                // Instantiate new class to calc gcf and lcm
                var calc = new Calc(a, b);

                // calc results and write them to STDOUT
                Console.WriteLine($"GGT: {calc.CalcGcf()}, KGV: {calc.CalcLcm()}");
            }
            catch (Exception e)
            {
                // Caught the little bastard!
                // TO THE CONSOLE WITH HIM!
                Console.WriteLine($"An error occured: {e}");
            }
        }
    }
}