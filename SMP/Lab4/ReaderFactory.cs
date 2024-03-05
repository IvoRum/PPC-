using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class ReaderCreator
    {
        public abstract IFileReader CreateReader();
    }
}
