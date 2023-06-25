// See https://aka.ms/new-console-template for more information
using System;
using Access_Modifier;
using Access_Modifier_Person;
using Access_Modifier_Complex;


namespace MyApp // Note: actual namespace depends on the project name.
{
  public class Program : Item
  {

    static void Main(string[] args)
    {
      Person person = new Person();
      person.GetPersonId();
      Home home = new Home();
      home.GetItem();
      Complex complex = new Complex();
      complex.SetData(6, 8);
      complex.DisplayData();
      Program program = new Program();
      program.value = 12;
      System.Console.WriteLine(program.value);
      //System.Console.WriteLine(person.Age); // Error
    }
  }
}