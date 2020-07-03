using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.Podro
{
    public class InfoCityVM
    {
        public IEnumerable<GetCityVM> Source_Cities { get; set; }
        public IEnumerable<GetCityVM>  Destination_Cities { get; set; }
    }
    public class GetCityVM
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
