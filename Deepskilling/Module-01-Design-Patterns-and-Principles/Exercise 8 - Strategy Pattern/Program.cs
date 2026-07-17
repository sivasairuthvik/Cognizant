PaymentContext payment = new PaymentContext(new CreditCardPayment());

payment.MakePayment(5000);

payment.SetPaymentStrategy(new PayPalPayment());

payment.MakePayment(2500);