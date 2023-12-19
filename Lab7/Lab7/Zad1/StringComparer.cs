using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom7.Zad1
{
    class StringComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            String[] firstElements = ((String)x).Split(" ");
            String[] secondElements = ((String)y).Split(" ");
            if (int.Parse(firstElements[3]) > int.Parse(secondElements[3]))
            {
                return 1;
            }
            else if (int.Parse(firstElements[3]) < int.Parse(secondElements[3]))
            {
                return -1;
            }
            else
            {
                return ((String)x).CompareTo((String)y);
            }
        }
    }
}
