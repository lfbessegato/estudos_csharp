using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo03_Sobreposicao.Entities
{
    class Account
    {
        //Atributos
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        //Construtores
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Métodos
        public virtual void Withdraw(double amount) //Permitir a sobreposição na subclasse
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
