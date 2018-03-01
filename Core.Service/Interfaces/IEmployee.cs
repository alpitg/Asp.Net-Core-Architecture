using Core.Service.APIResponses;
using Core.ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Interfaces
{
    public interface IEmployee
    {
        Task<APIResponse> GetAllEmployeeDetails();
        Task<APIResponse> GetEmployeeAttendanceByEmployeeId(int id);
        Task<APIResponse> AddEmployeeDetail(EmployeeDetailModel model);
    }
}
