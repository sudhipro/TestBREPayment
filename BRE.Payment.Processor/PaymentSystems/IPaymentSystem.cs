using System;
using System.Collections.Generic;
using System.Text;
using BRE.Payment.Processor.DomainEntities;

namespace BRE.Payment.Processor.PaymentSystems
{
    public interface IPaymentSystem
    {
        void Run(Payments paymnt);
    }
}
