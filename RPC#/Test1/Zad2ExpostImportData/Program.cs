namespace Zad2ExpostImportData;

class Program
{
    static void Main(string[] args)
    {
        Iinport importPDF = new PDFImport();
        Iexport PDFExport = new PDFExport();
        File file = new PDFFile();
        FileTransferFacade fileTransfer = new FileTransferFacade(importPDF,PDFExport);
        fileTransfer.fileTransfer(file);
    }
}