using AzR.Core.Services;
using AzR.Web.Root.Controllers;
using System.Web.Mvc;

namespace MvcPortableArea.Web.Areas.HR.Controllers
{
    public class DepartmentController : BaseController
    {
        private IDepartmentService _dept;
        private readonly string _layout;
        public DepartmentController()
        {
            _dept = new DepartmentService();
            _layout = LayoutPages["Public"];
        }

        public ActionResult Index()
        {
            var depts = _dept.GetAll();
            return View("Index", _layout, depts);
        }

    }
}
