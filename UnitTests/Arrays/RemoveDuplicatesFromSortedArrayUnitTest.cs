using LeetCode.Arrays;
using Xunit;

namespace UnitTests.Arrays;

public class RemoveDuplicatesFromSortedArrayUnitTest
{
    [Fact]
    public void Test1()
    {
        var res1 = RemoveDuplicatesFromSortedArray.RemoveDuplicates(new[] {1, 1, 2});
        var res2 = RemoveDuplicatesFromSortedArray.RemoveDuplicates(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4});
        var res3 = RemoveDuplicatesFromSortedArray.RemoveDuplicates(new[] {1});
        var res4 = RemoveDuplicatesFromSortedArray.RemoveDuplicates(new[] {3, 3});

        Assert.Equal(2, res1);
        Assert.Equal(5, res2);
        Assert.Equal(1, res3);
        Assert.Equal(1, res4);
    }
}