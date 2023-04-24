using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAPAAPI.Models
{
    public class MedicineDetail
    {
      
        //Mã Đơn thuốc
        public string ExternalPrescriptionID { get; set; }
        //Mã thuốc.
        public string ExternalMedicineID { get; set; }
        //Số lượng
        public double Amount { get; set; }
        //Cách dùng
        public string Usage { get; set; }
        //Đơn vị
        public string Unit { get; set; }
        

    }
    public class MedicineInfo
    {
        //Mã bệnh nhân
        public string PatientID { get; set; }
        //Mã lịch hẹn
        public int ScheduleID { get; set; }
        //Ngày khám / ngày booking
        public DateTime ExaminationDate { get; set; }
        //Danh sách thông tin thuốc
        public List<MedicineDetail> MedicineDetails { get; set; }
       
    }
}
