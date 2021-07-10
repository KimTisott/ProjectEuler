using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(1000000), Benchmark]
        public ulong Problem14(ulong p1)
        {
            ulong result = 0, sequence;
            
            long sequenceLength = 0;

            long[] cache = new long[p1 + 1];

            for (int i = 0; i < cache.Length; i++)
            {
                cache[i] = -1;
            }

            cache[1] = 1;

            for (ulong i = 2; i <= p1; i++)
            {
                sequence = i;

                ushort j = 0;

                while (sequence != 1 && sequence >= i)
                {
                    j++;

                    if ((sequence % 2) == 0)
                    {
                        sequence = sequence / 2;
                    }
                    else
                    {
                        sequence = sequence * 3 + 1;
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

        //[Arguments(1000000), Benchmark]
        public ulong Problem14a(ulong p1)
        {
            ulong result = 0, power = 0, exponentiation = 0;

            List<ulong> powers = new List<ulong>();

            while (exponentiation < p1)
            {
                exponentiation = (ulong)Math.Pow(2, power);

                powers.Add(exponentiation);

                power++;
            }

            return result;
        }
    }
}