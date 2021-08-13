using BRE.Payment.Processor.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.DomainEntities
{
   public class User
    {
        public void addMembership(MemberShip memberShip, EmailServices emailSrv)
        {
          new EmailServices().SendEmailService(this, memberShip);
        }
    }
}
