using AzR.Core.Models;
using System.Collections.Generic;

namespace AzR.Core.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
    }
}
