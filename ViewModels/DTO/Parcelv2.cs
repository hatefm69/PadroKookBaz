using Entities.Padro;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.AutoMapepr;

namespace ViewModels
{
    public class Parcelv2 : BaseDto<Parcelv2, Parcel>
    {
        //public int id { get; set; }
        public int? Weight { get; set; }
        public decimal? Value { get; set; }
        public string Content { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Depth { get; set; }
    }
}
