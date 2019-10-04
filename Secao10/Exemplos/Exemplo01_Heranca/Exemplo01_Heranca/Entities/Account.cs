namespace Exemplo01_Heranca.Entities
{
    class Account
    {
        //Atributos Básicos
        public int Number { get; private set; } //Não pode alterar, somente acessar
        public string Holder { get; private set; } // idem
        public double Balance { get; protected set; } //permite alterar somente para a subclasse

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
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
