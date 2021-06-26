namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong NaturalNumbersSum(ulong a)
        {
            return a * (a + 1) >> 1;
        }
    }
}