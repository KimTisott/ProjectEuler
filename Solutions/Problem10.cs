using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(2000000), Benchmark]
        public unsafe ulong Problem10(ulong p1)
        {
            ulong result = 5, limit = p1;

            byte[] numbers = new byte[limit];

            fixed (byte* sieve = &numbers[0])
            {
                for (ulong i = 5; i < limit; i += 4)
                {
                    if (sieve[i] == 0)
                    {
                        result += i;

                        for (ulong j = i * i; j < limit; j += i)
                        {
                            sieve[j] = 1;
                        }
                    }

                    i += 2;

                    if (sieve[i] == 0)
                    {
                        result += i;

                        for (ulong j = i * i; j < limit; j += i)
                        {
                            sieve[j] = 1;
                        }
                    }
                }
            }

            return result;
        }
    }
}