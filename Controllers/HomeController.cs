namespace app_mvc.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}