using BenchmarkDotNet.Running;
using Singleton.Benchmarks;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<PerformanceBenchmarks>();
        }
    }
}