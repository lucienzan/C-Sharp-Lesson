using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delegate3
{
  public static class UserManager{
    public delegate string GetUser();
    public delegate void GetStop();
    public static GetUser ? GetuserName,GoToKitchen;
    public static GetStop ?GetExit;

    public static void GetTriggerToExit(){
        if(GetExit != null)
        {
            GetExit();
        }
    }

    public static void GetUserToKitchen() {
        if(GoToKitchen != null){
            GoToKitchen();
        }
    }
  }
}