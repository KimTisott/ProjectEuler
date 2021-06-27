using BenchmarkDotNet.Attributes;
using System;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(1000), Benchmark]
        public ulong Problem9(ushort p1)
        {
            ulong result = 0, a, b, c, x, y, z;
            
            ushort sum = p1, limit = (ushort)Math.Sqrt(sum >> 1);

            for (uint i = 2; i <= limit; i++)
            {
                if ((sum >> 1) % i == 0)
                {
                    x = i + (i % 2) + 1;

                    while (x < (i << 1) && x <= sum / (i << 1))
                    {
                        if (sum / (i << 1) % x == 0 && Helpers.GreatestCommonDivisor(x, i) > 0)
                        {
                            z = (ulong)(sum >> 1) / (x * i);

                            y = x - i;

                            a = (z * y * i) << 1;

                            b = z * (i * i - y * y);

                            c = z * (i * i + y * y);

                            result = a * b * c;

                            break;
                        }

                        x += 2;
                    }
                }

                if (result > 0)
                {
                    break;
                }
            }

            return result;
        }
    }
}