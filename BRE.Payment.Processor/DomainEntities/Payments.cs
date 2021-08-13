using BRE.Payment.Processor.PaymentSystems;

namespace BRE.Payment.Processor.DomainEntities
{
    public class Payments
    {
        public Payments()
        { }
        private Order _order = new Order();
        public Order getOrder()
        {
            return _order;
        }
        public Payments(Order order)
        {
            _order = order;
        }

       

        public void Process(IPaymentSystem[] Ps)
        {
            foreach (IPaymentSystem p in Ps)
                p.Run(this);
        }

    }
}