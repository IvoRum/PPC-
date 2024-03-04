using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_dom5.Zad3
{
    class Rectangle : IEnglishDimensions, IMetricDimensions
    {
        private float _lengthInches;
        private float _widthInches;

        public Rectangle(float Length, float Width)
        {
            _lengthInches = Length;
            _widthInches = Width;
        }

        float IEnglishDimensions.length()
        {
            return _lengthInches;
        }

        float IEnglishDimensions.width()
        {
            return _widthInches;
        }

        float IMetricDimensions.length()
        {
            return _lengthInches * (float)2.54;
        }

        float IMetricDimensions.width()
        {
            return _widthInches * (float)2.54;
        }
    }
}
