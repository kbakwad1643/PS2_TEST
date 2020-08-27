using System;
using System.Collections.Generic;
using System.Text;

namespace PS2_TEST.Repository
{
    public interface IMembershipRepository
    {
        string ActivateMemberShip(int memberId);

        string UpgradeMemberShip(int memberId);
    }
}
