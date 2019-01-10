using BenchmarkDotNet.Attributes;
using Factories.Implementation.AbstractFactory;
using Factories.Implementation.AbstractFactory.Abstract;
using Factories.Implementation.GenericFactory;
using Factories.Implementation.ReflectionFactory;
using Factories.Models.Hyundai;

namespace Factories.Tests.Benchmarks
{
    public class FactoriesBenchmarks
    {
        private readonly CarFactory _genericFactory;
        private readonly ReflectionFactory _reflectionFactory;
        private readonly AbstractFactory _abstractFactory;

        [Params(100, 1000, 10000)]
        public int N;

        public FactoriesBenchmarks()
        {
            _genericFactory = CarFactory.GetInstance();
            _reflectionFactory = ReflectionFactory.GetInstance();
            _abstractFactory = HyundaiConcreteFactory.GetInstance();
        }

        [Benchmark]
        public void GenericBenchmark() => GenericAction();

        [Benchmark]
        public void ReflectionBenchmark() => ReflectionAction();

        [Benchmark]
        public void AbstractBenchmark() => AbstractAction();


        private void GenericAction()
        {
            for (var i = 0; i < N; i++)
            {
                _genericFactory.Create<HyundaiElectric>();
            }
        }

        private void ReflectionAction()
        {
            for (var i = 0; i < N; i++)
            {
                _reflectionFactory.Create("HyundaiElectric");
            }
        }

        private void AbstractAction()
        {
            for (var i = 0; i < N; i++)
            {
                _abstractFactory.CreateElectricCar();
            }
        }
    }
}