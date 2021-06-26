using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<Solutions>();// (typeof(Solutions), methods: new System.Reflection.MethodInfo[] { typeof(Solutions).GetMethod(nameof(Solutions.Problem7)) });

            //var s = new Solutions();
            //s.Problem7(10001);
        }
    }

    [DisassemblyDiagnoser, MemoryDiagnoser]
    public partial class Solutions
    { 
    
    }
}