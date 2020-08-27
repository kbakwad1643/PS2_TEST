using PS2_TEST.Services;

namespace PS2_TEST.Classes
{
    public class PaymentProcessing
    {
        int activateMemberId = 12350;
        int upgradeMemberId = 26789;
        int videoToPackingSlipMemberId = 45781;

        public string ProcessPayment(int paymentType)
        {
            string result = string.Empty;
            switch (paymentType)
            {
                case 1: // For Physical Product
                case 2: // For a Book
                    OrderProcessingService objOrderProcessingService = new OrderProcessingService();
                    result = objOrderProcessingService.CreatePackingSlip(paymentType);
                    break;
                case 3: // For Membership
                    MembershipService objMembershipService = new MembershipService();
                    result = objMembershipService.ActivateMemberShip(activateMemberId);
                    break;
                case 4: // For Upgrade MemberShip
                    MembershipService objMembershipService1 = new MembershipService();
                    result = objMembershipService1.UpgradeMemberShip(upgradeMemberId);
                    break;
                case 5: // For Video
                    OrderProcessingService objOrderProcessingService1 = new OrderProcessingService();
                    result = objOrderProcessingService1.VideoToPackingSlip(videoToPackingSlipMemberId);
                    break;
            }

            return result;
        }
    }
}
