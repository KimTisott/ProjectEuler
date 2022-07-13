/// <summary>
/// The math class.
/// </summary>
public static class Helpers
{
    public static long DivisorCount(long a)
    {
        long result = 0;

        for (long i = 1; i * i <= a; i++)
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
    public static long DivisorCountLarge(long a)
    {
        long result = 1;

        while (a % 2 == 0)
        {
            result++;

            a >>= 1;
        }

        for (long i = 3; i <= a; i += 2)
        {
            long count = 0;

            while (a % i == 0)
            {
                count++;

                a /= i;
            }

            result *= count + 1;
        }

        return result;
    }

    public static long GreatestCommonDivisor(long a, long b)
    {
        while (b != 0)
        {
            long temp = a % b;

            a = b;

            b = temp;
        }

        return a;
    }

    public static bool IsPalindrome(long a)
    {
        long result = 0, temp = a;

        while (temp > 0)
        {
            result = (10 * result) + (temp % 10);

            temp /= 10;
        }

        return result == a;
    }

    public static long Largest(long a, long b)
        => a > b ? a : b;

    public static long LeastCommonMultiple(long a, long b)
        => a / GreatestCommonDivisor(a, b) * b;

    public static long NaturalNumbersSquaresSum(long a)
        => a * (a + 1) * ((a << 1) + 1) / 6;

    public static long NaturalNumbersSum(long a)
        => (a * (a + 1)) >> 1;

    public static long NthPrimeUpper(long a)
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
            result *= log + (0.6000 * log2);
        }

        return (long)Math.Ceiling(result);
    }

    public static long Smallest(long a, long b)
        => a < b ? a : b;
}