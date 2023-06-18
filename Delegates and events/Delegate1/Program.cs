using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
      List<string> names = new List<string>() { "Thomas", "Alice", "Taylor", "Lucien", "Steven", "Harley", "Abigal", "Louis", "Shawn" };
      //when you use a removeAll predicate that is just the name of the delegate 
      ///<summary>
      ///predicate that takes an object of T, 
      ///T which means specific types.
      ///In our case, T is the type of our string list elements
      ///and return bools element
      /// </summary>
      names.RemoveAll(Filter);
      foreach(var name in names)
      {
        System.Console.WriteLine(name);
      }
    }
    static bool Filter(string s)
    {
      return s.Contains("o");
    }

    
    }
}