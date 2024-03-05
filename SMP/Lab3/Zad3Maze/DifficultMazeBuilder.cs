namespace Zad3Maze;

public class DifficultMazeBuilder:IBuilder
{
    private Maze _maze;

    public DifficultMazeBuilder()
    {
        var maze = new Room[4, 4]
        {
            { new Room(), new Room(), new Room() , new Room() },
            { new Room(), new Room(), new Room() , new Room() },
            { new Room(), new Room(), new Room() , new Room() },
            { new Room(), new Room(), new Room() , new Room() }
        };
        this._maze = new Maze(maze);
    }

    public Maze BuildMaze()
    {
        Room start11 = new Room(false, true, false, true);
        Room room12 = new Room(false, false, true, true);
        Room room13 = new Room(false, true, true, false);
        Room room14 = new Room(false, false, true, false);
        Room room21 = new Room(true, true, false, false);
        Room room22 = new Room(false, true, false, true);
        Room room23 = new Room(true, true, true, false);
        Room room24 = new Room(true,true,false,false);
        Room room31 = new Room(true, false, false, false);
        Room room32 = new Room(true, false, false, false);
        Room room33 = new Room(true,true,false,false);
        Room room34 = new Room(true,true,false,true);
        Room room41 = new Room(false,false,false,true);
        Room room42 = new Room(false,false,true,true);
        Room room43 = new Room(true,false,true,true);
        Room room44 = new Room();
        
        this._maze.addRoom(1,1,start11);
        this._maze.addRoom(2,1,room12);
        this._maze.addRoom(3,1,room13);
        this._maze.addRoom(4,1,room14);
        this._maze.addRoom(1,2,room21);
        this._maze.addRoom(2,2,room22);
        this._maze.addRoom(3,2,room23);
        this._maze.addRoom(4,2,room24);
        this._maze.addRoom(1,3,room31);
        this._maze.addRoom(2,3,room32);
        this._maze.addRoom(3,3,room33);
        this._maze.addRoom(4,3,room34);
        this._maze.addRoom(1,4,room41);
        this._maze.addRoom(2,4,room42);
        this._maze.addRoom(3,4,room43);
        this._maze.addRoom(4,4,room44);

        return this._maze;
    }

    public void BuildRoom(int x,int y, Room room)
    {
        this._maze.addRoom(x,y,room);
    }

    public void BuildDoor(int x, int y, bool doorUp, bool doorDown, bool doorLeft, bool doorRight)
    {
        this._maze.addDoorToRoom(x,y,doorUp,doorDown,doorLeft,doorRight);
    }

    public Maze GetMaze()
    {
        return this._maze;
    }
}