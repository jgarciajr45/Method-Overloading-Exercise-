namespace MethodOverloading
{
    public class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        static string Add(int a, int b, bool dollarString)
        {
            int sum = a + b;
            if (dollarString)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                 }
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            int intSum = Add(4, 4);
            Console.WriteLine($"Sum of integers: {intSum}");

            decimal decimalSum = Add(4.5m, 5.5m);
            Console.WriteLine($"Sum of decimals: {decimalSum}");

            string result1 = Add(1, 0, true);
            Console.WriteLine(result1);
            string result2 = Add(5, 7, true);
            Console.WriteLine(result2);
            string result3 = Add(5, 7, false);
            Console.WriteLine(result3);

        }
    }
}
