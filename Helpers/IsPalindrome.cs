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
    }
}