namespace Exemplo02_Upcasting_DownCasting.Entities
{
    class SavingsAccount : Account
    {
        //atributos
        public double InterestRate { get; set; }

        //Construtores
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) //Aproveita da superclasse
        {
            InterestRate = interestRate;
        }

        //Métodos
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
