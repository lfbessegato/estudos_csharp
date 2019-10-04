using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo03_Sobreposicao.Entities
{
    class SavingsAccount : Account
    {
        //Atributos
        public double InterestRate { get; set; }

        //Construtores
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        //Métodos
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Realizando a sobreescrição pois no método na superclasse foi definido como virtual 
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //Base -> Reaproveita o método da SuperClasse.
            Balance -= 2.0;
        }
    }
}
