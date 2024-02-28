namespace FinanceTrackerCons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotIncome = 0;
            int TotExpenses = 0;

            while (true) 
            {
                
                Console.WriteLine("Finance Tracker\n----------------------");
                Console.WriteLine("1. Add income");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. Display Total Balance");
                Console.WriteLine("4.Exit\n");

                Console.WriteLine("Enter your choice (1-4):");
                string Choice = Console.ReadLine();

                switch (Choice) 
                {
                    case "1":
                        Console.WriteLine("Enter income amount: ");
                        if (int.TryParse(Console.ReadLine(), out int income))
                        {
                            TotIncome += income;
                            Console.WriteLine($"income added: R{income}");
                        }
                        else 
                        {
                            Console.WriteLine("invalid input. Please enter a valid numeric value");
                        }
                        break;
                    case "2": Console.WriteLine("enter expense amount: ");
                        if (int.TryParse(Console.ReadLine(), out int expense))
                        {
                            TotExpenses += expense;
                            Console.WriteLine($"Expense added: {expense}");
                        }
                        else 
                        {
                            Console.WriteLine("invalid input please enter a valid numeric value.");
                        }
                        break;
                    case "3":
                        int TotBal = TotIncome - TotExpenses;
                        Console.WriteLine($"Total Balance: {TotBal}");
                        break;
                    case "4":
                        Console.WriteLine("exiting finance tracker. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("invalid choice please choose a valid option (1-4)");
                        break;
                        
                }

            }
        }
    }
}
