namespace Lambda
{
    internal class Program
    {
        delegate int MyDelegate(int x);

        static void Main()
        {
            // Expression lambda: square of a number
            MyDelegate square = x => x * x;
            Console.WriteLine("Square of 5: " + square(5));  // Output: 25

            // Expression lambda: multiply by 10
            MyDelegate multiplyByTen = x => x * 10;
            Console.WriteLine("10 times 3: " + multiplyByTen(3));  // Output: 30

            Console.ReadKey();  
        }

        public static void ExpressionLambda()
        {

        }
    }
}
