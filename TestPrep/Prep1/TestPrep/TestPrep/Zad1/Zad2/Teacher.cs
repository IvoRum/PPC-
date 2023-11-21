using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolnoPPC1
{
    class Teacher : Profession
    {
        private String _Class;
        private String _Subject;


        public Teacher(string @class, string subject,string field, string specialty, string education, float salary)
        {
            _Field = field;
            _Specialty = specialty;
            _Education = education;
            _Salary = salary;
            _Class = @class;
            _Subject = subject;
        }

        public string Class { get => _Class; set => _Class = value; }
        public string Subject { get => _Subject; set => _Subject = value; }

        public override string ToString()
        {
            return "Profession Teacher: " + base.ToString() + " Class: " + _Class + " Subject: " + _Subject;
        }
    }
}
