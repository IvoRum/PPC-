namespace Zad3ImgDispley;

public class JPGImg:Image
{
    public JPGImg(int lenght, int hight, string format) : base(lenght, hight, format)
    {
        Console.WriteLine("Printing JPG lenght:"+lenght+", hight:"+hight+", format"+format);
    }

    public override void PrintImage()
    {
    }
}