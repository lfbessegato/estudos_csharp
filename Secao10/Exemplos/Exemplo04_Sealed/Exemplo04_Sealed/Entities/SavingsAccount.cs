using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo04_Sealed.Entities
{
    sealed class SavingsAccount : Account { //Sealed -> Evita que sejam criadas subclasses de SavingsAccount
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
        //Sealed -> Proibe do método seja sobrescrito em outra subclasse de SavingsAccount
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount); //Base -> Reaproveita o método da SuperClasse.
            Balance -= 2.0;
        }
    }
}
