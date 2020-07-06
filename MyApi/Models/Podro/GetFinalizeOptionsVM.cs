using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.Podro
{
    public class PostFinalizeVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class GetFinalizeOptionsVM
    {
        public string Order_Id { get; set; }
        public IEnumerable<Option> Options { get; set; }
        public IEnumerable<Available_option>  Available_Options   { get; set; }
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


    public class finalizeDTO
    {
        public string Pickup_date { get; set; }
        public int Option_id { get; set; }
        public string Comment { get; set; }
    }
}
