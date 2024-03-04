namespace Zad3PhotoArchive;

public class Photo
{
    private DateTime takenOn;
    private String data;

    public DateTime TakenOn
    {
        get => takenOn;
        set => takenOn = value;
    }

    public string Data
    {
        get => data;
        set => data = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Photo ShallowCopy()
    {
        return (Photo)this.MemberwiseClone();
    }

    public Photo DeepClone()
    {
        Photo clone = (Photo)this.MemberwiseClone();
        clone.TakenOn = new DateTime(takenOn.Ticks);
        clone.data = String.Copy(data);
        return clone;
    }
}