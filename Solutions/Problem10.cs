public class Problem10 : BaseSolution
{
    [Params(2000000)]
    public long p1;

    [Benchmark]
    public unsafe long A()
    {
        long result = 5, limit = p1;

        byte[] numbers = new byte[limit];

        fixed (byte* sieve = &numbers[0])
        {
            for (long i = 5; i < limit; i += 4)
            {
                if (sieve[i] == 0)
                {
                    result += i;

                    for (long j = i * i; j < limit; j += i)
                    {
                        sieve[j] = 1;
                    }
                }

                i += 2;

                if (sieve[i] == 0)
                {
                    result += i;

                    for (long j = i * i; j < limit; j += i)
                    {
                        sieve[j] = 1;
                    }
                }
            }
        }

        return result;
    }

    [Benchmark]
    public override long Result() => 142913828922;
}