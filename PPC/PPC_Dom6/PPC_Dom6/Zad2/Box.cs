using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad2
{
    class Box : Figure
    {
        protected double _Height;
        public Box(double Width, double Lenght, double Height) : base(Width,Lenght)
        {
            _Height = Height;
        }

        public override void Show()
        {
            if(_Height == _Length && _Height == _Width)
            {
                Console.WriteLine("Figure is a cube. \n");
            } else
            {
                Console.WriteLine("Figure is a paralelipiped. \n");
            }
        }
        public override double Lice()
        {
            return 2 * base.Lice() + 2 * _Height * _Width + 2 * _Height * _Length;
        }
    }
}
