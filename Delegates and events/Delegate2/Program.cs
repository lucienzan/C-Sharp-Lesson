using System;
using Delegate2;

namespace MyApp // Note: actual namespace depends on the project name.
{
  public class Program
  {
    public delegate string FilterDelegate(Person p);
    static void Main(string[] args)
    {
      Person person1 = new Person() { Age = 17, Name = "Thomas" };
      Person person2 = new Person() { Age = 22, Name = "Daniel" };
      Person person3 = new Person() { Age = 23, Name = "Stebestin" };
      Person person4 = new Person() { Age = 16, Name = "Lucien" };
      List<Person> presonLists = new List<Person>() { person1, person2, person3, person4 };
      foreach (var person in presonLists)
      {
        DisplayPerson(person.Name, presonLists, IsMinor);
        DisplayPerson(person.Name, presonLists, IsAdult);
      }
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