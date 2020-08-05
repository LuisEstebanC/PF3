using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final.Models;

namespace Final.Controllers
{
    public class CarritoController : Controller
    {
        [HttpGet]
        public IActionResult AgregarCarrito(string idProducto)
        {
            Database Conexion = Database.getInstancia();

            string script = "INSERT INTO Carrito(idUsuario, idProducto) VALUES('" +
            Usuario.getInstancia().IdUser + "','" +
            idProducto + "')";

            Console.WriteLine(script);
            
            Conexion.InsertData(script);

            return RedirectToAction("Productos", "Productos");

            

        }
             

        public IActionResult Carrito()
        {



            return View();
        }

    }


}