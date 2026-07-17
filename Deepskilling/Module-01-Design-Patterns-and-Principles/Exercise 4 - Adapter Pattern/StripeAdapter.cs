public class StripeAdapter : IPaymentProcessor
{
    private readonly StripeGateway stripeGateway;

    public StripeAdapter()
    {
        stripeGateway = new StripeGateway();
    }

    public void ProcessPayment(double amount)
    {
        stripeGateway.MakePayment(amount);
    }
}