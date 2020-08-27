using PS2_TEST.Classes;
using System;
using Xunit;

namespace PSTESTXUnitTestProject
{    
    public class ProgramTest
    {
        [Fact]
        public void ProgramPaymentType1()
        {
            int paymentType = 1;
            PaymentProcessing objPaymentProcessing = new PaymentProcessing();
            string result = objPaymentProcessing.ProcessPayment(paymentType);
            Assert.Contains(result, "packing slip for Shipping");
        }

        [Fact]
        public void ProgramPaymentType2()
        {
            int paymentType = 2;
            PaymentProcessing objPaymentProcessing = new PaymentProcessing();
            string result = objPaymentProcessing.ProcessPayment(paymentType);
            Assert.Contains(result, "for Royalty");
        }

        [Fact]
        public void ProgramPaymentType3()
        {
            int paymentType = 3;
            PaymentProcessing objPaymentProcessing = new PaymentProcessing();
            string result = objPaymentProcessing.ProcessPayment(paymentType);
            Assert.Contains(result, "activated successfully");
        }

        [Fact]
        public void ProgramPaymentType4()
        {
            int paymentType = 4;
            PaymentProcessing objPaymentProcessing = new PaymentProcessing();
            string result = objPaymentProcessing.ProcessPayment(paymentType);
            Assert.Contains(result, "upgraded to membership successfully");
        }

        [Fact]
        public void ProgramPaymentType5()
        {
            int paymentType = 5;
            PaymentProcessing objPaymentProcessing = new PaymentProcessing();
            string result = objPaymentProcessing.ProcessPayment(paymentType);
            Assert.Contains(result, "Added free First Aid video");
        }
    }
}