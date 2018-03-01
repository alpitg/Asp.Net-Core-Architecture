using AutoMapper;
using Core.DataAccess.DbEntities;
using Core.Service.APIResponses;
using Core.Service.Infrastructure;
using Core.Service.Interfaces;
using Core.ViewModel.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Classes
{
    public class EmployeeHrService : IEmployee
    {

        IUnitOfWork _uow;
        IMapper _mapper;

        public EmployeeHrService(
            IUnitOfWork uow,
            IMapper mapper
            )
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<APIResponse> GetAllEmployeeDetails()
        {
            APIResponse response = new APIResponse();

            try
            {
                //var employeeData = await Task.Run(() =>
                //     _uow.GetDbContext().EmployeeDetail.ToListAsync()
                //    );

                var employeeData = await _uow.GetDbContext().EmployeeDetail.ToListAsync();

                response.StatusCode = (int)HttpStatusCode.OK;
                response.Message = "Success";

            }
            catch (Exception ex)
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Message = "Operation Failed";
            }

            return response;
        }

        public Task<APIResponse> GetEmployeeAttendanceByEmployeeId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<APIResponse> AddEmployeeDetail(EmployeeDetailModel model)
        {
            APIResponse response = new APIResponse();
            try
            {
                EmployeeDetail empObj = _mapper.Map<EmployeeDetail>(model);
                await _uow.EmployeeDetailRepository.AddAsyn(empObj);
                await _uow.SaveAsync();

                response.StatusCode = (int)HttpStatusCode.OK;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Message = "Something went wrong !";

            }
            return response;
        }
    }
}
