using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(10001), Benchmark]
        public ulong Problem7(uint p1)
        {
            ulong result, count = p1, limit = Helpers.NthPrimeUpper(count);

            byte[] sieve = new byte[limit];

            count -= 2;

            for (result = 5; result <= limit; result += 4)
            {
                if (sieve[result] == 0)
                {
                    if (--count == 0)
                    {
                        return result;
                    }

                    for (ulong i = result * result; i <= limit; i += result)
                    {
                        sieve[i] = 1;
                    }
                }

                result += 2;

                if (sieve[result] == 0)
                {
                    if (--count == 0)
                    {
                        return result;
                    }

                    for (ulong i = result * result; i <= limit; i += result)
                    {
                        sieve[i] = 1;
                    }
                }
            }

            return result;
        }
    }
}