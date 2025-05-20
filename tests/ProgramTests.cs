using Xunit;

public class ProgramTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        Assert.Equal(5, Program.Add(2, 3));
    }
}
