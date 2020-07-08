using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class PostFinalizeVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }




    public class finalizeDTO
    {
        public string Pickup_date { get; set; }
        public int Option_id { get; set; }
        public string Comment { get; set; }
    }
}
