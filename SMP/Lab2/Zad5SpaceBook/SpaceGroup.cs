namespace Zad5SpaceBook;

public class SpaceGroup
{
    private string title;
    private List<SpaceUser> admins;
    private List<SpaceUser> users;
    private List<SpaceGroup> moreGroupsLikeDis;

    public SpaceGroup(string title, List<SpaceUser> admins, List<SpaceUser> users, List<SpaceGroup> moreGroupsLikeDis)
    {
        this.title = title;
        this.admins = admins;
        this.users = users;
        this.moreGroupsLikeDis = moreGroupsLikeDis;
    }
}