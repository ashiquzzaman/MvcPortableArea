using AzR.Core.Models;
using AzR.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AzR.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> _employee;
        public EmployeeService()
        {
            _employee = new Repository<Employee>();
        }
        public List<Employee> GetAll()
        {
            return _employee.All().ToList();
        }

    }
}
