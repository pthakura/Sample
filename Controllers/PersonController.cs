using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySampleService.Proxy;
using MySample.Model;
namespace MySample.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public ActionResult Index()
        {
            return View("AddPerson");
        }

        [HttpPost]
        public ActionResult AddPerson(Person model) {
            if (ModelState.IsValid) {
                new PersonPort().SavePerson(model);
            }
            return View();
        }
	}
}