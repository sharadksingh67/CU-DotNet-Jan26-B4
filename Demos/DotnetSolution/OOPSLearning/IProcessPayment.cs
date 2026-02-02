namespace OOPSLearning
{
    //class DoPayment
    //{

    //}
    //internal interface IProcessPayment
    //{
    //    void ProcessPayment();
    //}

    //internal interface IConfirmPayment
    //{
    //    void ConfirmPayment();
    //}

    //class Payments : DoPayment, IProcessPayment, IConfirmPayment
    //{
    //    public void ConfirmPayment()
    //    {
    //        Console.WriteLine("Payment Done");
    //    }

    //    public void ProcessPayment()
    //    {
    //        Console.WriteLine("Payment Processed");
    //    }
    //}


    interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Credit Card payment processed for {amount}");
        }
    }

    class PaytmProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paytm payment processed for {amount}");
        }
    }

    class CheckoutManager
    {
        public void CompletePurchase(IPaymentProcessor processor, double amount) 
        {
            processor.ProcessPayment(amount);
        }
    }

    class TestInterfaces
    {
        static void Main(string[] args)
        {
            CheckoutManager checkoutManager = new CheckoutManager();
            IPaymentProcessor processor = new PaytmProcessor();
            checkoutManager.CompletePurchase(processor, 12000);
        }
    }
}
