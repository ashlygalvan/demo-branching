namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void FalseIsFalsesIsTrue()
    {
        //this is uhh
        Assert.False(!true);
        Assert.True(!false);
    }
}