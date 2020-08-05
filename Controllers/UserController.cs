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
using Microsoft.Data.Sqlite;
using System.Text;

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
            return RedirectToAction("Login", "User");
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
                    
                    if (lista.GetString(2) == "Admin"){
                        Usuario.getInstancia().UsuarioIsAdmin = true;
                        return RedirectToAction("Index", "Home");
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

        

        [HttpPost]
        
        public IActionResult DameMes(string mes)

        {    
            Database conexion = Database.getInstancia();

            Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetBithdayData(mes);
             
             var builder = new StringBuilder();
            builder.AppendLine("Nombre,Apellido,Correo");

            while(lista.Read()){

               Console.WriteLine(lista.GetString(0));
                Console.WriteLine(lista.GetString(1));
                Console.WriteLine(lista.GetString(2));
     
                builder.AppendLine($"{lista.GetString(0)},{lista.GetString(1)},{lista.GetString(2)}");

                }

                ViewBag.Mes = mes;

              return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Usuario.csv");
        
           

        }
          [HttpGet]
        public IActionResult DameMes(){
        
        return View();
            
        }
            

            public FileResult CSV(){

                Database conexion = Database.getInstancia();
                
                
                 Microsoft.Data.Sqlite.SqliteDataReader lista = conexion.GetBithdayData(ViewBag.Mes);

              Console.WriteLine(lista.HasRows);
              //List<User> Lista = BirthdaysListAsync(Month);


            var builder = new StringBuilder();
            builder.AppendLine("Nombre,Apellido,Correo");

                 List<string[]> Lista = new List<string[]>();
                 
                     while (lista.Read())
                {
                    string[] SqlArray = new string[lista.FieldCount];
                    for (int i = 0; i < lista.FieldCount; i++)
                    {
                        SqlArray[i] = lista[i].ToString();
                    }
                    Lista.Add(SqlArray);

                }
                foreach (var item in Lista)
            {
                builder.AppendLine($"{item[0]},{item[1]},{item[2]}");
            }

     

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Usuario.csv");

            }

        }

    }



