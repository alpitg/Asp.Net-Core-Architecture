using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModel.Model
{
    public class EmployeeAttendanceModel
    {
        //public long EmployeeAttendanceId { get; set; }
        public long? EmployeeDetailId { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public string TotalWorkTime { get; set; }
        
    }
}
