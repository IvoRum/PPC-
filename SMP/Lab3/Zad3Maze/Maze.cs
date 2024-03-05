namespace Zad3Maze;

public class Maze
{
    private Room[,] Rooms;

    public Maze(Room[,] rooms)
    {
        Rooms = rooms;
    }

    public void addRoom(int x, int y, Room room)
    {
        this.Rooms[x,y] = room;
    }

    public void addDoorToRoom(int x, int y, bool doorUp, bool doorDown, bool doorLeft, bool doorRight)
    {
        this.Rooms[x,y].DoorDown=doorDown;
        this.Rooms[x,y].DoorLeft=doorLeft;
        this.Rooms[x,y].DoorRight=doorRight;
        this.Rooms[x,y].DoorUp=doorUp;
    }
}