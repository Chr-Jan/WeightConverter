namespace SimpleBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(66.6);
            account.Deposit(double.Parse(Console.ReadLine()));
           
        }
    }
}