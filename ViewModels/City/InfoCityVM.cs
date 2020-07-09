using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class InfoCityVM
    {
        public IEnumerable<GetCityVM> Source_Cities { get; set; }
        public IEnumerable<GetCityVM> Destination_Cities { get; set; }
    }
}
