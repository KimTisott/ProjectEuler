using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            //BenchmarkRunner.Run<Solutions>();

            BenchmarkRunner.Run(typeof(Solutions), typeof(Solutions).GetMethods().Where(x => x.Name.Contains("Problem9")).ToArray());

            //var s = new Solutions();
            //s.Problem9(1000);
            //s.Problem9a(1000);
        }
    }

    [DisassemblyDiagnoser, MemoryDiagnoser]
    public partial class Solutions
    { 
    
    }
}