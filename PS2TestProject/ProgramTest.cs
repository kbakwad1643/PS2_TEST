using Microsoft.VisualStudio.TestTools.UnitTesting;
using PS2_TEST.Classes;

namespace PS2TestProject
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ProgramValidTest()
        {
            int paymentType = 1;
            PaymentProcessing objPaymentProcessing = new PaymentProcessing();
            string result= objPaymentProcessing.ProcessPayment(paymentType);
            Assert.IsNotNull(result);
        }
    }
}