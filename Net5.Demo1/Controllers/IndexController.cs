using IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5.Demo1.Controllers
{
    public class IndexController : Controller
    {
        public IConfiguration configuration;
        public IAdminUser adminUser;
        public IndexController(IConfiguration configuration,IAdminUser adminUser)
        {
            this.configuration = configuration;
            this.adminUser = adminUser;
        }
        public IActionResult Index()
        {
          var str =  configuration["Logging"];
          bool a=  adminUser.Login("admin","123");
            return View();
        }
    }
}
