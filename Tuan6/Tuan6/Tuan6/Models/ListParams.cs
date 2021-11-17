using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuan6.Models
{
    public class ListParams
    {
        public string SearchTerm { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
    }

}