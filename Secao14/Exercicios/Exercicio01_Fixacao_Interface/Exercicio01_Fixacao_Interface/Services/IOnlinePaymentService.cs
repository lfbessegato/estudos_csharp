namespace Exercicio01_Fixacao_Interface.Services {
    interface IOnlinePaymentService {

        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
