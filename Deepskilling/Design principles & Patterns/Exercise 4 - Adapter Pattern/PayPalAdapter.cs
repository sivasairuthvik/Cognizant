public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPalGateway payPalGateway;

    public PayPalAdapter()
    {
        payPalGateway = new PayPalGateway();
    }

    public void ProcessPayment(double amount)
    {
        payPalGateway.SendPayment(amount);
    }
}