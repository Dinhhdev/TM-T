using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDT_Lab4.Helper
{
    public interface ISearchParameters
    {
        string SearchTerm { get; set; }
        List<string> Company { get; set; }
        List<string> ScreenResolution { get; set; }
        SortCriteria SortBy { get; set; }
        List<string> TypeName { get; set; }
        List<double> Inches { get; set; }
        List<string> CPU { get; set; }
        List<double> Speed { get; set; }
        List<string> Memory { get; set; }
        List<int> Ram { get; set; }
        List<string> Gpu { get; set; }
        List<string> Gen { get; set; }
        List<string> OpSys { get; set; }
        double PriceLow { get; set; }
        double PriceHigh { get; set; }
        List<double> Weight { get; set; }


    }
}
