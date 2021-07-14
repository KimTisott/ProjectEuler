using BenchmarkDotNet.Attributes;
using System;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(1000), Benchmark]
        public ulong Problem9(ulong p1)
        {
            ulong result = 0;

            ulong a, b, c, x = p1 >> 1, min = (ulong)Math.Floor(Math.Sqrt(x >> 1)), max = (ulong)Math.Ceiling(Math.Sqrt(x));

            for (ulong m = min; m <= max; m++)
            {
                ulong n = (ulong)(x * (1.0 / m) - m);

                a = m * m - n * n;

                b = 2 * m * n;

                c = m * m + n * n;

                if (a + b + c == 1000)
                {
                    return a * b * c;
                }
            }

            return result;
        }
    }
}