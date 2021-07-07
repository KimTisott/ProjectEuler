using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(500), Benchmark]
        public ulong Problem12(ulong p1)
        {
            ulong result = 0, increment = 1, count = 0;

            while (count <= p1)
            {
                result = Helpers.NaturalNumbersSum(increment);

                count = Helpers.DivisorCount(result);

                increment++;
            }

            return result;
        }
    }
}