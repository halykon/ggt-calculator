namespace ggt
{
    public class Calc
    {
        private readonly int _a, _b;
        public Calc(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int CalcGgt()
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

        public int CalcKgv()
        {
            return _a * _b / CalcGgt();
        }
    }
}