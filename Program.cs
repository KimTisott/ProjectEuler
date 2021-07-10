using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            //BenchmarkRunner.Run<Solutions>();

            BenchmarkRunner.Run(typeof(Solutions), typeof(Solutions).GetMethods().Where(x => x.Name.Contains("Problem3")).ToArray());

            //var s = new Solutions();
            //s.Problem3(600851475143);
            //s.Problem3a(600851475143);
        }
    }

    [DisassemblyDiagnoser, MarkdownExporterAttribute.GitHub, MemoryDiagnoser, Orderer(SummaryOrderPolicy.Method, MethodOrderPolicy.Alphabetical)]
    public partial class Solutions
    { 
    
    }
}