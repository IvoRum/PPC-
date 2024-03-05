using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Readers
{
    class TextFileReader : IFileReader
    {
        private String FileLocation;
        public TextFileReader(String FileLocation)
        {
            this.FileLocation = FileLocation;
        }

        public string readFile()
        {
            StreamReader reader = new StreamReader(FileLocation);
            String result = "";
            while (!reader.EndOfStream)
            {
                result += reader.ReadLine();
                result += "\n";
            }
            reader.Close();
            return result;
        }
    }
}
