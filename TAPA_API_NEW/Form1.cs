using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;
using System.Text;
using TAPA_API_NEW.Models;
using System.Net.Mime;
using System.Net;
using System.Net.Http;

namespace TAPA_API_NEW
{
    public partial class Form1 : Form
    {
        private const string apiUrl = @"http://127.0.0.1:8000/api/";// Lên server production ID sẽ khác
        private const int clinic_id = 6; // Lên server production ID sẽ khác
        private string loginToken = string.Empty;
        public Form1()
        {
            InitializeComponent();
            btnGetToken.Enabled = string.IsNullOrEmpty(txtToken.Text);
            btnGetAppointment.Enabled = !string.IsNullOrEmpty(txtToken.Text);
            btnUpdateInfo.Enabled = dgvAppointment.RowCount > 0;
        }
        async Task<Login?> GetLoginToken()
        {
            string apiLoginEndpoint = apiUrl + "login";
            using (HttpClient client = new HttpClient())
            {
                // Tạo một dictionary chứa các thông tin đăng nhập
                var userInfoLogin = new Dictionary<string, string>
                {
                    { "email", "hisbskhuong@tapavn.com" },
                    { "password", "hisbskhuong@123"}
                };
                // Đóng gói các thông tin đăng nhập vào trong một HttpContent object
                var content = new FormUrlEncodedContent(userInfoLogin);
                // Gửi request POST để đăng nhập
                var response = await client.PostAsync(apiLoginEndpoint, content);

                // Đọc nội dung trả về từ server
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Login>(responseString);
            }
        }
        public class AppointmentRequest
        {
            public int clinic_id { get; set; }
            public DateTime date_request { get; set; }
            public int is_get { get; set; }
        }

        private async Task<Appointment?> GetAppointment()
        {
            string apiAppointmentEndpoint = apiUrl + "appointments/getappointment";
            // string jsonString = "{clinic_id : " + clinic_id+ ",date_request:" +dtpDateAppointment.Value.ToString("dd/MM/yyyy") + ",is_get:"+0+"}";
            AppointmentRequest appointmentRequest = new AppointmentRequest()
            {
                clinic_id = clinic_id,
                date_request = dtpDateAppointment.Value,
                is_get = 0
            };

            string json = JsonConvert.SerializeObject(appointmentRequest);
            var content = new StringContent(json, System.Text.Encoding.UTF8, MediaTypeNames.Application.Json);
            var request = new HttpRequestMessage(HttpMethod.Get, apiAppointmentEndpoint)
            {
                Content = content
            };
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", txtToken.Text.Trim());
                var response = await client.SendAsync(request);
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Appointment>(responseString);
            }
        }
        private async void btnGetAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment appointment = await GetAppointment();
                dgvAppointment.DataSource = appointment.result.listAppoiment;
                btnUpdateInfo.Enabled = dgvAppointment.RowCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnGetToken_Click(object sender, EventArgs e)
        {
            try
            {
                var loginInfo = await GetLoginToken();
                if (loginInfo != null && loginInfo.Status)
                {
                    loginToken = loginInfo.Access_Token;
                    txtToken.Text = loginToken;
                    btnGetToken.Enabled = string.IsNullOrEmpty(txtToken.Text);
                    btnGetAppointment.Enabled = !string.IsNullOrEmpty(txtToken.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public async Task UpdatePatientInfo(AppoinmentInfo appoinmentInfo)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiAppointmentEndpoint = apiUrl + "appointments/updateappointment";
                string param = "{'clinic_id' : " + clinic_id + ",'is_get' : 1 ,'schedule_id' : " + appoinmentInfo.ScheduleID + ",'patient_id' : " + appoinmentInfo.PatientID + ",'external_patient_id': " + appoinmentInfo.ExternalPatientID + "}";
                param = param.Replace("'", "\"");
                var content = new StringContent(param, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", txtToken.Text.Trim());
                var response = await client.PostAsync(apiAppointmentEndpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
        }
        private async void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvAppointment.Rows.Count > 0)
                {
                    var listRow = dgvAppointment.DataSource as List<AppoinmentInfo>;
                    if (listRow != null)
                    {
                        foreach (var item in listRow)
                        {
                            await UpdatePatientInfo(item);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUploadMedicine_Click(object sender, EventArgs e)
        {
            try
            {

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}