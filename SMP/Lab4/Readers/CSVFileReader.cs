using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Readers
{
    class CSVFileReader : IFileReader
    {
        private String FileLocation;
        public CSVFileReader(String FileLocation)
        {
            this.FileLocation = FileLocation;
        }
        public string readFile()
        {
            StreamReader reader = new StreamReader(File.Open(FileLocation, FileMode.Open));
            string result = "";
            while (!reader.EndOfStream)
            {
                string[] elements = reader.ReadLine().Split(",");
                foreach(string element in elements)
                {
                    result += element;
                    result += " ";
                }
                result += "\n";
            }
            reader.Close();
            return result;
        }
    }
}
