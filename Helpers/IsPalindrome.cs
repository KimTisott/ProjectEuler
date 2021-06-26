namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static bool IsPalindrome(ulong a)
        {
            ulong result = 0, temp = a;

            while (temp > 0)
            {
                result = 10 * result + (temp % 10);

                temp /= 10;
            }

            return result == a;
        }

        public static bool IsPalindrome2(ulong a)
        {
            ulong reversed = 0, number = a;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;

                number = number / 10;
            }

            return reversed == a || a == number / 10;
        }
    }
}