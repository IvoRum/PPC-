using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad3.Geometry
{
    class Rectangle : Descriptor
    {
        private int _SideA;
        private int _SideB;

        public Rectangle(int SideA, int SideB)
        {
            _SideA = SideA;
            _SideB = SideB;
        }
        public override string Name
        {
            get
            {
                return "Rectangle";
            }
        }

        public override string Describe()
        {
            return base.Describe() + "geometric figure with four sides, two sorter and two longer, and four 90 degree angles.";
        }
    }
}
