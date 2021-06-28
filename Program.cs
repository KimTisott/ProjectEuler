using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<Solutions>();

            //BenchmarkRunner.Run(typeof(Solutions), typeof(Solutions).GetMethods().Where(x => x.Name.Contains("Problem9") || x.Name.Contains("Problem10")).ToArray());

            //var s = new Solutions();
            //s.Problem10(2000000);
            //s.Problem10a(2000000);
        }
    }

    [DisassemblyDiagnoser, MemoryDiagnoser]
    public partial class Solutions
    { 
    
    }
}