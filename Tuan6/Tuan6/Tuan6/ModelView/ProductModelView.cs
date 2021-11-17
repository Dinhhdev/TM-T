using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan6.Models;

namespace Tuan6.ModelView
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}