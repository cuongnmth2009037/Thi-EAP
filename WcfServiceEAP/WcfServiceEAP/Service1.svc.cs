using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceEAP.Data;
using WcfServiceEAP.Entity;

namespace WcfServiceEAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private MyDBContext dBContext = new MyDBContext();
        public Employee Create(Employee employee)
        {
            dBContext.Employees.Add(employee);
            dBContext.SaveChanges();
            return employee;
        }



        public List<Employee> Search(string deparment)
        {
            var employees = from s in dBContext.Employees
                            select s;
            if (!String.IsNullOrEmpty(deparment))
            {
                employees = employees.Where(s => s.Deparment.Contains(deparment));
            }
            return employees.ToList();
        }
    }
}
