namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong DivisorCount1(ulong a)
        {
            ulong result = 0;

            for (ulong i = 1; i * i <= a; i++)
            {
                if (a % i == 0)
                {
                    if (i * i < a)
                    {
                        result += 2;
                    }
                    else
                    {
                        result += 1;
                    }
                }
            }

            return result;
        }

        // faster for larger numbers
        public static ulong DivisorCount2(ulong a)
        {
            ulong result = 1;

            while (a % 2 == 0)
            {
                result++;

                a = a >> 1;
            }

            for (ulong i = 3; i <= a; i += 2)
            {
                ulong count = 0;

                while (a % i == 0)
                {
                    count++;

                    a /= i;
                }

                result *= count + 1;
            }

            return result;
        }
    }
}