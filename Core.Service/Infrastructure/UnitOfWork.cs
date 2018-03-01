using Core.DataAccess.Data;
using Core.DataAccess.DbEntities;
using Core.Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        private IGenericRepository<EmployeeDetail> _employeeDetailRepository;
        private IGenericRepository<EmployeeAttendance> _employeeAttendanceRepository;

        //Only Get request
        public IGenericRepository<EmployeeDetail> EmployeeDetailRepository
        {
            get
            {
                return _employeeDetailRepository = _employeeDetailRepository ?? new GenericRepository<EmployeeDetail>(_dbContext);
            }
        }
        public IGenericRepository<EmployeeAttendance> EmployeeAttendanceRepository
        {
            get
            {
                return _employeeAttendanceRepository = _employeeAttendanceRepository ?? new GenericRepository<EmployeeAttendance>(_dbContext);
            }
        }


        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
        public ApplicationDbContext GetDbContext()
        {

            return this._dbContext;
        }
    }
}
