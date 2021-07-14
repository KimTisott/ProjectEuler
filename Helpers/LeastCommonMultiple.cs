namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong LeastCommonMultiple(ulong a, ulong b)
        {
            return (ulong)(a * (1.0 / GreatestCommonDivisor(a, b)) * b);
        }
    }
}