using BenchmarkDotNet.Running;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<Solutions>();
        }
    }
}