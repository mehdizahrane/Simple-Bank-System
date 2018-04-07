using System;
using Microsoft.AspNetCore.Mvc;

namespace Simple_Bank_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();
    }
}