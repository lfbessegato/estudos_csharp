﻿using System.Globalization;

namespace Exemplo01_comInterface.Entities {
    class Invoice {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double rental, double tax) {
            BasicPayment = rental;
            Tax = tax;
        }

        public double TotalPayment {
            get { return BasicPayment + Tax; }
        }

        public override string ToString() {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
