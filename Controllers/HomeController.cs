using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final.Models;
using Microsoft.Data.Sqlite;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
        public async Task<IActionResult> Ubicacion(Persona persona, string Cedula)
        {


            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";
            Persona per = await API.consultarAsync(Cedula);
            ViewBag.ok = true;
            int idUsuario = persona.idUsuario;
            string Comentario = persona.Comentario;
            string Estado = persona.Estado;
            double lat = persona.lat;
            double lng = persona.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "INSERT INTO Pedidos (idUsuario,Estado,Comentario,lat, lng) VALUES('" + idUsuario + "' ,'Retenido','" + Comentario + "','" + lat + "','" + lng + "');";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();
            }
            ViewBag.idUsuario = persona.idUsuario;
            ViewBag.Estado = persona.Estado;
            ViewBag.Comentario = persona.Comentario;
            ViewBag.lat = persona.lat;
            ViewBag.lng = persona.lng;


            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {
                Conexion.Open();
                string Consulta = "SELECT  lat, lng, Comentario FROM Pedidos WHERE idUsuario ='" + idUsuario + "';";
                var Comando = new SqliteCommand(Consulta, Conexion);
                var Reader = Comando.ExecuteReader();

                List<string[]> datos = new List<string[]>();
                while (Reader.Read())
                {

                    string Lat = String.Format("{0}", Reader["lat"]);
                    string Lng = String.Format("{0}", Reader["lng"]);
                    string Comentarios = String.Format("{0}", Reader["Comentario"]);

                    string[] data = { Cedula, Lat, Lng, Comentarios };
                    datos.Add(data);
                }
                ViewBag.lenght = datos.Count();
                ViewBag.data = datos;
                Conexion.Close();

            }


            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Query = "SELECT idUsuario, Estado FROM Pedidos WHERE idUsuario ='" + idUsuario + "';";
                var ComandoSalida = new SqliteCommand(Query, Conexion);
                var Reader = ComandoSalida.ExecuteReader();

                while (Reader.Read())
                {
                    ViewBag.idUsuario = String.Format("{0}", Reader["idUsuario"]);
                    ViewBag.Estado = String.Format("{0}", Reader["Estado"]);

                }
                Conexion.Close();

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
