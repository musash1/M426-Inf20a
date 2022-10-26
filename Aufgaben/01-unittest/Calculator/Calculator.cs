using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int faktorA, int faktorB)
        {
            return faktorA * faktorB;
        }

        public int Divide(int dividend, int divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException)
            {
                throw new ArgumentException("Division durch 0 ist nicht erlaubt.");
            }
        }
    }
}
