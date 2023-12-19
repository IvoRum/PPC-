using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad2
{
    public class Figure : Demo
    {
        protected double _Width;
        protected double _Length;

        public Figure(double Width, double Length)
        {
            _Width = Width;
            _Length = Length;
        }

        public override double Lice()
        {
            return _Width * _Length;
        }

        public override void Show()
        {
           if(_Length == _Width)
            {
                Console.WriteLine("Figure is a square. \n");
            } else
            {
                Console.WriteLine("Figure is a paralelipiped. \n");
            }
        }
    }
}
