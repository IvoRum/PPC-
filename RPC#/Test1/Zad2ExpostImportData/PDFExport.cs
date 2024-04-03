namespace Zad2ExpostImportData;

public class PDFExport: Iexport
{
    public File export(File file)
    {
        Console.WriteLine("Export PDF");
        return file;
    }
}