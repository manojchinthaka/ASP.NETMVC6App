using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETMVC6App.Services
{
    public class GreetingServices:IGreetingServices
    {
        public string getGreeting()
        {
            return "Good Morning >>> Manoj Weerasooriya";
        }
  
    }
}
