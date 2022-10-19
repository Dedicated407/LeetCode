using LeetCode;
using Xunit;

namespace UnitTests.Arrays;

public class RemoveElementUnitTest
{
    [Fact]
    public void Test1()
    {
        var res1 = RemoveElementTask.RemoveElement(new[] {3, 2, 2, 3}, 3);
        var res2 = RemoveElementTask.RemoveElement(new[] {0, 1, 2, 2, 3, 0, 4, 2}, 2);
        var res3 = RemoveElementTask.RemoveElement(new[] {1}, 1);
        var res4 = RemoveElementTask.RemoveElement(new[] {3, 3}, 3);

        Assert.Equal(2, res1);
        Assert.Equal(5, res2);
        Assert.Equal(0, res3);
        Assert.Equal(0, res4);
    }
}