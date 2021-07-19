using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Net5.Demo1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Net5.Demo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _logger.LogWarning("logger被构造");
        }

        public IActionResult Index()
        {
            base.TempData["aaa"] = "张三";
            if (HttpContext.Session.GetString("user") == null)
            {
                HttpContext.Session.SetString("user", "张三");
            }
            var a=  _configuration.GetConnectionString("constr1");
            var b = _configuration["Logging:LogLevel:Default"];
            _logger.LogDebug("出现bug了，Home/Index");
            
            return View();
        }

        public void Index1(int i)
        {
            
        }
        public void Index2(string i)
        {
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
