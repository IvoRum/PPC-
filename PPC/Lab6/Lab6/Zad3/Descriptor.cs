using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad3.Geometry
{
    public abstract class Descriptor
    {
        public abstract String Name
        {
            get;
        }
        public virtual String Describe() {
            return Name + " Characteristics \n" + "Name: " + Name + "\nDescription: A " + Name + " is a ";
        }
    }
}
