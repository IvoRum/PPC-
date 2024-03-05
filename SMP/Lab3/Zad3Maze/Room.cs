namespace Zad3Maze;

public class Room
{
    private bool doorUp;
    private bool doorDown;
    private bool doorLeft;
    private bool doorRight;

    public Room()
    {
    }

    public Room(bool doorUp, bool doorDown, bool doorLeft, bool doorRight)
    {
        this.doorUp = doorUp;
        this.doorDown = doorDown;
        this.doorLeft = doorLeft;
        this.doorRight = doorRight;
    }

    public bool DoorUp
    {
        get => doorUp;
        set => doorUp = value;
    }

    public bool DoorDown
    {
        get => doorDown;
        set => doorDown = value;
    }

    public bool DoorLeft
    {
        get => doorLeft;
        set => doorLeft = value;
    }

    public bool DoorRight
    {
        get => doorRight;
        set => doorRight = value;
    }
}