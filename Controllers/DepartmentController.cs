using System;
using System.Web.Mvc;
using MySample.Model;
using MySampleService.Proxy;
namespace MySample.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/
        public ActionResult Index()
        {
            return View("AddDepartment");
        }

        [HttpPost]
        public ActionResult AddDepartment(Department model) {
            if (ModelState.IsValid)
            {
                model.StartDate = DateTime.Now;
                if (new DepartmentPort().SaveDepartment(model) > 0) {
                    ViewBag.SuccessMessage = "Department details saved";
                }
            }
            return View("AddDepartment");
        }
	}
}