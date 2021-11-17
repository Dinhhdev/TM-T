using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan6.Models;

namespace Tuan6.Repository
{
    public abstract class BaseProductList
    {
        protected IEnumerable<Product> _products = FakeProductList.GetProducts();
        //add data sau
        public virtual IEnumerable<Product> GetResults(ListParams parameters)
        {
            return null;
        }
    }

}