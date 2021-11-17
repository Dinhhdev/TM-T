using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMDT_Lab4.Helper
{
    public class SearchParameters : ISearchParameters
    {
        public SearchParameters()
        {
            SearchTerm = String.Empty;
            Company = new List<string>();
            ScreenResolution = new List<string>();
            SortBy = SortCriteria.Relevance;
            TypeName = new List<string>();
            Gen = new List<string>();
            Inches = new List<double>();
            CPU = new List<string>();
            Speed = new List<double>();
            Memory = new List<string>();
            Ram = new List<int>();
            Gpu = new List<string>();
            OpSys = new List<string>();
            PriceLow = 0;
            PriceHigh = 0;
            Weight = new List<double>();
            Price_euros = 0;
        }


        public string SearchTerm { get; set; }
        public List<string> Company { get; set; }
        public List<string> ScreenResolution { get; set; }
        public SortCriteria SortBy { get; set; }
        public List<string> TypeName { get; set; }
        public List<double> Inches { get; set; }
        public List<string> CPU { get; set; }
        public List<double> Speed { get; set; }
        public List<string> Memory { get; set; }
        public List<string> Gen { get; set; }
        public List<int> Ram { get; set; }
        public List<string> Gpu { get; set; }
        public List<string> OpSys { get; set; }
        public double PriceLow { get; set; }
        public double PriceHigh { get; set; }

        public double Price_euros { get; set; }
        public List<double> Weight { get; set; }
    }
}