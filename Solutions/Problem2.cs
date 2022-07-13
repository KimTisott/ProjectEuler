public class Problem2 : BaseSolution
{
    [Params(4000000)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result, previous = 2, current = 8, next;

        while (current <= p1)
        {
            next = previous + (current << 2);
            previous = current;
            current = next;
        }

        result = (previous + current - 2) >> 2;

        return result;
    }

    [Benchmark]
    public override long Result() => 4613732;
}