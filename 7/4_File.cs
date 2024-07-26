using System.IO;
using System;

class Program
{
  static void Module4(string[] args)
  {
    // Bool, check xem file đó có tồn tại hay k
    Console.WriteLine(File.Exists("path/to/file.txt"));

    byte[] data = { 0x00, 0x01, 0x02, 0x03, 0x04 };
    // Write và save một chuỗi byte vào 1 file
    File.WriteAllBytes("path/to/file.txt", data);
  }
}