using AzR.Core.Models;
using System.Collections.Generic;

namespace AzR.Core.Services
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
    }
}
