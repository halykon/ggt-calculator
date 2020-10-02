using System;

namespace ggt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                // በጣም ጥቂት ክርክሮች ካሉ ይመለሱ
                if (args.Length < 1){ Console.WriteLine("Malformed input"); return; }
                
                // ከትእዛዝ መስመር በይነገጽ ግቤቱን ይሞክሩ ይሞክሩ
                var x = int.TryParse(args[0], out var a);
                var y = int.TryParse(args[1], out var b);
            
                // ግብዓቱ በተሳካ ሁኔታ ካልተመረመረ ይመለሱ
                if (!x || !y) { Console.WriteLine("Malformed input"); return; }
            
                // ታላቅ የጋራ ሁኔታን እና ዝቅተኛውን የጋራ ብዛትን ለማስላት አዲስ ክፍልን በፍጥነት ያስጀምሩ
                var calc = new Calc(a, b);

                // ውጤቶችን ያስሉ እና ወደ መደበኛ ውጤት ይፃፉ
                Console.WriteLine($"GGT: {calc.CalcGcf()}, KGV: {calc.CalcLcm()}");
            }
            catch (Exception e)
            {
                // ትንሹ ባስታርን ያዘው!
                // ከእሱ ጋር ወደ ኮንሶል!
                Console.WriteLine($"An error occured: {e}");
            }
        }
    }
}