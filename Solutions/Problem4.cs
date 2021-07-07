using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    public partial class Solutions
    {
        [Arguments(3), Benchmark]
        public ulong Problem4(ulong p1)
        {
            ulong result = 0, max = 1, floor, limit, decrement, digits = p1;

            for (ulong i = 0; i < digits; i++)
            {
                max *= 10;
            }

            floor = max / 10;

            max--;

            if (digits % 2 == 0)
            {
                limit = max;
                decrement = 1;
            }
            else
            {
                limit = max - 9;
                decrement = 11;
            }

            for (ulong i = max; i > floor; i--)
            {
                if (i * i < result)
                {
                    break;
                }

                for (ulong j = limit; j > floor; j -= decrement)
                {
                    ulong product = i * j;

                    if (product < result)
                    {
                        break;
                    }

                    if (Helpers.IsPalindrome(product))
                    {
                        result = product;

                        floor = Helpers.Smallest(i, j);

                        break;
                    }
                }
            }

            return result;
        }
    }
}