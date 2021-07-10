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
            BenchmarkRunner.Run<Solutions>();

            //BenchmarkRunner.Run(typeof(Solutions), typeof(Solutions).GetMethods().Where(x => x.Name.Contains("Problem12")).ToArray());

            //var s = new Solutions();
            //s.Problem14(1000000);
            //s.Problem14a(1000000);
        }
    }

    [DisassemblyDiagnoser, MarkdownExporterAttribute.GitHub, MemoryDiagnoser, Orderer(SummaryOrderPolicy.Method, MethodOrderPolicy.Alphabetical)]
    public partial class Solutions
    { 
    
    }
}