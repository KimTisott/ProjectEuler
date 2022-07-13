public class Problem12 : BaseSolution
{
    [Params(500)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result, number = 1;

        while (Helpers.DivisorCount((number + 1) >> 1) * Helpers.DivisorCount(number) <= p1)
        {
            number++;

            if (Helpers.DivisorCount(number >> 1) * Helpers.DivisorCount(number + 1) > p1)
            {
                break;
            }

            number++;
        }

        result = (number * (number + 1)) >> 1;

        return result;
    }

    [Benchmark]
    public override long Result() => 76576500;
}