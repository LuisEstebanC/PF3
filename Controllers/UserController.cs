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
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            Usuario.getInstancia().UsuarioAuthentication = false;
            Usuario.getInstancia().UsuarioIsAdmin = false;
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public IActionResult Registrar(string Nombre_User, string Apellido_User, string Correo_User, string Password_User, DateTime FechaNacimiento_User, string Telefono_User)
        {
            Console.WriteLine(Nombre_User + Apellido_User + Correo_User+ Password_User+ FechaNacimiento_User+ Telefono_User);
                Database Conexion = Database.getInstancia();
                string script = "INSERT INTO Usuario(nombre, apellido, telefono, Fecha_nacimiento, correo, password, rol"+
                ") VALUES('"+
                Nombre_User+"','"+ 
                Apellido_User+"','"+ 
                Telefono_User+"','"+ 
                FechaNacimiento_User+"','"+
                Correo_User+"','"+
                Password_User+"','"+
                "Cliente"+"')";
                
                Console.WriteLine(script);

                Conexion.InsertData(script);

            return RedirectToAction("Login","User");
        }

        [HttpGet]
        public IActionResult Login()
        {
            ErrorViewModel.ErrorLogin = false;
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Correo_User, string Password_User)
        {    
            Database conexion = Database.getInstancia();

            Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetUserAuthentication(Correo_User,Password_User);

                        
            if(lista.HasRows){
                while(lista.Read()){
                    Usuario.getInstancia().UsuarioAuthentication = true;
                    if(lista.GetString(2) == "Admin"){
                        Usuario.getInstancia().UsuarioIsAdmin = true;
                    }
                }
                RedirectToAction("Index","Home");
            }else{
                ErrorViewModel.ErrorLogin = true;
                Usuario.getInstancia().UsuarioAuthentication = false;
                Usuario.getInstancia().UsuarioIsAdmin = false;
            }

            return View();
        }

        [HttpGet]
        public IActionResult AgregarAdmin()
        {
            ErrorViewModel.ErrorAdmin = false;
            return View();
        }

        [HttpPost]
        public IActionResult AgregarAdmin(string Correo_User)
        {    
            Database conexion = Database.getInstancia();

            Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetUserEmail(Correo_User);

                        
            if(lista.HasRows){
                string script = "UPDATE Usuario SET rol='Admin' WHERE correo= '"+Correo_User+"';";
                Console.WriteLine(script);
                conexion.InsertData(script);
                ErrorViewModel.CompletadoAdmin = true;
                
            }else{
                ErrorViewModel.ErrorAdmin = true;
            }

            return View();
        }

        

/*         [HttpPost]
        public IActionResult GetBirthday(int mes)
        {    
            Database conexion = Database.getInstancia();

            Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetBithdayData(mes);

            
            while (lista.Read())
            {
                @lista.GetString(0);
                
            }

            return View();
        } */

    }


}
