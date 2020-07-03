using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class MemberShip
    {
        public int MemberShipId { get; set; }
        public int SalIntrmdSi { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }

        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
    }
}
