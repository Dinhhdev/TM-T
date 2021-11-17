using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuan6.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Available { get; set; }
        public ListType ListType { get; set; }
    }
}