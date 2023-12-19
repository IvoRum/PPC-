using Vaseens;

namespace TestProject1;

[TestClass]
public class TestVasini
{
    [TestMethod]
    public void Test_CheckUsername()
    {
        Vacsenee bm = new Vacsenee();
        bool res = bm.CheckUsername("ivan40");
        Assert.AreEqual(true,res);
    }
    
    [TestMethod]
    public void Test_CheckUsername_false_tooLong()
    {
        Vacsenee bm = new Vacsenee();
        bool res = bm.CheckUsername("ivan42341!#@$!@0");
        Assert.AreEqual(false,res);
    }
    
    [TestMethod]
    public void Test_CheckPassword()
    {
        Vacsenee bm = new Vacsenee();
        bool res = bm.CheckPassword("d12?");
        Assert.AreEqual(true,res);
    }
    
    [TestMethod]
    public void Test_CheckPassword_flase()
    {
        Vacsenee bm = new Vacsenee();
        bool res = bm.CheckPassword("d12");
        Assert.AreEqual(false,res);
    }
}