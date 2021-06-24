using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    [MemoryDiagnoser]
    public class Solutions
    {
        [Arguments(3, 5, 999), Benchmark]
        public ulong Problem1(ulong p1, ulong p2, ulong p3)
        {
            ulong result, product = p1 * p2;

            result = p1 * Helpers.NaturalNumbersSum(p3 / p1)
                     + p2 * Helpers.NaturalNumbersSum(p3 / p2) 
                     - product * Helpers.NaturalNumbersSum(p3 / product);

            return result;
        }

        [Arguments(4000000), Benchmark]
        public ulong Problem2(ulong p1)
        {
            ulong result = 0, before = 1, current = 2, next;

            while (current < p1)
            {
                result += current;

                next = before + (current << 1);

                current = next + before + current;

                before = next;
            }

            return result;
        }
    }
}