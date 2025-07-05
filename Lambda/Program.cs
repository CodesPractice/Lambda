namespace Lambda
{
    internal class Program
    {
        delegate int MyDelegate(int x);

        static void Main()
        {
            // ExpressionLambda();

            // Statement lambda: check even or odd
            MyDelegate evenOrOdd = x =>
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine($"{x} is Even");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine($"{x} is Odd");
                        return 0;
                    }
                };

            evenOrOdd(7);  // Output: 7 is Odd
            evenOrOdd(4);  // Output: 4 is Even

            Console.ReadKey();
        }

        public static void ExpressionLambda()
        {
            // Expression lambda: square of a number
            MyDelegate square = x => x * x;
            Console.WriteLine("Square of 5: " + square(5));  // Output: 25

            // Expression lambda: multiply by 10
            MyDelegate multiplyByTen = x => x * 10;
            Console.WriteLine("10 times 3: " + multiplyByTen(3));  // Output: 30
        }

       
    }
}
