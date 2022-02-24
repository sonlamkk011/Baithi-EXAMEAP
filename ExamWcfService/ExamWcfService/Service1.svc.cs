using ExamWcfService.Data;
using ExamWcfService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExamWcfService
{
        public class Service1 : IService1
    {
        private DbEmployee db = new DbEmployee();
        public Employee CreateEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }
        public List<Employee> ListEmployee(string department)
        {
            var students = from s in db.Employees
                           select s;
            if (!String.IsNullOrEmpty(department))
            {
                students = students.Where(s => s.Department.Contains(department));
            }
            return students.ToList();
        }
    }
}
