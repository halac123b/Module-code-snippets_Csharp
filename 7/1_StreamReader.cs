using System.IO;
using System;

class Program
{
  static void Main(string[] args)
  {
    // Verbatim string allow not need to escape special character
    string fileName = @"C:\file.txt";

    try
    {
      // Tạo 1 obj StreamWriter mới từ tên 1 file có sẵn
      using (StreamReader writer = new(fileName))
      {
        string line;
        // Read line by line
        while ((line = reader.ReadLine()) != null)
        {
          Console.WriteLine(line);
        }

        // Read toàn bộ file 1 lần
        string wholeFile = reader.ReadToEnd();
      }
    }
    catch (Exception exp)
    {
      Console.Write(exp.Message);
    }
  }
}

