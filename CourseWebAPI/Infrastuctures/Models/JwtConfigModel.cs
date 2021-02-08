using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class JwtConfigModel
    {
        public static string ConfigKey => "Jwt";
        public string Key { get; private set; }
        public string Issuer { get; private set; }
        public string Audience { get; private set; }
        public DateTime Expires { get; private set; }

        public static JwtConfigModel ReadFrom(IConfiguration config)
        {
            string key = config.GetValue<string>($"{ConfigKey}:Key");
            string issuer = config.GetValue<string>($"{ConfigKey}:Issuer");
            string audience = config.GetValue<string>($"{ConfigKey}:Audience");
            string expires = config.GetValue<string>($"{ConfigKey}:Expires");
            bool succeedParse = double.TryParse(expires, out double expiredMinutes);
            if (!succeedParse) throw new ArgumentOutOfRangeException();
            return new JwtConfigModel
            {
                Key = key,
                Issuer = issuer,
                Audience = audience,
                Expires = DateTime.Now.AddMinutes(expiredMinutes)
            };
        } 
    }
}
