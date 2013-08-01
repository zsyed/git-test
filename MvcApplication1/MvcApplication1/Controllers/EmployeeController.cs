using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        [HttpGet]
        public ActionResult Create(int DepartmentId)
        {
            var model = new CreateEmployeeViewModel();

            model.DepartmentId = DepartmentId;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateEmployeeViewModel view)
        {
            if (ModelState.IsValid)
            {

            }
            return View(view);
        }

    }
}
