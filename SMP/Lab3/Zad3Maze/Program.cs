// See https://aka.ms/new-console-template for more information

using Zad3Maze;

static void Main()
{
    Console.WriteLine("Welcome to the maze!!1!");
    IBuilder standardMazeBuilder = new StandardMazeBuilder();
    Maze smallMaze=standardMazeBuilder.BuildMaze();

    IBuilder difficultMazeBuilder = new DifficultMazeBuilder();
    Maze largeMaze = difficultMazeBuilder.BuildMaze();
    
    //The same maze but whit a new room
    standardMazeBuilder.BuildRoom(1, 1, new Room(true, true, false, true));
    Maze alteredSmallMaze = standardMazeBuilder.GetMaze();
}