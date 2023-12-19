using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPC_Dom6.Zad1
{
    class SportBall : ISportType
    {
        private int _NumberOfPlayers;
        private String _SportType;
        private SportCategory _Category;
        private double _CourtLength;
        private double _CourtWidth;

        public SportBall(int NumberOfPlayers, String SportName, SportCategory Category)
        {
            _NumberOfPlayers = NumberOfPlayers;
            _SportType = SportName;
            _Category = Category;
        }
        public SportCategory Category
        {
            get
            {
                return _Category;
            }
        }

        public int Players
        {
            get
            {
                return _NumberOfPlayers;
            }
            set
            {
                _NumberOfPlayers = value;
            }
        }

        public string NameOfSport
        {
            get
            {
                return _SportType;
            }
        }

        public double Width
        {
            get
            {
                return _CourtWidth;
            }
            set
            {
                _CourtWidth = value;
            }
        }

        public double Length
        {
            get
            {
                return _CourtLength;
            }
            set
            {
                _CourtLength = value;
            }
        }

        public void SportCharacteristics()
        {
            Console.WriteLine("Sport Characteristics \n");
            Console.WriteLine("Name of Sport: " + _SportType + " \n");
            Console.WriteLine("Type of Sport: " + _Category.ToString() + " \n");
            Console.WriteLine("# of Players: " + _NumberOfPlayers.ToString() + " \n");
            Console.WriteLine("Court Dimensions: " + _CourtLength.ToString() + " x " + _CourtWidth.ToString() + " \n");

        }
    }
}
