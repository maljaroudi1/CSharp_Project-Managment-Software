using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAvloniaPr
{
    public class EmployeeDatabase
    {
        public List<Employee> employees { get; set; }

        public EmployeeDatabase()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public void RemoveEmployee(Employee e)
        {
            employees.Remove(e);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
