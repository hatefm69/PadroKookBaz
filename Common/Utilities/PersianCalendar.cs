using System;
using System.Collections.Generic;
using sc=System.Globalization;
using System.Text;

namespace Common.Utilities
{
  public static class PersianCalendar
    {
        public static string ToPersian( this DateTime dt)
        {
            var pc = new sc.PersianCalendar();

            return $"{pc.GetYear(dt).ToString("0000")}/{pc.GetMonth(dt).ToString("00")}/{pc.GetDayOfMonth(dt).ToString("00")}";           
        }
    }
}
