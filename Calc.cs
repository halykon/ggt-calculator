namespace ggt
{
    /// <summary>
    /// ይህ ክፍል ለ ዘዴዎች ያጋልጣል
    /// በጣም ዝቅተኛውን የጋራ ብዛት ማስላት
    /// እና ትልቁ የጋራ ነገር
    /// </summary>
    public class Calc
    {
        private readonly int _a, _b;
        /// <summary>
        /// ለ ‹Calc› ክፍል ገንቢ
        /// </summary>
        /// <param name="a">የመጀመሪያው የግቤት ቁጥር</param>
        /// <param name="b">ሁለተኛው የግቤት ቁጥር</param>
        public Calc(int a, int b)
        {
            _a = a;
            _b = b;
        }

        /// <summary>
        /// ትልቁን የጋራ ነገር አስሉ
        /// </summary>
        /// <returns>ትልቁን የጋራ ነገር ይመልሳል</returns>
        public int CalcGcf()
        {
            var a = _a;
            var b = _b;
            
            while (true)
            {
                var r = a % b;
                if (r == 0) return b;
                a = b;
                b = r;
            }
        }
        
        /// <summary>
        /// በጣም ዝቅተኛውን የጋራ ብዛት ያሰሉ
        /// </summary>
        /// <returns>በጣም ዝቅተኛውን የጋራ ብዛት ይመልሳል</returns>
        public int CalcLcm()
        {
            return _a * _b / CalcGcf();
        }
    }
}