using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad1
{
    interface IBall
    {
        public int Players
        {
            get;
            set;
        }
        public String NameOfSport
        {
            get;
        }
        public void SportCharacteristics();
    }
}
