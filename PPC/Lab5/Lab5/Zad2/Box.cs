using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_dom5.Zad_2
{
    class Box : IDimensions
    {
        private float _lengthInches;
        private float _widthInches;

        public Box(float Length, float Width)
        {
            _lengthInches = Length;
            _widthInches = Width;
        }

        public float length()
        {
            return _lengthInches;
        }
        public float width()
        {
            return _widthInches;
        }
    }
}
