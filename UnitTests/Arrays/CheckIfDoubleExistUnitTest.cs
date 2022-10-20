using BenchmarkDotNet.Attributes;
using LeetCode.Arrays;
using Xunit;

namespace UnitTests.Arrays;

[MemoryDiagnoser]
[RankColumn]
public class CheckIfDoubleExistUnitTest
{
    [Fact]
    [Benchmark]
    public void Test1()
    {
        var res1 = CheckIfDoubleExist.CheckIfExist(new[] {10, 2, 5, 3});
        var res2 = CheckIfDoubleExist.CheckIfExist(new[] {3, 1, 7, 11});
        var res3 = CheckIfDoubleExist.CheckIfExist(new[] {-2, 0, 10, -19, 4, 6, -8});
        var res4 = CheckIfDoubleExist.CheckIfExist(new[] {0, 0});
        var res5 = CheckIfDoubleExist.CheckIfExist(new[] {7, 1, 14, 11});

        Assert.True(res1);
        Assert.False(res2);
        Assert.False(res3);
        Assert.True(res4);
        Assert.True(res5);
    }
}