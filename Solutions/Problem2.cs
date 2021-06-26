using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    [DisassemblyDiagnoser, MemoryDiagnoser]
    public class Problem2
    {
        [Arguments(4000000), Benchmark]
        public ulong Solution1(ulong p1)
        {
            ulong result, previous = 2, current = 8, next;

            while (current <= p1)
            {
                next = previous + (current << 2);

                previous = current;

                current = next;
            }

            result = (previous + current - 2) >> 2;

            return result;
        }
    }
}
