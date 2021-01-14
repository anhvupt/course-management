using System;
using System.Collections.Generic;
using System.Text;

namespace CourseData.Infrastructures.Extentions
{
    public static class ValidationExtention
    {
        public static bool IsValidId(this int id) => id >= 0;

    }
}
