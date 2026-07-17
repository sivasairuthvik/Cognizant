IPaymentProcessor payPal = new PayPalAdapter();
payPal.ProcessPayment(1500);

Console.WriteLine();

IPaymentProcessor stripe = new StripeAdapter();
stripe.ProcessPayment(2500);