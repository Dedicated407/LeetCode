using BenchmarkDotNet.Running;
using UnitTests.Arrays;

namespace Benchmark;

public static class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<CheckIfDoubleExistUnitTest>();
    }
}