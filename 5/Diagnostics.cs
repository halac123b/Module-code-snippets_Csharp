using System;
using System.Diagnostics;

public class Diagnostics
{
  private void TestPerformance()
  {
    // Tạo 1 obj Stopwatch và khởi động lên
    Stopwatch stopwatch = Stopwatch.StartNew();
    stopwatch.Start();

    // Thực hiện các task tiêu tốn thời gian

    stopwatch.Stop();

    // Get thời gian đồng hồ chạy đc tính bằng ms
    long elapsedTimeMilisceond = stopwatch.ElapsedMilliseconds;
    Console.WriteLine($"Time worked {elapsedTimeMilisceond}");
  }
}
