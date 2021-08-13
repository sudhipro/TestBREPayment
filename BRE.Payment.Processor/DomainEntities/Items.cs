using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.DomainEntities
{
    public class Items
    {
        public Items(String stockid, String name, ProductCategory[] categories)
        {
            _stockid = stockid;
            _name = name;

            _categories = new List<string>();
            if (categories != null)
            {
                _categories.Add(ProductCategory.Books);
                _categories.Add(ProductCategory.Physical);
                _categories.Add(ProductCategory.Videos);
                _categories.Add(ProductCategory.Membership);
            }
        }

        private  String _stockid;
    public String getstockid()
        {
            return _stockid;
        }

        public  String _name;
    public String getName()
        {
            return _name;
        }

        private  List<string> _categories;
        public bool hasCategory(string category)
        {
            return _categories.Contains(category.ToString());
        }
    }
}
