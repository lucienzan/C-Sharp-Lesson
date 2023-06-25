using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Access_Modifier_Person;
using Access_Modifier_Complex;

namespace Access_Modifier
{
    public class Home : Person
    {
    public void GetItem() {
      System.Console.WriteLine(Vase);
    }
  }
}