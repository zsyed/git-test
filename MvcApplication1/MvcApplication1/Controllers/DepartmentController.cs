using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;

namespace MvcApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/

        private readonly IDepartmentDataSource _db;

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Detail(int id)
        {
            var model = _db.Departments.Single(dept => dept.Id == id);
            return View(model);
        }

    }
}
