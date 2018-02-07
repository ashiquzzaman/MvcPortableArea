using AzR.Core.Services;
using AzR.Web.Root.Controllers;
using System.Web.Mvc;

namespace MvcPortableArea.Web.Areas.HR.Controllers
{
    public class EmployeeController : BaseController
    {
        private IEmployeeService _employee;
        private readonly string _layout;
        public EmployeeController()
        {
            _employee = new EmployeeService();
            _layout = LayoutPages["Public"];
        }

        public ActionResult Index()
        {
            var employees = _employee.GetAll();

            return View("Index", _layout, employees);
        }

    }
}
