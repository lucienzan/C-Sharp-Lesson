using System;
using Delegate2;

namespace MyApp // Note: actual namespace depends on the project name.
{
  public class Program
  {
    public delegate string FilterDelegate(Person p);
    public delegate bool FilterAgeDelegate(Person p);

    static void Main(string[] args)
    {
      Person person1 = new Person() { Age = 17, Name = "Thomas" };
      Person person2 = new Person() { Age = 22, Name = "Daniel" };
      Person person3 = new Person() { Age = 23, Name = "Stebestin" };
      Person person4 = new Person() { Age = 16, Name = "Lucien" };
      List<Person> presonLists = new List<Person>() { person1, person2, person3, person4 };
      //Anonymous method
      //Delegate 2 version - 2
      FilterAgeDelegate filter = delegate (Person p)
      {
        return p.Age >= 18;
      };

      foreach (var person in presonLists)
      {
        DisplayPerson(person.Name, presonLists, IsMinor);
        DisplayPerson(person.Name, presonLists, IsAdult);
      }
      ///Anonymous Method 
      ///Delegate2 version - 2
      DisplayItem("Age upper 18", presonLists, filter);
    }

    static void DisplayPerson(string title, List<Person> people, FilterDelegate filter)
    {
      foreach (var person in people)
      {
        if (filter(person) == "Minor" && person.Name == title)
        {
          Console.WriteLine(@"{0} is {1} years old and he is just a kiddo.", title, person.Age);
        }
        else if (filter(person) == "Adult" && person.Name == title)
        {
          Console.WriteLine(@"{0} is {1} years old and he is adult", title, person.Age);
        }
      }
    }
    ///Anonymous Method 
    ///Delegate2 version - 2
    public static void DisplayItem(string title, List<Person> people, FilterAgeDelegate filter)
    {
      foreach (var person in people)
      {
        if (filter(person))
        {
          Console.WriteLine(@"{0} is {1}", title, person.Name);
        }
      }
    }
    static string IsMinor(Person p)
    {
      string check = p.Age < 18 ? "Minor" : "";

      return check;
    }

    static string IsAdult(Person p)
    {
      string check = p.Age > 18 ? "Adult" : "";
      return check;
    }
  }
}