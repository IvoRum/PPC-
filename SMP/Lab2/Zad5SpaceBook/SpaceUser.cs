namespace Zad5SpaceBook;

public class SpaceUser
{
    private string name;

    public SpaceGroup createGroup(List<SpaceUser> admins, List<SpaceUser> users, List<SpaceGroup> moreGroupsLikeDis)
    {
        Console.WriteLine("What is the title of the group?");
        string title = Console.In.ReadLine();
        SpaceGroup nSpaceGroup = new SpaceGroup(title,admins,users,moreGroupsLikeDis);
        return nSpaceGroup;
    }
}