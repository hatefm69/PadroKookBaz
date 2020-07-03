using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwTransDriver
    {
        public int TransDriverSi { get; set; }
        public string TransDriverFname { get; set; }
        public string TransDriverLname { get; set; }
        public string TransDriverCarTag { get; set; }
        public string TransDriverFullName { get; set; }
        public string TransDriverTel { get; set; }
        public string TransDriverAddress { get; set; }
    }
}
