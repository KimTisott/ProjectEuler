using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(100), Benchmark]
        public ulong Problem6(ulong p1)
        {
            ulong result, count = p1, sum, squaresSum;

            sum = Helpers.NaturalNumbersSum(count);

            squaresSum = Helpers.NaturalNumbersSquaresSum(count);

            result = sum * sum - squaresSum;

            return result;
        }
    }
}