namespace Refactoring;

public class Fibonacci
{
    public static long Fib(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Fibonacci undefined for negative numbers");
        }
        if (n == 0 || n == 1)
        {
            return n;
        }

        long num1 = 1; 
        long num2 = 1; 
        long result = 0;

        for (int i = 2; i < n; i++)
        {
            result = num1 + num2;
            num1 = num2;
            num2 = result;
        }

        return result;
    }
}