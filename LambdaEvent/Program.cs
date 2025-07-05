namespace LambdaEvent
{

    class BankAccount
    {
        public delegate void BalanceChangedHandler(int newBalance);
        public event BalanceChangedHandler OnBalanceChanged;

        private int balance = 0;

        public void Deposit(int amount)
        {
            balance += amount;

            // Trigger the event when balance changes
            OnBalanceChanged?.Invoke(balance);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            // Subscribe to the event using a lambda expression
            account.OnBalanceChanged += newBalance =>
            {
                Console.WriteLine($"Balance updated: {newBalance}");
            };


            // Another subscriber with a lambda to show a message if goal reached
            account.OnBalanceChanged += newBalance =>
            {
                if (newBalance >= 500)
                    Console.WriteLine("You reached your savings goal!");
            };


            string input;
            do
            {
                Console.Write("How much do you want to deposit? : ");
                input = Console.ReadLine();


                if (int.TryParse(input, out int amount))
                {
                    account.Deposit( amount);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

            } while (input.ToLower() != "exit");

            Console.ReadKey();
        }
    }


}
