using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(10001), Benchmark]
        public ulong Problem7(uint p1)
        {
            ulong result, index = p1, limit = Helpers.NthPrimeUpper(index), count = 1;

            byte[] sieve = new byte[limit];

            for (result = 3; result < limit; result += 2)
            {
                if (sieve[result] == 0)
                {
                    count++;

                    if (count == index)
                    {
                        break;
                    }

                    for (ulong i = result * result; i < limit; i += result)
                    {
                        sieve[i] = 1;
                    }
                }
            }

            return result;
        }
    }
}