using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationEAP.ServiceEAP;

namespace WebApplicationEAP.Controllers
{
    public class EmployeeController : Controller
    {
        static ServiceEAP.Service1Client clientservice = new ServiceEAP.Service1Client();
        // GET: Employee     

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Save(Employee employee)
        {
            clientservice.Create(employee);
            return Redirect("SearchEmployee");
        }

        public ActionResult SearchEmployee(string search)
        {           
            return View(clientservice.Search(search));
        }


    }
}