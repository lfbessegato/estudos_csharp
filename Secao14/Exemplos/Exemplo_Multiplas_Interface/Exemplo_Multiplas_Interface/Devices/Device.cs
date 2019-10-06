namespace Exemplo_Multiplas_Interface.Devices {
    abstract class Device {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
