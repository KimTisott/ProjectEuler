using BenchmarkDotNet.Attributes;
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

    [DisassemblyDiagnoser, MemoryDiagnoser]
    public partial class Solutions
    { 
    
    }
}