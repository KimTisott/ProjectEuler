public class Problem4 : BaseSolution
{
    [Params(3)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result = 0, max = 1, floor, limit, decrement, digits = p1;

        for (long i = 0; i < digits; i++)
        {
            max *= 10;
        }

        floor = max / 10;

        max--;

        if (digits % 2 == 0)
        {
            limit = max;
            decrement = 1;
        }
        else
        {
            limit = max - 9;
            decrement = 11;
        }

        for (long i = max; i > floor; i--)
        {
            if (i * i < result)
            {
                break;
            }

            for (long j = limit; j > floor; j -= decrement)
            {
                long product = i * j;

                if (product < result)
                {
                    break;
                }

                if (Helpers.IsPalindrome(product))
                {
                    result = product;

                    floor = Helpers.Smallest(i, j);

                    break;
                }
            }
        }

        return result;
    }

    [Benchmark]
    public override long Result() => 906609;
}