using Core.DataAccess.Data;
using Core.DataAccess.DbEntities;
using Core.Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Infrastructure
{
    public interface IUnitOfWork
    {
        IGenericRepository<EmployeeDetail> EmployeeDetailRepository { get; }
        IGenericRepository<EmployeeAttendance> EmployeeAttendanceRepository { get; }
      

        void Save();
        Task<int> SaveAsync();
        ApplicationDbContext GetDbContext();

    }
}
