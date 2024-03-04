using System;

namespace PPC_Dom4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[3];
            points[0] = 98;
            points[1] = 95;
            points[2] = 93;
            StudentResults studentResults = new StudentResults();
            Console.WriteLine(studentResults[points]);
            points[0] = 23;
            points[1] = 33;
            points[2] = 67;
            Console.WriteLine(studentResults[points]);
            Console.ReadLine();
        }
    }

    class StudentResults
    {
       private  int[] _points;

        public String this[int[] Points]
        {
            set { _points = Points; }
            get {
                String res = "Your points are ";
                int averagePoints = 0;
                for( int i = 0;i < Points.Length; i++)
                {
                    averagePoints += Points[i];
                    res += Points[i].ToString();
                    res += " ";
                }
                res += ", therefore ";
                averagePoints = averagePoints / Points.Length;
                if (averagePoints >= 90)
                {
                    res += "you are otlichnik!";
                }
                else
                {
                    res += "you are not otlichnik";
                }
                res += "\n your average score is ";
                res += averagePoints.ToString();
                return res;
            }
        }
    }
}
