using Lab4.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ConcreteReaderCreator : ReaderCreator
    {
        private string FilePath;
        public ConcreteReaderCreator(String FilePath)
        {
            this.FilePath = FilePath;
        }
        public override IFileReader CreateReader()
        {
            string[] elements = FilePath.Split(".");

            switch(elements[elements.Length - 1]){
                case "txt":
                    return new TextFileReader(FilePath);
                case "csv":
                    return new CSVFileReader(FilePath);
                case "bin":
                    return new BinaryFileReader(FilePath);
                default:
                    throw new Exception("Unsuppoted file type.");
            }
        }
    }
}
