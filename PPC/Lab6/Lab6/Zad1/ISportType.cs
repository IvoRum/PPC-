using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad1
{
    interface ISportType : IBall, ICourtDimensions
    {
        public SportCategory Category
        {
            get;
        }
    }
}
