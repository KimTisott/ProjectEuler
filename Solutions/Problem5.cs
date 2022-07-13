public class Problem5 : BaseSolution
{
    [Params(20)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result = 1, count = p1;

        for (long i = count; i > 0; i--)
        {
            result = Helpers.LeastCommonMultiple(result, i);
        }

        return result;
    }

    [Benchmark]
    public override long Result() => 232792560;
}