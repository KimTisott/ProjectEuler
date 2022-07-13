public class Problem7 : BaseSolution
{
    [Params(10001)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result, count = p1, limit = Helpers.NthPrimeUpper(count);

        bool[] sieve = new bool[limit];

        count -= 2;

        for (result = 5; result <= limit; result += 4)
        {
            if (!sieve[result])
            {
                if (--count == 0)
                {
                    return result;
                }

                for (long i = result * result; i <= limit; i += result)
                {
                    sieve[i] = true;
                }
            }

            result += 2;

            if (!sieve[result])
            {
                if (--count == 0)
                {
                    return result;
                }

                for (long i = result * result; i <= limit; i += result)
                {
                    sieve[i] = true;
                }
            }
        }

        return result;
    }

    [Benchmark]
    public long B()
        => nthPrime((int)p1);

    [Benchmark]
    public override long Result() => 104743;

    // Count number of set bits in an int
    public static int popCount(int n)
    {
        n -= (n >>> 1) & 0x55555555;
        n = ((n >>> 2) & 0x33333333) + (n & 0x33333333);
        n = ((n >> 4) & 0x0F0F0F0F) + (n & 0x0F0F0F0F);
        return (n * 0x01010101) >> 24;
    }

    // Speed up counting by counting the primes per
    // array slot and not individually. This yields
    // another factor of about 1.24 or so.
    public static int nthPrime(int n)
    {
        if (n < 2) return 2;
        if (n == 2) return 3;
        if (n == 3) return 5;
        int limit, root, count = 2;
        limit = (int)(n * (Math.Log(n) + Math.Log(Math.Log(n)))) + 3;
        root = (int)Math.Sqrt(limit);
        switch (limit % 6)
        {
            case 0:
                limit = 2 * (limit / 6) - 1;
                break;
            case 5:
                limit = 2 * (limit / 6) + 1;
                break;
            default:
                limit = 2 * (limit / 6);
                break;
        }
        switch (root % 6)
        {
            case 0:
                root = 2 * (root / 6) - 1;
                break;
            case 5:
                root = 2 * (root / 6) + 1;
                break;
            default:
                root = 2 * (root / 6);
                break;
        }
        int dim = (limit + 31) >> 5;
        int[] sieve = new int[dim];
        for (int i = 0; i < root; ++i)
        {
            if ((sieve[i >> 5] & (1 << (i & 31))) == 0)
            {
                int start, s1, s2;
                if ((i & 1) == 1)
                {
                    start = i * (3 * i + 8) + 4;
                    s1 = 4 * i + 5;
                    s2 = 2 * i + 3;
                }
                else
                {
                    start = i * (3 * i + 10) + 7;
                    s1 = 2 * i + 3;
                    s2 = 4 * i + 7;
                }
                for (int j = start; j < limit; j += s2)
                {
                    sieve[j >> 5] |= 1 << (j & 31);
                    j += s1;
                    if (j >= limit) break;
                    sieve[j >> 5] |= 1 << (j & 31);
                }
            }
        }
        int k;
        for (k = 0; count < n; ++k)
        {
            count += popCount(~sieve[k]);
        }
        --k;
        int mask = ~sieve[k];
        int p;
        for (p = 31; count >= n; --p)
        {
            count -= (mask >> p) & 1;
        }

        return 3 * (p + (k << 5)) + 7 + (p & 1);
    }
}