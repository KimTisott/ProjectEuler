using BenchmarkDotNet.Attributes;

namespace ProjectEuler
{
	public partial class Solutions
	{
        [Arguments(600851475143), Benchmark]
        public ulong Problem3(ulong p1)
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