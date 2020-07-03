using Entities;
using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public class InvGdsPhoto : BaseEntity
    {
        public int InvGdsSi { get; set; }
        public byte[] InvGdsPhotoImage { get; set; }
        public byte[] InvGdsPhotoIcon { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
