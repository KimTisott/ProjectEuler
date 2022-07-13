public class Problem9 : BaseSolution
{
    [Params(1000)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result = 0;

        long a, b, c, x = p1 >> 1, min = (long)Math.Floor(Math.Sqrt(x >> 1)), max = (long)Math.Ceiling(Math.Sqrt(x));

        for (long m = min; m <= max; m++)
        {
            long n = x / m - m;

            a = (m * m) - (n * n);

            b = 2 * m * n;

            c = (m * m) + (n * n);

            if (a + b + c == 1000)
            {
                return a * b * c;
            }
        }

        return result;
    }

    [Benchmark]
    public override long Result() => 31875000;
}