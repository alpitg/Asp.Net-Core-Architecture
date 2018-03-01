using Core.Service.APIResponses;
using Core.Service.Interfaces;
using Core.ViewModel.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Core.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee/[Action]")]
    public class EmployeeController : Controller
    {
        private IEmployee _iEmployee;

        public EmployeeController(
           IEmployee iEmployee
            )
        {
            _iEmployee = iEmployee;
        }


        [HttpGet]
        public async Task<object> GetAllEmployeeDetails()
        {
            APIResponse apiresponse = await _iEmployee.GetAllEmployeeDetails();
            return apiresponse;
        }

        [HttpPost]
        public async Task<APIResponse> AddEmployeeDetail(EmployeeDetailModel model)
        {
            APIResponse apiresponse = await _iEmployee.AddEmployeeDetail(model);
            return apiresponse;
        }

    }
}
