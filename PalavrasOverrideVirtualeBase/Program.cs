using PalavrasOverrideVirtualeBase.Entities;

namespace PalavrasOverrideVirtualeBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc2 = new SavingsAccount(1001, "Alex", 500,0.1); // Chama UpCasting

  
            acc2.Withdraw(10);

      
            Console.WriteLine(acc2.Balance);
        }
    }
}