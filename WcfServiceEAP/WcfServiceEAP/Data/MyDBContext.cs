using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceEAP.Entity;

namespace WcfServiceEAP.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}