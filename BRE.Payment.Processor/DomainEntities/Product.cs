using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.DomainEntities
{
    public class Product
    {
        public Product(string sku)
        {
            _sku = sku;
        }

        private string _sku;
        public string getSku()
        {
            return _sku;
        }
    }


}
