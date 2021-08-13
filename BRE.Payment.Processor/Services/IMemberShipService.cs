using BRE.Payment.Processor.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.Services
{
    interface IMemberShipService
    {
        void AddOrUpgradeMembership(User user, MemberShip membership);
    }
}
