using System;
using System.Globalization;

namespace Exercicio02_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
            //Atributos
            public DateTime ManufactureDate { get; set; }

            //Construtores
            public UsedProduct()
            {
            }

            public UsedProduct(string name, double price, DateTime manufactureDate)
                : base(name, price)
            {
                ManufactureDate = manufactureDate;
            }

            //Método
            //override -> Sobrecarga, antes precisa habilitar a permissão com a palavra no método da superclasse
            public override string PriceTag()
            {
                return Name
                    + " (used) $ "
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + " (Manufacture date: "
                    + ManufactureDate.ToString("dd/MM/yyyy")
                    + ")";
            }
    }
}
