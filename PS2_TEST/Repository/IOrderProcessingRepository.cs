using System;
using System.Collections.Generic;
using System.Text;

namespace PS2_TEST.Repository
{
    public interface IOrderProcessingRepository
    {
        string CreatePackingSlip(int packingType);

        string VideoToPackingSlip(int memberId);
    }
}
