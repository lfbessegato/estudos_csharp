using System;
using System.Globalization;

namespace Exemplo06_AutoProperties
{
    class Produto
    {
        // Por convencao deve-se criar com um _ e as iniciais como minusculo
        private string _nome;

        //Definição para AutoProperties
        public double Preco { get; private set; } // private -> O Preço não pode ser alterado externanmente
        public int Quantidade { get; private set; }

        public Produto() // Construtor Padrão
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

     
        //Operação PROPERTIES
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
