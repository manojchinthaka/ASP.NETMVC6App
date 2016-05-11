using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETMVC6App.Services;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NETMVC6App.Controllers
{
    public class GreetingController : Controller
    {
        private IGreetingServices _igreetingService;

        //private GreetingServices _greetingService;


        public GreetingController(IGreetingServices greeting)
        {
            // _greetingService = new Services.GreetingServices();
            _igreetingService = greeting;
        }



        // GET: /<controller>/
        public IActionResult Index()
        {
            //ViewData["message"] = "Hello Manoj Weerasooriya";
            //ViewData["messaage"] = _greetingService.getGreeting();
           ViewData["message"] = _igreetingService.getGreeting();
            return View();
        }
    }
}
