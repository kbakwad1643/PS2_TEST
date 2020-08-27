using PS2_TEST.Utilities;
using System;

namespace PS2_TEST.Repository
{
    public class OrderProcessingRepository : IOrderProcessingRepository
    {
        public string CreatePackingSlip(int packingType)
        {
            string strPackingSlip = string.Empty;
            try
            {
                if (packingType == (int)Utility.PackingType.Shipping)
                {
                    // connect to DB and fetch record(s) for Shipping

                    strPackingSlip = "This is a packing slip for Shipping.";
                    strPackingSlip = strPackingSlip + GenerateCommissionPayment(packingType);
                }

                if (packingType == (int)Utility.PackingType.Royalty)
                {
                    // connect to DB and fetch record(s) for Royalty

                    strPackingSlip = "This is a packing slip for Royalty.";
                    strPackingSlip = strPackingSlip + GenerateCommissionPayment(packingType);
                }
            }
            catch (Exception)
            {
                // Log exception            
            }
            return strPackingSlip;
        }

        public string VideoToPackingSlip(int memberId)
        {
            string strfreeVideo = string.Empty;
            // connect to DB and fetch record(s) for packing slip for the memberId
            // Then add the First Aid video to the packing slip object

            strfreeVideo = "Added free First Aid video to the packing slip for the member: " + memberId;

            return strfreeVideo;
        }

        private string GenerateCommissionPayment(int packingType)
        {
            string strCommissionPayment = string.Empty;
            try
            {
                if (packingType == (int)Utility.PackingType.Shipping || packingType == (int)Utility.PackingType.Royalty)
                {
                    // connect to DB and generate Commission Payment to agent for Shipping OR Royalty

                    strCommissionPayment = " Along with generated Commission Payment to the agent";
                }
            }
            catch (Exception)
            {
                // Log exception            
            }
            return strCommissionPayment;
        }
    }
}
