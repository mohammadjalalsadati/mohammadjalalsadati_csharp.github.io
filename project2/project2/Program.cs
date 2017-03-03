using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WindowsFormsApplication1
{
    class Shamsii
    {
        private string Year, Day, Month, Hour, Minute, Second;
        public string Date(System.DateTime Now)
        {
            PersianCalendar PerCal = new PersianCalendar();

            Year = PerCal.GetYear(Now).ToString();
            Month = PerCal.GetMonth(Now).ToString();
            Day = PerCal.GetDayOfMonth(Now).ToString();
            Day = (Day.Length == 1) ? "0" + Day : Day;
            Month = (Month.Length == 1) ? "0" + Month : Month;

            return (Year + '/' + Month + '/' + Day);
        }
        public string DateTime(System.DateTime Now)
        {
            PersianCalendar PerCal = new PersianCalendar();

            Year = PerCal.GetYear(Now).ToString();
            Month = PerCal.GetMonth(Now).ToString();
            Day = PerCal.GetDayOfMonth(Now).ToString();
            Hour = PerCal.GetHour(Now).ToString();
            Minute = PerCal.GetMinute(Now).ToString();
            Second = PerCal.GetSecond(Now).ToString();
            Day = (Day.Length == 1) ? "0" + Day : Day;
            Month = (Month.Length == 1) ? "0" + Month : Month;
            Hour = (Hour.Length == 1) ? "0" + Hour : Hour;
            Minute = (Minute.Length == 1) ? "0" + Minute : Minute;
            Second = (Second.Length == 1) ? "0" + Second : Second;


            return (Year + '/' + Month + '/' + Day + ' ' + Hour + ':' + Minute + ':' + Second);
        }


    }
}
