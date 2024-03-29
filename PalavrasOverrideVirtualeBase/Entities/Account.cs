﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavrasOverrideVirtualeBase.Entities
{
    abstract class Account // classes abstratas não podem ser instanciadas.
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) // adicionando o virtual, você dá a possibilidade dela ser utilizada em um método override.
        {
            Balance -= amount + 5.0;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

    }
}
