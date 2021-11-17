using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan6.Models;

namespace Tuan6.Repository
{
    public class SearchResultList : BaseProductList
    {
        public override IEnumerable<Product> GetResults(ListParams parameters)
        {
            // Apply parameters here if you want.
            // or call a stored procedure to retrieve the results.
            if (parameters.SearchTerm != null)
            {
                return _products.Where(c =>
               c.Title.Contains(parameters.SearchTerm)).Skip((parameters.PageIndex - 1) *
               parameters.PageSize).Take(parameters.PageSize);
            }
            return _products.Skip((parameters.PageIndex - 1) * parameters.PageSize).Take(parameters.PageSize);

        }

        public int GetCount(int size)
        {
            int count = _products.Count();
            int res = (int)(count / size);
            int val = count % size;

            return (val == 0) ? res : (res + 1);
        }
    }
}