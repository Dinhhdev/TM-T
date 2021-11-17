using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan6.Models;

namespace Tuan6.Repository
{
    public class FavoritesList : BaseProductList
    {
        public override IEnumerable<Product> GetResults(ListParams parameters)
        {
            // Apply parameters here if you want.
            // or call a stored procedure to retrieve the results.
            return _products.Where(e => e.ListType ==
           ListType.Favorites).Skip((parameters.PageIndex - 1) *
           parameters.PageSize).Take(parameters.PageSize);
        }

        public int GetCount(int size)
        {
            int count = _products.Where(e => e.ListType == ListType.Favorites).Count();
            int  res= (int)(count / size);
            int val = count % size;

            return (val == 0)?res:(res + 1);
        }
    }
}