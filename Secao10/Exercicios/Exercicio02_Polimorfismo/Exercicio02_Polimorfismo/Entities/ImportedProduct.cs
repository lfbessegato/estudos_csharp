using System.Globalization;

namespace Exercicio02_Polimorfismo.Entities
{
    class ImportedProduct : Product //Herança
    {
        //Atributos
        public double CustomsFee { get; set; }

        //Construtores
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        //Métodos
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        //override -> Sobrecarga, antes precisa habilitar a permissão com a palavra no método da superclasse
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
