using Exercicio03_Abstrato.Enums;

namespace Exercicio03_Abstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
