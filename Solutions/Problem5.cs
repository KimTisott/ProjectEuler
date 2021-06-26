using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(20), Benchmark]
        public ulong Problem5(byte p1)
        {
            ulong result = 1, count = p1;

            for (ulong i = count; i > 0; i--)
            {
                result = Helpers.LeastCommonMultiple(result, i);
            }

            return result;
        }
    }
}