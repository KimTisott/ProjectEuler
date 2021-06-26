using BenchmarkDotNet.Running;

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<Problem1>();
            BenchmarkRunner.Run<Problem2>();
            BenchmarkRunner.Run<Problem3>();
            BenchmarkRunner.Run<Problem4>();

            //var p1 = new Problem1();
            //var r1 = p1.Solution1(3, 5, 1000);

            //var p2 = new Problem2();
            //var r2 = p2.Solution1(4000000);

            //var p3 = new Problem3();
            //var r3 = p3.Solution1(600851475143);

            //var p4 = new Problem4();
            //var r4 = p4.Solution1(3);
        }
    }
}