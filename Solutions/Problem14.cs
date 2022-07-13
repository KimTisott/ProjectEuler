public class Problem14 : BaseSolution
{
    [Params(1000000)]
    public long p1;

    [Benchmark]
    public long A()
    {
        long result = 0, sequence;

        long sequenceLength = 0;

        long[] cache = new long[p1 + 1];

        for (int i = 0; i < cache.Length; i++)
        {
            cache[i] = -1;
        }

        cache[1] = 1;

        for (long i = 2; i <= p1; i++)
        {
            sequence = i;

            ushort j = 0;

            while (sequence != 1 && sequence >= i)
            {
                j++;

                if ((sequence % 2) == 0)
                {
                    sequence /= 2;
                }
                else
                {
                    sequence = (sequence * 3) + 1;
                }
            }

            cache[i] = (short)(j + cache[sequence]);

            if (cache[i] > sequenceLength)
            {
                sequenceLength = cache[i];

                result = i;
            }
        }

        return result;
    }

    [Benchmark]
    public override long Result() => 837799;
}