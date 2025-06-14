namespace BankSystemConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            BankAccount bankAccount = new BankAccount();

            do
            {
                Console.WriteLine("===================================");
                Console.WriteLine("1. Account yarat");
                Console.WriteLine("2. Accounta pul yatır");
                Console.WriteLine("3. Accountdan pul cixart");
                Console.WriteLine("4. Balansa bax");
                Console.WriteLine("0. Close");
                Console.WriteLine("===================================");

                bool check = int.TryParse(Console.ReadLine(), out result);

                if (check)
                {
                    switch (result)
                    {
                        case 1:
                            Console.Write("Ad daxil edin: ");
                            bankAccount.customerName = Console.ReadLine();

                            Console.Write("Blance daxil edin: ");
                            bankAccount.balance = Convert.ToInt32(Console.ReadLine());
                            BankAccountManager.CreateAccount(bankAccount);

                            break;


                        case 2:
                            Console.Write("Deposit elave edin: ");
                            int increment = Convert.ToInt32(Console.ReadLine());
                            bankAccount.Deposit(increment);

                            break;

                        case 3:
                            Console.Write("Vəsait çıxar: ");
                            int decrement = Convert.ToInt32(Console.ReadLine());
                            bankAccount.Withdraw(decrement);

                            break;

                        case 4:
                            bankAccount.GetBalance();
                            break;

                        case 0:
                            Console.WriteLine("Yeri get isinnen mesgul ol");
                            break;
                    }
                }
            }
            while (result != 0);
        }
    }
}
