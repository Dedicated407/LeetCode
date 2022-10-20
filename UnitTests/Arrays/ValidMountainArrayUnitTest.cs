using BenchmarkDotNet.Attributes;
using LeetCode.Arrays;
using Xunit;

namespace UnitTests.Arrays;

[MemoryDiagnoser]
[RankColumn]
public class ValidMountainArrayUnitTest
{
    [Fact]
    [Benchmark]
    public void Test1()
    {
        var res1 = ValidMountainArrayTask.ValidMountainArray(new[] {2, 1});
        var res2 = ValidMountainArrayTask.ValidMountainArray(new[] {3, 5, 5});
        var res3 = ValidMountainArrayTask.ValidMountainArray(new[] {0, 3, 2, 1});
        var res4 = ValidMountainArrayTask.ValidMountainArray(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
        var res5 = ValidMountainArrayTask.ValidMountainArray(new[] {9, 8, 7, 6, 5});

        Assert.False(res1);
        Assert.False(res2);
        Assert.True(res3);
        Assert.False(res4);
        Assert.False(res5);
    }
}