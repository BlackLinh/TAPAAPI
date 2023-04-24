using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAPAAPI.Models
{
    public class Login
    {
        [JsonProperty("user")]
        public UserLogin UserLogin { get; set; }
        public string Access_Token { get; set; }
        public string Token_Type { get; set; }
        public bool Status { get; set; }
    }
}
