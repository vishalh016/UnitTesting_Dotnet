namespace calculator
{
    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double AddD(double a, double b)
        {
            return a + b;
        }
        public bool IsOdd(int a) { return a % 2 != 0; }
    }
}