using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModel.Model
{
    public class EmployeeDetailModel
    {
        public long? EmployeeDetailId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
