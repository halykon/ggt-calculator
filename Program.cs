using System;

namespace ggt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 1){ Console.WriteLine("Malformed input"); return; }
            
                var x = int.TryParse(args[0], out var a);
                var y = int.TryParse(args[1], out var b);
            
                if (!x || !y) { Console.WriteLine("Malformed input"); return; }
            
                var calc = new Calc(a, b);

                Console.WriteLine($"GGT: {calc.CalcGgt()}, KGV: {calc.CalcKgv()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured: {e}");
            }
        }
    }
}