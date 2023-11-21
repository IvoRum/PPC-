using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolnoPPC1
{
    class Doctor : Profession
    {
        private String _AmbulatoryList;
        private String _Perscription;

        public Doctor(string ambulatoryList, string perscription,string field, string specialty, string education, float salary)
        {
            _Field = field;
            _Specialty = specialty;
            _Education = education;
            _Salary = salary;
            _AmbulatoryList = ambulatoryList;
            _Perscription = perscription;
        }

        public string AmbulatoryList { get => _AmbulatoryList; set => _AmbulatoryList = value; }
        public string Perscription { get => _Perscription; set => _Perscription = value; }

        public override string ToString()
        {
            return "Profession Doctor: " + base.ToString() + " Ambulatory List: " + _AmbulatoryList + " Perscription: " + _Perscription;
        }
    }
}
