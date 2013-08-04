using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public EmployeeController(IDepartmentDataSource db)
        {
            _db = db;
        }

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
                var dept = _db.Departments.Single(d => d.Id == view.DepartmentId);
                var employee = new Employee();
                employee.Name = view.Name;
                employee.HireDate = view.HireDate;
                dept.Employees.Add(employee);

                _db.Save();

                return RedirectToAction("detail", "department", new { id = view.DepartmentId });
            }
            return View(view);
        }

    }
}
