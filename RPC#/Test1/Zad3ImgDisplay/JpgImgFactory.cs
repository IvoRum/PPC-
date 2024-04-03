namespace Zad3ImgDispley;

public class JpgImgFactory:ImgCreator
{
    public override Image ImageFactory(int lenght, int hight, string format)
    {
        return new JPGImg(lenght, hight, format);
    }
}