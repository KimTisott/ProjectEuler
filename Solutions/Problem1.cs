using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(3, 5, 1000), Benchmark]
        public ulong Problem1(ulong p1, ulong p2, ulong p3)
        {
            ulong result, product = p1 * p2, limit = p3 - 1;

            result = p1 * Helpers.NaturalNumbersSum((ulong)(limit * (1.0 / p1)))
                     + p2 * Helpers.NaturalNumbersSum((ulong)(limit * (1.0 / p2)))
                     - product * Helpers.NaturalNumbersSum((ulong)(limit * (1.0 / product)));

            return result;
        }
    }
}