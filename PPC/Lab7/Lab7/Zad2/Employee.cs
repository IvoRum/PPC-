using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom7.Zad2
{
    class Employee : IComparable
    {
        private string _Name;
        private int _Level;
        private DateTime _HiringDate;

        public String Name
        {
            get
            {
                return _Name;
            }
        }

        public int Level
        {
            get
            {
                return _Level;
            }
        }

        public Employee(String Name,int Level, DateTime HiringDate)
        {
            _Name = Name;
            _Level = Level;
            _HiringDate = HiringDate;
        }

        public int CompareTo(object obj)
        {
            Employee employee = (Employee)obj;
            return _HiringDate.CompareTo(employee._HiringDate);
        }

        public override string ToString()
        {
            return "Name " + Name + " Level " + Level.ToString() + " Hiring date " + _HiringDate.ToString();
        }
    }
}
