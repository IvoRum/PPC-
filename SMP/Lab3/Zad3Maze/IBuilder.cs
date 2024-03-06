namespace Zad3Maze;

public interface IBuilder
{
    public Maze BuildMaze();
    public void BuildRoom(int x,int y, Room room);
    public void BuildDoor(int x, int y, bool doorUp, bool doorDown, bool doorLeft, bool doorRight);
    public Maze GetMaze();
}