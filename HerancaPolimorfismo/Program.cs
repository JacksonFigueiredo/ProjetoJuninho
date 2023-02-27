using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BusinessAccount businessAccount = new BusinessAccount(1,"Jackson",1000,5000);

            businessAccount.Deposit(1000);
            businessAccount.Loan(1000);

            Console.WriteLine(businessAccount.Balance);
        }
    }
}