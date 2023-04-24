using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAPA_API_NEW.Models
{
    public class UserLogin
    {
        [JsonProperty("id")]
        public int UserId { get; set; }
        [JsonProperty("name")]
        public string UserName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("email_verified_at")]
        public DateTime? EmailVerifiedAt { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("login_date")]
        public DateTime? LoginDate { get; set; }
        [JsonProperty("birthday")]
        public DateTime? BirthDay { get; set; }
        [JsonProperty("clinic_id")]
        public int ClinicID { get; set; }
    }
}
