namespace Exemplo01_Heranca.Entities
{
    class BusinessAccount : Account //Isso quer dizer que a classe está herdando de Account
    {
        //Atributos
        public double LoanLimit { get; set; }

        //Construtores
        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) //Construtor da SuperClasse (Account)
        {
            LoanLimit = loanLimit;
        }

        //Método
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
