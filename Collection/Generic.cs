using System;

namespace Collection 
{

    internal class Generic
    {
        static void Main(string[] args)
        {
      int[] intNum = { 1, 4, 5, 2, 8 };
      string[] stringNum = { "6", "3", "99", "45" };
      double[] doubleNum = { 1.4, 4.5, 2.6, 55.3 };
      DisplayInConsole(ref doubleNum);
    }

    //public static void DisplayInConsole(int[] numbers)
    //  {
    //        foreach(var num in numbers)
    //        Console.Write(num);
    //}

    /// <summary>
    ///Generic - not specific to a particular data type  
    ///add <T> to class, methods, fields etc, 
    ///allows for code resuseability for different data types
    /// </summary>
    /// <param name="numbers">The sender<see cref="array"/>.</param>

      public static void DisplayInConsole<T>(ref T[] numbers)
      {
            foreach(var num in numbers)
            Console.Write(num);
      }

    }
}