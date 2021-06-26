using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    [DisassemblyDiagnoser, MemoryDiagnoser]
    public class Problem1
    {
        [Arguments(3, 5, 1000), Benchmark]
        public ulong Solution1(uint p1, uint p2, ulong p3)
        {
            ulong result, product = p1 * p2, limit = p3 - 1;

            result = p1 * Helpers.NaturalNumbersSum(limit / p1)
                     + p2 * Helpers.NaturalNumbersSum(limit / p2)
                     - product * Helpers.NaturalNumbersSum(limit / product);

            return result;
        }
    }
}