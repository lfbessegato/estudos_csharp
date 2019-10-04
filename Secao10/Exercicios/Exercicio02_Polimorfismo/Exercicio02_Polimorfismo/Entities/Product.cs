using System.Globalization;

namespace Exercicio02_Polimorfismo.Entities
{
    class Product
    {
        //Atributos
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtores
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
        //Métodos
        //virtual -> permissão para realizar a sobrecarga (override)
        public virtual string PriceTag()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
