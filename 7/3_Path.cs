using System.IO;
using System;

class Program
{
  static void Module3(string[] args)
  {
    // Kí tự để ngăn cách trong Path, tùy vào OS (/ hoặc \)
    Console.WriteLine(Path.DirectorySeparatorChar);

    string path1 = @"C:\Users\";
    string path2 = @"\Documents";
    // Combine 2 path, nối path2 vào path1
    /// → C:\Users\Documents
    Console.WriteLine(Path.Combine(path1, path2));
    /// Nếu path2 là absolute, tức không nối đc, hàm trả về path2 → C:\Documents
    path2 = @"C:\Documents";

    path1 = @"C:\Users\file.txt";
    // Lấy tên file từ path → file.txt
    Console.WriteLine(Path.GetFileName(path1));
  }
}