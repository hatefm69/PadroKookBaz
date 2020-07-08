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

    public class Option
    {
        public int Option_id { get; set; }
        public string Title { get; set; }
        public int From { get; set; }
        public int To { get; set; }
    }
    public class Available_option
    {
        public DateTime date { get; set; }
        public IEnumerable<int> option_ids { get; set; }
    }
}
