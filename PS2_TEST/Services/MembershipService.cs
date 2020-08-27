using PS2_TEST.Repository;

namespace PS2_TEST.Services
{
    public class MembershipService
    {
        private IMembershipRepository _membershipRepository = new MembershipRepository();

        public string ActivateMemberShip(int memberId)
        {
            return _membershipRepository.ActivateMemberShip(memberId);
        }

        public string UpgradeMemberShip(int memberId)
        {
            return _membershipRepository.UpgradeMemberShip(memberId);
        }
    }
}
