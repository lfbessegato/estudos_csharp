namespace Exemplo02_Upcasting_DownCasting.Entities
{
    class BusinessAccount : Account
    {
        //Atributos
        public double LoanLimit { get; set; }

        //Construtores
        public BusinessAccount()
        {
        }

        
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) //Aproveita da superclasse
        {
            LoanLimit = loanLimit;
        }

        //Métodos
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
