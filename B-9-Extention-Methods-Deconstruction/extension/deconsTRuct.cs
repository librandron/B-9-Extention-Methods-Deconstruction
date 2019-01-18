using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.extension
{
    public static class deconsTRuct
    {
        public static void Deconstruct(this DateTime p, out int year_1, out int month_1, out int day_1, out int hour_1, out int minute_1, out int second_1)
        {
            year_1 = DateTime.Now.Year;
            month_1 = DateTime.Now.Month;
            day_1 = DateTime.Now.Day;
            hour_1 = DateTime.Now.Hour;
            minute_1 = DateTime.Now.Minute;
            second_1 = DateTime.Now.Second;
        }
    }
}
