using BRE.Payment.Processor.DomainEntities;
using BRE.Payment.Processor.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.PaymentSystems
{
    public class PackingSlipGeneratorSystem :  IPaymentSystem
    {
        private  IPackingSlipService _packingSlipService;
    private IPackingSlipService _shippingService;
    private  IPackingSlipService _royaltyService;

    public PackingSlipGeneratorSystem(IPackingSlipService shippingService,
                              IPackingSlipService royaltyService,
                              IPackingSlipService packingSlipService)
        {
            _shippingService = shippingService;
            _royaltyService = royaltyService;
            _packingSlipService = packingSlipService;
        }
        public void Run(Payments paymnt)
        {
             Order order = new Payments().getOrder();
             Items[] eachItems = order.getItems();

            Boolean generateForShipping = false;
            Boolean generateForRoyalty = false;

            foreach (Items it in eachItems)
            {
                if (it.hasCategory(ProductCategory.Physical))
                    generateForShipping = true;
                if (it.hasCategory(ProductCategory.Books))
                    generateForRoyalty = true;

                if (it.getName() == "learning-to-ski")
                    order.addGifts("first-aid");
            }

            _packingSlipService.GenerateOrder(order);

            if (generateForShipping)
                _shippingService.genertePackingSlip(order);
            if (generateForRoyalty)
                _royaltyService.genertePackingSlipForRoyaltyService(order);
        }
    }
}
