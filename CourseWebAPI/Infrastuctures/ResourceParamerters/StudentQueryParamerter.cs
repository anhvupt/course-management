using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.ResourceParamerters
{
    public class StudentQueryParamerter
    {
        public string SearchQuery { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string OrderBy { get; set; }
    }
}
