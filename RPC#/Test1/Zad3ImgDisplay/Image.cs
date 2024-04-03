namespace Zad3ImgDispley;

public abstract class Image:IImage
{
    private int lenght;
    private int hight;
    private string format;

    public Image(int lenght, int hight, string format)
    {
        this.lenght = lenght;
        this.hight = hight;
        this.format = format;
    }

    public abstract void PrintImage();
}