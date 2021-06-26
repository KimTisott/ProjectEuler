namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong GreatestCommonDivisor(ulong a, ulong b)
        {
            while (b != 0)
            {
                ulong temp = a % b;

                a = b;

                b = temp;
            }

            return a;
        }
    }
}