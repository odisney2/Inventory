/*
    Orris Disney II
    C# Inventory Project
    July 2018
    
    Definition of a Controller
    Asp.net MVC Controllers are responsible for controlling the flow of the application execution. When you make a request (means request a page) 
    to MVC application, a controller is responsible for returning the response to that request.

    This is for the main home page
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}