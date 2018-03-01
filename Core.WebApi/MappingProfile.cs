using AutoMapper;
using Core.DataAccess.DbEntities;
using Core.ViewModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
            : this("MyProfile")
        {
        }
        protected MappingProfile(string profileName) : base(profileName)
        {
            CreateMap<EmployeeDetail, EmployeeDetailModel>();
            CreateMap<EmployeeAttendance, EmployeeAttendanceModel>();
        }
    }

}