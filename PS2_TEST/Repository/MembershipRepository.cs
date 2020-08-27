using System;
using System.Collections.Generic;
using System.Text;

namespace PS2_TEST.Repository
{
    public class MembershipRepository : IMembershipRepository
    {
        public string ActivateMemberShip(int memberId)
        {
            string activationStatus = string.Empty;
            // connect to DB and activate the membership for the memberId

            activationStatus = "Member: " + memberId + " activated successfully";
            if (SendEmailToMember(memberId))
            {
                activationStatus = activationStatus + " and sent an email";
            }

            return activationStatus;
        }

        public string UpgradeMemberShip(int memberId)
        {
            string upgradeStatus = string.Empty;
            // connect to DB and upgrade to membership for the memberId

            upgradeStatus = "Member: " + memberId + " upgraded to membership successfully";

            if (SendEmailToMember(memberId))
            {
                upgradeStatus = upgradeStatus + " and sent an email";
            }

            return upgradeStatus;
        }

        private bool SendEmailToMember(int memberId)
        {
            bool emailSentStatus = false;
            // connect to DB and get member details for the memberId
            string memberName = "Test";
            string emailAddress = "test@gmail.com";

            if (!(string.IsNullOrEmpty(memberName)) && !(string.IsNullOrEmpty(emailAddress)))
            {
                // semd email code which returns status as True./False
                emailSentStatus = true;
            }

            return emailSentStatus;
        }
    }
}
