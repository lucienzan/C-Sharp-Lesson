using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegate3
{
    public class Home
    {
    private Person _person;
    public Home(Person person)
    {
      UserManager.GoToKitchen += GoToKitchen;
      UserManager.GetExit += GoToExit;
      _person = person;
    }
    private string GoToKitchen()
        {
          return _person.Name+" is going to the kitchen";
        }

        private void GoToExit()
        {
          Console.WriteLine("User has exited");
        }
    }
}