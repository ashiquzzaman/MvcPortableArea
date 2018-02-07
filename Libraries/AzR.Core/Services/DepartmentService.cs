using AzR.Core.Models;
using AzR.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AzR.Core.Services
{
    public class DepartmentService : IDepartmentService
    {

        private IRepository<Department> _dbContext;

        public DepartmentService()
        {
            _dbContext = new Repository<Department>();
        }
        public List<Department> GetAll()
        {
            return _dbContext.All().ToList();
        }


    }
}
