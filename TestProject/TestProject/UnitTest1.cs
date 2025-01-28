namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void FalseIsFalse()
    {
        //this is uhh
        Assert.False(!true);
        Assert.True(!false);
    }
}