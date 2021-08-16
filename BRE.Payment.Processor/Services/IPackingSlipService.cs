using BRE.Payment.Processor.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.Services
{
    public interface IPackingSlipService
    {

        PackingSlip GenerateOrder(Order order);
        string genertePackingSlip(Order order);

        string genertePackingSlipForRoyaltyService(Order order);
        //
    }
}
