public class Problem3 : BaseSolution
{
    [Params(600851475143)]
    public long p1;

    [Benchmark]
	public long A()
	{
		long result = p1;

		for (long counter = 5; counter * counter <= result; counter += 4)
		{
			if (result % counter == 0)
			{
				result /= counter;
			}

			counter += 2;

			if (counter * counter > result)
            {
				break;
            }

			if (result % counter == 0)
			{
				result /= counter;
			}
		}

		return result;
    }

    [Benchmark]
    public override long Result() => 6857;
}