namespace Exercicio01.Entities
{
    class OutsourcedEmployee : Employee //Extends(herda) da classe Employee
    {
        //Atributos
        public double AdditionalCharge { get; set; }

        //Construtores
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour) //Reaproveita os atributos recebidos da superclasse (employee)
        {
            AdditionalCharge = additionalCharge;
        }

        //Métodos
        //override -> Após a definição de virtual (permissão), agora pode fazer a sobrescrição
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
