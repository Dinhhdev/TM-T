using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan6.Models;

namespace Tuan6.Repository
{
    public class ChristmasList : BaseProductList
    {
        public override IEnumerable<Product> GetResults(ListParams parameters)
        {
           
            return _products;
        }
    }
}