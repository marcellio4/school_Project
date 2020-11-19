namespace interpreter
{
    public class Number : IExpression
    {
        private int _n;
        internal Number(int n)
        {
            _n = n;
        }


        public int Interpret()
        {
            return _n;
        }
    }
}