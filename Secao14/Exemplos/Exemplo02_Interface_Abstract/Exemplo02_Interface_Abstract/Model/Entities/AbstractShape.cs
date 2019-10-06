using Exemplo02_Interface_Abstract.Model.Enums;

namespace Exemplo02_Interface_Abstract.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
