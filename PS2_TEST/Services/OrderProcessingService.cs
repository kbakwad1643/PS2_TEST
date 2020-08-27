using PS2_TEST.Repository;

namespace PS2_TEST.Services
{
    public class OrderProcessingService
    {
        private IOrderProcessingRepository _orderProcessingRepository = new OrderProcessingRepository();

        public string CreatePackingSlip(int packingType)
        {
            return _orderProcessingRepository.CreatePackingSlip(packingType);
        }

        public string VideoToPackingSlip(int memberId)
        {
            return _orderProcessingRepository.VideoToPackingSlip(memberId);
        }
    }
}
