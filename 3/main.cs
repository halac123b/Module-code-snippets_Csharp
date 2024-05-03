using System;

namespace DateTimeWork
{
  public class Program
  {
    public static void Main()
    {
      // Input date string format
      string date = "2024-05-03T02:36:42.506000Z";

      // Parse string date to DateTime, then format it to a new string
      // Output: "May 03, 2024"
      string formatedDate = DateTime.ParseExact(date, "MM/dd/yyyy HH:mm:ss", null)
                .ToString("MMMM dd, yyyy");

      // Check 1 mốc thời gian có nằm trong 5 phút trước thời điểm hiện tại không
      DateTime datetime = DateTime.ParseExact(date, "MM/dd/yyyy HH:mm:ss", null);
      // TimeSpan: class that represents a time interval
      TimeSpan difference = DateTime.UtcNow - datetime;
      if (difference.TotalMinutes <= 5)
      {
        Console.WriteLine("The datetime is within 5 minutes ago from now.");
      }
      else
      {
        Console.WriteLine("The datetime is NOT within 5 minutes ago from now.");
      }
    }
  }
}
