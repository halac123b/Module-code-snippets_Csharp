using System.IO;
using System;

// Verbatim string allow not need to escape special character
string fileName = @"C:\file.txt";

// Nếu file chưa tồn tại thì tạo mới
// StreamWriter writer = new(newFileName, FileMode.OpenOrCreate);

try
{
  // Tạo 1 obj StreamWriter mới từ tên 1 file có sẵn
  using (StreamWriter writer = new(fileName))
  {
    // Write string vào stream, ghi đè lên nội dung của file
    writer.Write("This file contains C# Corner Authors.");
  }
}
catch (Exception exp)
{
  Console.Write(exp.Message);
}

// Tạo từ 1 FileStream
FileStream stream = new(@"C:\newFile.txt", FileMode.CreateNew);
// Create a StreamWriter from FileStream
using (StreamWriter writer = new(stream))
{
  writer.Write("Hello StreamWriter");
}

