using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceEAP.Entity
{
    [DataContract]
    public class Employee
    {
        [Key]
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public string Deparment { get; set; }

    }
}