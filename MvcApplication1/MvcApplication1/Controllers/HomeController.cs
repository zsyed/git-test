using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using MvcApplication1.Infrastructure;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db;

        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            //var depts = _db.Departments;

            var dept = new Department { Name = "Sales" };
            var dept1 = new Department { Name = "Engineering" };

            var depts = new List<Department>();
            depts.Add(dept);
            depts.Add(dept1);


            return View(depts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
