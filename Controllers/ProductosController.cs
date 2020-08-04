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
    public class ProductosController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public ProductosController(IWebHostEnvironment IHostingEnvironment)
        {
            _environment = IHostingEnvironment;
        }

        [HttpGet]
        public IActionResult Productos(string Categoria_Producto)
        {
            ViewBag.Categoria = Categoria_Producto;
            return View();
        }
        public IActionResult ProductoAdmin()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewProducto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewProducto(string Codigo_Producto, string Nombre_Producto, string Precio_Producto, string Existencia_Producto, string Categoria_Producto)
        {
            var newFileName = string.Empty;

            if (HttpContext.Request.Form.Files != null)
            {
                var nombreArchivo = string.Empty;
                string PathDB = string.Empty;

                var files = HttpContext.Request.Form.Files;

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        nombreArchivo = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var nombreId = Convert.ToString(Guid.NewGuid());
                        var FileExtension = Path.GetExtension(nombreArchivo);
                        newFileName = nombreId + FileExtension;
                        nombreArchivo = Path.Combine(_environment.WebRootPath, "images") + $@"\{newFileName}";
                        PathDB = "images/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(nombreArchivo))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }


            }

                Database Conexion = Database.getInstancia();
                string script = "INSERT INTO Productos(CodArticulo, Nombre, Precio_Unitario, Existentes,"+
                "Categoria, Imagen) VALUES('"+
                Codigo_Producto+"','"+ 
                Nombre_Producto+"','"+ 
                Precio_Producto+"','"+ 
                Existencia_Producto+"','"+
                Categoria_Producto+"','"+
                newFileName+"')";
                
                Console.WriteLine(script);

                Conexion.InsertData(script);

            return View();
        }

        [HttpGet]
        public IActionResult UpdateProducto(string Codigo_Producto)
        {
            ViewBag.Codigo_Producto = Codigo_Producto;
            
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProducto(string Codigo_Producto, string Nombre_Producto, string Precio_Producto, string Existencia_Producto, string Categoria_Producto)
        {
            var newFileName = string.Empty;

            if (HttpContext.Request.Form.Files != null)
            {
                var nombreArchivo = string.Empty;
                string PathDB = string.Empty;

                var files = HttpContext.Request.Form.Files;

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        nombreArchivo = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var nombreId = Convert.ToString(Guid.NewGuid());
                        var FileExtension = Path.GetExtension(nombreArchivo);
                        newFileName = nombreId + FileExtension;
                        nombreArchivo = Path.Combine(_environment.WebRootPath, "images") + $@"\{newFileName}";
                        PathDB = "images/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(nombreArchivo))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            } 

                Database Conexion = Database.getInstancia();

                string script="";

                if(newFileName==""){
                    script = "UPDATE Productos SET Nombre='"+Nombre_Producto+"', Precio_Unitario='"+Precio_Producto
                    +"', Existentes='"+Existencia_Producto+"', Categoria='"+Categoria_Producto+"'"
                    +" WHERE CodArticulo= '"+Codigo_Producto+"';";
                } else{
                    script = "UPDATE Productos SET Nombre='"+Nombre_Producto+"', Precio_Unitario='"+Precio_Producto
                    +"', Existentes='"+Existencia_Producto+"', Categoria='"+Categoria_Producto+"', Imagen='"+newFileName+"'"
                    +" WHERE CodArticulo= '"+Codigo_Producto+"';";
                }

                
                Console.WriteLine(script);
                Conexion.InsertData(script);

            return RedirectToAction("ProductoAdmin", "Productos");
        }

        [HttpGet]
        public IActionResult DeleteProducto(string Codigo_Producto)
        {
            Database Conexion = Database.getInstancia();

            string script = "DELETE FROM Productos WHERE CodArticulo='"+Codigo_Producto+"';";
            
            Console.WriteLine(script);
            Conexion.InsertData(script);

            
            return RedirectToAction("ProductoAdmin", "Productos");
        }
    }
}
