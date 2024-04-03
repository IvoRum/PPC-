using Zad3ImgDispley;

class Program
{
    static void Main(string[] args)
    {
        ImgCreator creator = new JpgImgFactory();
        Image image = creator.ImageFactory(123, 123, "JPG");
        image.PrintImage();
    }
}