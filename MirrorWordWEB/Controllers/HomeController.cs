using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MirrorWordBLL.interfaces;
using MirrorWordDAL.Entities;
using MirrorWordDAL.interfaces;
using MirrorWordWEB.Models;

namespace MirrorWordWEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepositoryGetUser<RegisterUser> _repositoryGetUser;

        private readonly IValidServicePolindrom _repositoryPolindrom;
        public HomeController(IRepositoryGetUser<RegisterUser> repositoryGetUser, IValidServicePolindrom repositoryPolindrom)
        {
            _repositoryGetUser = repositoryGetUser ?? throw new ArgumentNullException();
            _repositoryPolindrom = repositoryPolindrom ?? throw new ArgumentNullException();
        }
   
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string password, string name)
        {
            var users = _repositoryGetUser.GetUsers() ?? throw new ArgumentNullException();

            foreach(var item in users )
            {
                if(item.Name==name && item.Password==password)
                {
                    return View("Polindrom");
                }
            }

            return View("Login");
        }

        public IActionResult Polindrom(string wordValue)
        {
            var isValid =_repositoryPolindrom.IsPalindrome(wordValue);

            if(isValid==true)
            {
                ViewData["Polindrom"] = "Result: TRUE";
            }
            else
            {
                ViewData["Polindrom"] = "Result: FALSE";
            }
          
            return View();
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
