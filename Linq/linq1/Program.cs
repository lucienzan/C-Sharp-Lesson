using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
      int[] numbers = { 1, 2, 3, 5, 4, 5, 6, 7, 8, 9, 10 };
      Dictionary<string, string> datas = new Dictionary<string, string>
      {
        {"1","999x999x999"},
        {"2","999x999x999"},
        {"3",null},
        {"4","99Gx889x999"},
      };
      
      Oddnumbers(numbers);
      var query = from data in datas where data.Value != null select data;
      foreach(var value in query){
        System.Console.WriteLine(value);
      }
    }
        static void Oddnumbers(int[] numbers)
        {
      IEnumerable<int> oddnums = from num in numbers where num % 2 != 0 select num;
      foreach(int num in oddnums){
        System.Console.WriteLine(num);
      }
    }
    }
}