namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong NaturalNumbersSquaresSum(ulong a)
        {
            return a * (a + 1) * ((a << 1) + 1) / 6;
        }
    }
}