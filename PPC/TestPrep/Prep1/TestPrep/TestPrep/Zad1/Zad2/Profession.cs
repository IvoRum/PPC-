using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolnoPPC1
{
    abstract class Profession
    {
        protected String _Field;
        protected String _Specialty;
        protected String _Education;
        protected float _Salary;

        public string Field { get => _Field; set => _Field = value; }
        public string Specialty { get => _Specialty; set => _Specialty = value; }
        public string Education { get => _Education; set => _Education = value; }
        public float Salary { get => _Salary; set => _Salary = value; }

        public float calculateSalaryForHours(int Hours)
        {
            return Salary / Hours;
        }

        public override string ToString()
        {
            return "Field: " + _Field + " Specialty: " + _Specialty + " Education: " + _Education + " Salary: " + _Salary.ToString();
        }
    }
}
