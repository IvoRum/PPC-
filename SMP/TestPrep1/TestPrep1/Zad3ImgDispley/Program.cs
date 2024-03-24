using Zad3ImgDispley;

class Program
{
    static void Main(string[] args)
    {
        ImgCreator creator = new ImgCreatorImpl();
        Image image = creator.ImageFactory(123, 123, "jpg");
        image.PrintImage();
    }
}