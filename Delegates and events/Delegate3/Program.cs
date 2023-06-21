using Delegate3;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
      static void Main(string[] args)
      {
      Console.WriteLine("Set up your username");
      var name = Console.ReadLine();
      Person person = new Person(name);
      Home home = new Home(person);

      Console.WriteLine("Want to go to the kitchen? x : o");
      var check = string.Empty;
      check = Console.ReadLine();
      if (check == "o")
      {
        var navigateToKitchen = UserManager.GoToKitchen();
        System.Console.WriteLine(navigateToKitchen);
      }else{
        System.Console.WriteLine("{0} does not want to go to the kitchen room.",person.Name);
      }
      Console.Read();
      Console.WriteLine("Are you sure to exit? x : o");
      check = Console.ReadLine();
      if (check == "o" || check == "O")
      {
        UserManager.GetExit();
      }
    }
    }
}
