using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad3.Geometry
{
    public class Square : Descriptor
    {
        private int _Side;
        public Square(int Side)
        {
            _Side = Side;
        }

        public override string Name
        {
            get
            {
                return "Square";
            }
        }
        public override string Describe()
        {
            return base.Describe() + "geometric figure with four equal sides and four 90 degree angles.";
        }
    }
}
