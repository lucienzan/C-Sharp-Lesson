
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    public enum Year
    {
      January,
      February = 2, 
      March,
      April,
      May = 7,
      June,
      July
    }
    static void Main(string[] args)
    {

      System.Console.WriteLine((int)Year.January); // 0
      System.Console.WriteLine(Year.March); //March
      System.Console.WriteLine((int)Year.February); //2
      System.Console.WriteLine((int)Year.May); //7
      System.Console.WriteLine("<----->");
      foreach (var item in Enum.GetValues(typeof(Year))){
        System.Console.WriteLine(item.ToString());
      }
    }
  }
}
