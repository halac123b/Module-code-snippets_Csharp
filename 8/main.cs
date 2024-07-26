using System;
using System.Globalization;

public class Globalization
{
  private void FloatConversion()
  {
    // InvariantCulture: 1 instance có sẵn giúp ignore các setting của máy (vd, setting date time, string,..), giúp các thao tác đc diễn ra đồng nhất
    /// Vd: khi parse string thành float, nhiều máy setting mặc định là dấu "," sẽ cho kết quả sai
    Console.WriteLine(float.Parse("2.5", CultureInfo.InvariantCulture));
  }
}