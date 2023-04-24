using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAPA_API_NEW.Models
{
    public class Meta
    {
        [JsonProperty("status")]
        public bool Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; } 
    }
    public class AppoinmentInfo
    {
        [JsonProperty("patient_id")]
        public int PatientID { get; set; }
        [JsonProperty("external_patient_id")]
        public int? ExternalPatientID { get; set; }
        [JsonProperty("patient_name")]
        public string PatientName { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("schedule_id")]
        public int ScheduleID { get; set; }
        [JsonProperty("schedule_time")]
        public DateTime ScheduleTime { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("number_order")]
        public int NumberOrder { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("district")]
        public string District { get; set; }
        [JsonProperty("ward")]
        public string Ward { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("doctor_id")]
        public int DoctorID { get; set; }
        [JsonProperty("doctor_name")]
        public string DoctorName { get; set; }
        [JsonProperty("prefix_order_num")]
        public string PrefixOrderNum { get; set; }
    }
    public class Result
    {
        public Meta meta { get; set; }
        [JsonProperty("data")]
        public List<AppoinmentInfo> listAppoiment { get; set; }
    }
    public class Appointment
    {
        public Result result { get; set; }
    }
}
