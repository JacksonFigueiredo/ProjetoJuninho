using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavrasOverrideVirtualeBase.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) // irá trazer de base para o construtor do savingsacount
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) // adicionando o override, você dá a possibilidade de re-escrever um método pré-existente que foi herdado porém marcado como virtual.
        {
            Balance -= amount;
        }


    }
}
