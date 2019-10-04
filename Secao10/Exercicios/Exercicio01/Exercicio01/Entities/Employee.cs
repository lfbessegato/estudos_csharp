namespace Exercicio01.Entities
{
    class Employee
    {
        //Atributos
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        //Construtor
        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //Métodos 
        //virtual -> permissão para override (sobrescrição)
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
