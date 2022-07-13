public class Problem6 : BaseSolution
{
    [Params(100)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result, count = p1, sum, squaresSum;

        sum = Helpers.NaturalNumbersSum(count);

        squaresSum = Helpers.NaturalNumbersSquaresSum(count);

        result = (sum * sum) - squaresSum;

        return result;
    }

    [Benchmark]
    public override long Result() => 25164150;
}