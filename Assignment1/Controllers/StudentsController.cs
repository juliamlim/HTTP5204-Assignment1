using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Julia()
        {
            Student me = new Student();
            me.Name = "Julia M Lim";
            me.Number = "n01156110";
            me.Email = "juliamlim@hotmail.com";
            me.Program = "Web Development";
            return View(me);
        }
    }
}