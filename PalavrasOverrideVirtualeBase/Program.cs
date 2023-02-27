using PalavrasOverrideVirtualeBase.Entities;

namespace PalavrasOverrideVirtualeBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1001, "Alex", 500,0.1); // Chama UpCasting

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}