using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Introduccion_Net_Core.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hola como estas, " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        //GET: /HelloWorld/Presentacion
        //metodo que  recibe 2 parametros
        public string Presentacion(string name = "Default", int edad = 23) 
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, tu edad es: {edad}");
        }

    }
}