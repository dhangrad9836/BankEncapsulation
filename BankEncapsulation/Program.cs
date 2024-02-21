namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();
            account1.Deposit(500);

            Console.WriteLine($"{account1.GetBalance()}");

            Console.ReadLine();
        }
    }
}
