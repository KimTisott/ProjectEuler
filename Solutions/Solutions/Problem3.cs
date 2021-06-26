using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
    [DisassemblyDiagnoser, MemoryDiagnoser]
    public class Problem3
    {
        [Arguments(600851475143), Benchmark]
        public ulong Solution1(ulong p1)
        {
			ulong result = p1, counter = 3;

			while (counter * counter <= result)
			{
				if (result % counter == 0)
				{
					result /= counter;
				}
				else
				{
					counter += 2;
				}
			}

			return result;
		}
	}
}