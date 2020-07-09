using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class Available_option
    {
        public DateTime date { get; set; }
        public IEnumerable<int> option_ids { get; set; }
    }
}
