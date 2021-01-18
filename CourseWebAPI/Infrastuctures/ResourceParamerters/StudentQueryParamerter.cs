using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebAPI.ResourceParamerters
{
    public class StudentQueryParamerter
    {
        public string SearchQuery { get; set; }
        [Range(0, int.MaxValue)]
        public int PageSize { get; set; } = 10;
        [Range(0, int.MaxValue)]
        public int PageIndex { get; set; } = 1;
        public string OrderBy { get; set; } = "name";
    }
}
