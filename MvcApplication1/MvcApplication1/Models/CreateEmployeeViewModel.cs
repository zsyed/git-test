using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class CreateEmployeeViewModel
    {
        [Required]
        public virtual string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime HireDate { get; set; }

        [HiddenInput(DisplayValue = false)]
        public virtual int DepartmentId { get; set; }
    }
}