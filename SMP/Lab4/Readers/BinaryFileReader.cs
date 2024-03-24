using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Readers
{
    class BinaryFileReader : IFileReader
    {
        private String FileLocation;

        public BinaryFileReader(String FileLocation)
        {
            this.FileLocation = FileLocation;
        }
        public string readFile()
        {
            FileStream stream = File.Open(FileLocation, FileMode.Open);
            BinaryReader binReader = new BinaryReader(stream, Encoding.UTF8,false);
            string result = "";
            while (stream.Position != stream.Length)
            {
                result += binReader.ReadString(); 
                result += " ";
            }
            binReader.Close();
            stream.Close();
            return result;
        }
    }
}
