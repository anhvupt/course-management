using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class UserResponseModel
    {
        public string UserName { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
    }
}
