using Core.ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service.APIResponses
{
    public class APIResponse
    {
        public APIResponse()
        {
            data = new Data();
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public Data data { get; set; }
    }
    public partial class Data
    {
        public IList<EmployeeDetailModel> EmployeeDetail { get; set; }
    }

}
