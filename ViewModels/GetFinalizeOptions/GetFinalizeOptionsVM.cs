using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class GetFinalizeOptionsVM
    {
        public string Order_Id { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public IEnumerable<Available_option> Available_Options { get; set; }
    }
}
