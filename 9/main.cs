using System;
using System.Reflection;

public class Reflection
{
  private void GetInfoClass()
  {
    Fashion fashionInstance = new Fashion
    {
      Style = "Casual",
      Brand = "BrandA",
      Season = "Summer"
    };

    // Get the Type object for Fashion
    Type fashionType = typeof(Fashion);

    // Lấy các field Public và Instance của class
    /// Instance: các biến
    FieldInfo[] fields = fashionType.GetFields(BindingFlags.Public | BindingFlags.Instance);

    foreach (FieldInfo field in fields)
    {
      string fieldName = field.Name;  // Tên của field
      object fieldValue = field.GetValue(fashionInstance);  // Lấy giá trị của field của 1 instance cụ thể
      Console.WriteLine($"Field: {fieldName}, Value: {fieldValue}");
    }
  }
}