using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Access_Modifier_Complex
{
    internal class Complex
    {
    int g;
    int r;
    public void SetData(int num1,int num2){
      g = num1;
      r = num2;
    }

    public void  DisplayData(){
      System.Console.WriteLine("The first g num is {0}", g);
      System.Console.WriteLine("The second r num is {0}", r);
    }
  }
}