using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom7.Zad2
{
    class EmployeeLIst
    {
        private List<Employee> _Employees;
        public EmployeeLIst()
        {
            _Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _Employees.Remove(employee);
        }

        public Employee FindEmployee(String EmployeeName)
        {
            foreach(Employee employee in _Employees)
            {
                if(employee.Name == EmployeeName)
                {
                    return employee;
                }
            }
            return null;
        }

        public String HighestLevelEmployee()
        {
            Employee res = null;
            foreach (Employee employee in _Employees)
            {
                if (res == null)
                {
                    res = employee;
                } else if(res.Level < employee.Level)
                {
                    res = employee;
                }
            }
            return res == null? null:res.Name;
        }

        public void PrintSortedList()
        {
            _Employees.Sort();
            foreach(Employee employee in _Employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
