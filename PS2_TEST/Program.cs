using PS2_TEST.Classes;
using System;

namespace PS2_TEST
{
    public class Program
    {
        static void Main(string[] args)
        {
            string paymentType = string.Empty;
            Console.Write("Please enter any one of the payment processing type: \n " +
                            "1: For Physical Product \n " +
                            "2: For a Book \n " +
                            "3: For Membership \n " +
                            "4: For Upgrade MemberShip \n " +
                            "5: For Video \n ");
            Console.WriteLine();
            Console.Write("Enter payment processing type: ");
            paymentType = Console.ReadLine();

            PaymentProcessing objPaymentProcessing = new PaymentProcessing();
            string result = objPaymentProcessing.ProcessPayment(Convert.ToInt32(paymentType));
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}