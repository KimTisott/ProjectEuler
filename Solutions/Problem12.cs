using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(500), Benchmark]
        public ulong Problem12(ulong p1)
        {
            ulong result, number = 1;

            while (Helpers.DivisorCount1((number + 1) >> 1) * Helpers.DivisorCount1(number) <= p1)
            {
                number++;

                if (Helpers.DivisorCount1(number >> 1) * Helpers.DivisorCount1(number + 1) > p1)
                {
                    break;
                }

                number++;
            }

            result = number * (number + 1) >> 1;

            return result;
        }
    }
}