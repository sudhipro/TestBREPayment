using BRE.Payment.Processor.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.Services
{
    interface ICommissionPaymentService
    {
        void PayCommissionToAgent(Agent user, Order order);
    }
}
