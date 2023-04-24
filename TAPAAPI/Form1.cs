using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using TAPAAPI.Models;

namespace TAPAAPI
{
    public partial class Form1 : Form
    {
        private const string baseUrlAPI = "http://his-api.tapavn.com/api/"; // url lên production sẽ thay đổi
        private const string clinicID = "5"; // ID phòng khám, có thể thay đổi khi lên production
        private const string email = "hisbskhuong@tapavn.com";
        private const string password = "hisbskhuong@123";
        private enum IsGet
        {
            NotGet = 0,//Chưa get
            Get = 1, //Đã Get
            All = 2 , //Lấy toàn bộ
        }
        public Form1()
        {
            InitializeComponent();
            cboGet.DataSource = Enum.GetValues(typeof(IsGet));
        }
        /// <summary>
        /// Hàm lấy token
        /// </summary>
        /// <returns></returns>
        public Login GetLoginInfo()
        {
            Login userLogin = null;
            string param = "{" + "'email'" + ":" + "'" + email + "'" + "," + "'password'" + ":" + "'" + password + "'" + "}";
            param = param.Replace("'", "\"");
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("content-type", "application/json");
                string response = Encoding.UTF8.GetString(client.UploadData(baseUrlAPI + "/login", "POST", Encoding.UTF8.GetBytes(param)));
                userLogin = JsonConvert.DeserializeObject<Login>(response);
            }
            return userLogin;
        }
        public Login GetLoginInfoV2()
        {

            // Add query parameters to the URL
            string endpoint = "login";
            string requestUrl = baseUrlAPI + endpoint;

            // Create a new HttpWebRequest object
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);

            // Set the HTTP method to POST
            request.Method = "POST";

            request.ContentType = "application/json";
            var dataLogin = new { email = email, password = password };
            var dataLoginjson = JsonConvert.SerializeObject(dataLogin);
            request.ContentLength = dataLoginjson.Length;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(dataLoginjson);
            }
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Lấy mã trạng thái HTTP và nội dung phản hồi
                HttpStatusCode statusCode = response.StatusCode;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                string responseText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Login>(responseText);
            }
        }


        public Appointment GetListAppointment(string clinicID , string dateRequest , string isGet)
        {
            Appointment responseData = null;
            Login loginInfo = GetLoginInfo();
            if(loginInfo!=null)
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("content-type", "application/json");
                    client.Headers[HttpRequestHeader.Authorization] = string.Format("{0} {1}", "Bearer", loginInfo.Access_Token);
                    client.QueryString.Add("clinic_id", clinicID);
                    client.QueryString.Add("date_request", dateRequest);
                    client.QueryString.Add("is_get", isGet);
                    string response = client.DownloadString(baseUrlAPI + "/appointments/getappointment");
                    responseData = JsonConvert.DeserializeObject<Appointment>(response);
                }
            }
            return responseData;
        }
        private void btnGetAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                var login = GetLoginInfoV2();
                dgvAppoiment.DataSource = null;
                int isget = (int)Enum.Parse(typeof(IsGet), cboGet.SelectedValue.ToString());
                Appointment listAppoiment =  GetListAppointment(clinicID, dtpAppointment.Value.ToString("yyyy/MM/dd"), isget.ToString());
                if (listAppoiment.result.listAppoiment != null)
                {
                    dgvAppoiment.DataSource = listAppoiment.result.listAppoiment;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdatePatientInfo(AppoinmentInfo appoinmentInfo)
        {
            Login loginInfo = GetLoginInfo();
            if (loginInfo != null)
            {
                string param = "{'clinic_id' : "+ clinicID + ",'is_get' : 1 ,'schedule_id' : "+ appoinmentInfo.ScheduleID + ",'patient_id' : "+ appoinmentInfo.PatientID + ",'external_patient_id': "+ appoinmentInfo.ExternalPatientID + "}";
                param = param.Replace("'","\"");
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("content-type", "application/json");
                    client.Headers[HttpRequestHeader.Authorization] = string.Format("{0} {1}", "Bearer", loginInfo.Access_Token);
                    string response = Encoding.UTF8.GetString(client.UploadData(baseUrlAPI + "/appointments/updateappointment", "POST", Encoding.UTF8.GetBytes(param)));
                    var json = JsonConvert.DeserializeObject<Appointment>(response);
                    int isget = (int)Enum.Parse(typeof(IsGet), cboGet.SelectedValue.ToString());
                    Appointment listAppoiment = GetListAppointment(clinicID, dtpAppointment.Value.ToString("yyyy/MM/dd"), isget.ToString());
                    if (listAppoiment.result.listAppoiment != null)
                    {
                        dgvAppoiment.DataSource = listAppoiment.result.listAppoiment;
                    }
                }
            }
        }
        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvAppoiment.Rows.Count > 0)
                {
                    var listRow = dgvAppoiment.DataSource as List<AppoinmentInfo>;
                    if(listRow != null)
                    {
                        foreach (var item in listRow)
                        {
                            UpdatePatientInfo(item);
                        }
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateMedicineInfo(MedicineInfo medicineInfo)
        {
            //Login loginInfo = GetLoginInfo();
            //if (loginInfo != null)
            //{
            //    string param = "{'schedule_id' : " + medicineInfo.ScheduleID + ",'external_prescription_id' : " + "'"+medicineInfo .ExternalPrescriptionID +"'" + " ,'external_medicine_id' : " + "'" + medicineInfo.ExternalMedicineID + "'" + ",'amount' : " + medicineInfo.Amount + ",'usage': " + "'" + medicineInfo.Usage + "'" + ",'unit': " + "'" + medicineInfo.Unit + "'" + "}";
            //    param = param.Replace("'", "\"");
            //    using (WebClient client = new WebClient())
            //    {
            //        client.Headers.Add("content-type", "application/json");
            //        client.Headers[HttpRequestHeader.Authorization] = string.Format("{0} {1}", "Bearer", loginInfo.Access_Token);
            //        string response = Encoding.UTF8.GetString(client.UploadData(baseUrlAPI + "/appointments/updateappointment", "POST", Encoding.UTF8.GetBytes(param)));
            //        var json = JsonConvert.DeserializeObject<Appointment>(response);
            //        int isget = (int)Enum.Parse(typeof(IsGet), cboGet.SelectedValue.ToString());
            //        Appointment listAppoiment = GetListAppointment(clinicID, dtpAppointment.Value.ToString("yyyy/MM/dd"), isget.ToString());
            //        if (listAppoiment.result.listAppoiment != null)
            //        {
            //            dgvAppoiment.DataSource = listAppoiment.result.listAppoiment;
            //        }
            //    }
            //}
        }
        private void btnSaveMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvAppoiment.Rows.Count > 0)
                {
                    //dgvAppoiment.DataSource = null;
                    //List<MedicineInfo> _listMedicine = new List<MedicineInfo>();
                    ////Thuốc 1
                    //_listMedicine.Add(new MedicineInfo()
                    //{
                    //    ScheduleID = 155,
                    //    MedicineDetails = new List<MedicineDetail>
                    //});
                    ////Thuốc 2
                    //_listMedicine.Add(new MedicineInfo()
                    //{
                    //    ScheduleID = 155,
                    //    ExternalPrescriptionID = "200",
                    //    ExternalMedicineID = "301",
                    //    Amount = 1.5,
                    //    Usage = "Uống sáng - tối",
                    //    Unit = "Viên"
                    //});
                    //_listMedicine.Add(new MedicineInfo()
                    //{
                    //    ScheduleID = 155,
                    //    ExternalPrescriptionID = "202",
                    //    ExternalMedicineID = "302",
                    //    Amount = 1,
                    //    Usage = "Bôi sáng - tối",
                    //    Unit = "Chai"
                    //});
                    //Xử lý call API để update đơn thuốc
                    //foreach (var item in _listMedicine)
                    //{
                    //    UpdateMedicineInfo(item);
                    //}
                }    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
