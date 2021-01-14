using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static CourseWebAPI.Infrastuctures.Helpers.DateTimeHandler;

namespace CourseWebAPI.Infrastuctures.Helpers
{
    public static class DateTimeExtention
    {
        public static string GetDurationToNow(this DateTime date)
        => TimeDiff(date, DateTime.Now);
    }
    public class DateTimeHandler
    {
        public enum Language
        {
            VIE = 1, //Vietnamese
            ENG = 2  //English    
        }
        public class DateUnits
        {
            private string days;
            public string Days { get { return days; } }
            private string hours;
            public string Hours { get { return hours; } }
            private string minutes;
            public string Minutes { get { return minutes; } }
            private string seconds;
            public string Seconds { get { return seconds; } }
            public DateUnits()
            {

            }
            public DateUnits(Language language)
            {
                switch (language)
                {
                    case Language.VIE:
                        VIEContructor();
                        break;
                    case Language.ENG:
                        ENGContructor();
                        break;
                    default:
                        ENGContructor();
                        break;
                }
            }
            private void VIEContructor()
            {
                days = "ngày";
                hours = "giờ";
                minutes = "phút";
                seconds = "giây";
            }
            private void ENGContructor()
            {
                days = "days";
                hours = "hours";
                minutes = "minutes";
                seconds = "seconds";
            }
        }
        /// <summary>
        /// Calculate a period and format to string
        /// </summary>
        public class DateStringFormater
        {
            public int Days { get; set; }
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            /// <summary>
            /// Unit type (languages)
            /// </summary>
            public DateUnits Unit { get; set; }
            public static int NumberOfUnit => 4;
            public DateStringFormater(Language language = Language.ENG)
            {
                Days = 0;
                Hours = 0;
                Minutes = 0;
                Seconds = 0;
                Unit = new DateUnits(language);
            }
            /// <summary>
            /// Gets 2 units to string
            /// </summary>
            /// <returns>string</returns>
            /// <example>1 day 1 month (if unit type is ENG)</example>
            public override string ToString()
            {
                return GetUnits(2);
            }
            /// <summary>
            /// Gets for a specifed number of unit
            /// </summary>
            /// <param name="numOfUnit"></param>
            /// <example>1 day 1 month 1 minute (if unit type is ENG, numOfUnit = 3)</example>
            /// <returns>string</returns>
            public string GetUnits(int numOfUnit)
            {
                if (NumberOfUnit <= 0 || numOfUnit > DateStringFormater.NumberOfUnit)
                    throw new ArgumentOutOfRangeException(nameof(numOfUnit));
                string result = "";
                int counter = 1;
                if (Days > 0)
                {
                    result += GetDay();
                    if (counter == numOfUnit) return result;
                    else counter++;
                }
                if (Hours > 0)
                {
                    result += " " + GetHour();
                    if (counter == numOfUnit) return result;
                    else counter++;
                }
                if (Minutes > 0)
                {
                    result += " " + GetMinutes();
                    if (counter == numOfUnit) return result;
                    else counter++;
                }
                if (Seconds >= 0) //min unit
                {
                    result += " " + GetSecond();
                    if (counter == numOfUnit) return result;
                    else counter++;
                }
                return result;
            }
            public string GetFull()
            {
                string result = "";
                if (Days > 0) result += GetDay() + " ";
                if (Hours > 0) result += GetHour() + " ";
                if (Minutes > 0) result += GetMinutes() + " ";
                if (Seconds > 0) result += GetSecond() + " " + Unit.Seconds;
                return result;
            }
            public void Calculate()
            {
                if (Seconds < 60) return;
                else
                {
                    Minutes += Seconds / 60;
                    Seconds = Seconds % 60;
                    if (Minutes < 60) return;
                    else
                    {
                        Hours += Minutes / 60;
                        Minutes = Minutes % 60;
                        if (Hours < 24) return;
                        else
                        {
                            Days += Hours / 24;
                            Hours = Hours % 24;
                        }
                    }
                }
            }
            public string GetDay() => Days + " " + Unit.Days;
            public string GetHour() => Hours + " " + Unit.Hours;
            public string GetMinutes() => Minutes + " " + Unit.Minutes;
            public string GetSecond() => Seconds + " " + Unit.Seconds;
        }
        /// <summary>
        /// Calculate time difference from 2 timestamps
        /// and converts it to string (include unit)
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="language"></param>
        /// <returns>string</returns>
        public static string TimeDiff(DateTime start, DateTime end, Language language = Language.ENG)
        {
            try
            {
                int secs = SecDiff(start, end);
                DateStringFormater result = new DateStringFormater(language);
                result.Seconds = secs;
                result.Calculate();
                return result.ToString();
            }
            catch (Exception)
            {
                return "Infinity";
            }
        }
        public static int SecDiff(DateTime start, DateTime end) => Math.Abs((int)(start - end).TotalSeconds);
        public static TimeSpan StartTimeOfDay = new TimeSpan(0, 0, 0);
        public static TimeSpan EndTimeOfDay = new TimeSpan(23, 59, 59);
        public static DateTime TodayStart => GetStartDay(DateTime.Now);
        public static DateTime TodayEnd => GetEndDay(DateTime.Now);
        public static DateTime GetStartDay(DateTime reqDay) => reqDay.Date + StartTimeOfDay;
        public static DateTime GetEndDay(DateTime reqDay) => reqDay.Date + EndTimeOfDay;
        public static void MoveToStartDay(ref DateTime reqDay) => reqDay = reqDay.Date + StartTimeOfDay;
        public static void MoveToEndDay(ref DateTime reqDay) => reqDay = reqDay.Date + EndTimeOfDay;

    }
}

