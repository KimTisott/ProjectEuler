using BenchmarkDotNet.Attributes;
using System;

namespace ProjectEuler
{
	public partial class Solutions
	{
        [Arguments(600851475143), Benchmark]
		public ulong Problem3(ulong p1)
		{
			ulong result = p1;

			for (ulong counter = 5; counter * counter <= result; counter += 4)
			{
				if (result % counter == 0)
				{
					result = (ulong)(result * (1.0 / counter));
				}
				
				counter += 2;

				if (counter * counter > result)
                {
					break;
                }

				if (result % counter == 0)
				{
					result = (ulong)(result * (1.0 / counter));
				}
			}

			return result;
		}
	}
}