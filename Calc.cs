namespace ggt
{
    /// <summary>
    /// This class exposes to methods for
    /// calculating the lowest common multiple
    /// and greatest common factor
    /// </summary>
    public class Calc
    {
        private readonly int _a, _b;
        /// <summary>
        /// Constructor for the Calc class
        /// </summary>
        /// <param name="a">The first input number</param>
        /// <param name="b">The second input number</param>
        public Calc(int a, int b)
        {
            _a = a;
            _b = b;
        }

        /// <summary>
        /// Calculate the greatest common factor
        /// </summary>
        /// <returns>Returns the greatest common factor</returns>
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
        /// Calculate the lowest common multiple
        /// </summary>
        /// <returns>Returns the lowest common multiple</returns>
        public int CalcLcm()
        {
            return _a * _b / CalcGcf();
        }
    }
}