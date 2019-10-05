using System;

namespace Exemplo03_Erros_Personalizados.Entities.Exceptions {
    class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    }
}
