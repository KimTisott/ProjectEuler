using System;

namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong NthPrimeUpper(ulong a)
        {
            double result = a, log = Math.Log(a), log2 = Math.Log(log);

            if (a >= 688383)
            {
                result *= log + log2 - 1.0 + ((log2 - 2.00) / log);
            }
            else if (a >= 178974)
            {
                result *= log + log2 - 1.0 + ((log2 - 1.95) / log);
            }
            else if (a >= 39017)
            {
                result *= log + log2 - 0.9484;
            }
            else
            {
                result *= log + 0.6000 * log2;
            }

            return (ulong)Math.Ceiling(result);
        }
    }
}