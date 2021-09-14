using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Demo1.Models
{
    public class EmployeeRepository
    {
        static List<Employee> Employees= new List<Employee>() ;
     public EmployeeRepository()
    {
            Employee emp1 = new Employee() { Id = 1, Name = "pam" };
            Employee emp2 = new Employee() { Id = 2, Name = "Sam" };
            Employee emp3 = new Employee() { Id = 3, Name = "Tom" };
            Employees.Add(emp1);
            Employees.Add(emp2);
            Employees.Add(emp3);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return Employees;
        }
        public Employee GetEmployeeById(int id)
        {
            return Employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
