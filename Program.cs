#if DEBUG
Problem7 p7 = new() { p1 = 10001 };
var a = p7.A();
var b = p7.B();
;
#elif RELEASE
//BenchmarkRunner.Run<Problem1>();
//BenchmarkRunner.Run<Problem2>();
//BenchmarkRunner.Run<Problem3>();
//BenchmarkRunner.Run<Problem4>();
//BenchmarkRunner.Run<Problem5>();
//BenchmarkRunner.Run<Problem6>();
BenchmarkRunner.Run<Problem7>();
//BenchmarkRunner.Run<Problem8>();
//BenchmarkRunner.Run<Problem9>();
//BenchmarkRunner.Run<Problem10>();
//BenchmarkRunner.Run<Problem11>();
//BenchmarkRunner.Run<Problem12>();
//BenchmarkRunner.Run<Problem13>();
//BenchmarkRunner.Run<Problem14>();
#endif