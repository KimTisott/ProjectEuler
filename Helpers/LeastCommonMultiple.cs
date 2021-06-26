namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong LeastCommonMultiple(ulong a, ulong b)
        {
            return a / GreatestCommonDivisor(a, b) * b;
        }
    }
}