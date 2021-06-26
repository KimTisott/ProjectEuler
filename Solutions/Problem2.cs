using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(4000000), Benchmark]
        public ulong Problem2(ulong p1)
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
