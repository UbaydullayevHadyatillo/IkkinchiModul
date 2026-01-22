using _2._8._2_dars.services;

namespace _2._8._2_dars;

internal class Program
{
    static void Main(string[] args)
    {
        IPayment payment = GetPayment();
        payment.SendPayment();
    }
    public static IPayment GetPayment()
    {
        IPayment clicPaymentService = new ClicService();
        IPayment paynetPaymentService = new PaynetService();
        IPayment xaznaPaymentService = new XaznaService();
        IPayment zoomradPaymentService = new ZoomradService();
        return paynetPaymentService;
    }
}
