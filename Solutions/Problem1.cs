public class Problem1 : BaseSolution
{
    [Params(3)]
    public long p1;

    [Params(5)]
    public long p2;

    [Params(1000)]
    public long p3;

    [Benchmark]
    public long A()
    {
        long result, product = p1 * p2, limit = p3 - 1;

        result = (p1 * Helpers.NaturalNumbersSum((long)(limit * (1.0 / p1))))
            + (p2 * Helpers.NaturalNumbersSum((long)(limit * (1.0 / p2))))
            - (product * Helpers.NaturalNumbersSum((long)(limit * (1.0 / product))));

        return result;
    }

    [Benchmark]
    public override long Result() => 233168;
}