using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Access_Modifier_Person
{
    public class Person
    {
    private int Id = 667334;
    protected string Vase = "A beautiful vase";
    public void GetPersonId(){
    System.Console.WriteLine(Id);
    }
  }
}