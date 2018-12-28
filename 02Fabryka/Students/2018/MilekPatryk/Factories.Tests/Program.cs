using BenchmarkDotNet.Running;
using Factories.Tests.Benchmarks;

namespace Factories.Tests
{
    internal class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<FactoriesBenchmarks>();
        }
    }
}
