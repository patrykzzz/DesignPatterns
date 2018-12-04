using BenchmarkDotNet.Attributes;

namespace Singleton.Benchmarks
{
    public class PerformanceBenchmarks
    {
        [Params(10, 100, 1000)]
        public int N;

        [Benchmark]
        public void ImprovedSingletonBenchmark()
        {
            for (var i = 0; i < N; i++)
            {
                ImprovedSingleton.GetInstance();
            }
        }

        [Benchmark]
        public void SingletonBenchmark()
        {
            for (var i = 0; i < N; i++)
            {
                Singleton.GetInstance();
            }
        }
    }
}