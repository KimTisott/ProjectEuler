namespace ProjectEuler
{
    public static partial class Helpers
    {
        public static ulong NaturalNumbersSum(ulong number)
        {
            return number * (number + 1) >> 1;
        }
    }
}