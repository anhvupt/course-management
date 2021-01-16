using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Extentions
{
    public static class EnumExtention
    {
        public static T ToEnum<T>(this string value, T defaultValue)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return defaultValue;
                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch (Exception e) { return defaultValue; }
        }
    }
}
