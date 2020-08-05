using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Data.Sqlite;
using Final.Models;

namespace Final.Controllers
{
    public class PedidosController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetUbicaciones(Pedidos pedidos)
        {


            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;









            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {
                Conexion.Open();
                string Consulta = "SELECT  lat, lng, Comentario FROM Ubicaciones WHERE idOrdenPago ='";
                var Comando = new SqliteCommand(Consulta, Conexion);
                var Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    ViewBag.lat = String.Format("{0}", Reader["lat"]);
                    ViewBag.lng = String.Format("{0}", Reader["lng"]);
                    ViewBag.Comentario = String.Format("{0}", Reader["Comentario"]);

                }
                Conexion.Close();
            }

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Query = "SELECT id,idOrdenPago,idProducto, Estado,comentario FROM Pedidos  ='";
                var ComandoSalida = new SqliteCommand(Query, Conexion);
                var Reader = ComandoSalida.ExecuteReader();

                while (Reader.Read())
                {
                    ViewBag.Estados = String.Format("{0}", Reader["id"]);
                    ViewBag.idOrdenPagos = String.Format("{0}", Reader["idOrdenPago"]);
                    ViewBag.Estados = String.Format("{0}", Reader["idproducto"]);
                    ViewBag.Estados = String.Format("{0}", Reader["Estado"]);
                    ViewBag.Estados = String.Format("{0}", Reader["comentarrio"]);


                }
                Conexion.Close();



                return View();


            }




        }
        public IActionResult Completado(Pedidos pedidos)
        {
            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            int idUsuario = pedidos.idUsuario;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "UPDATE pedidos set Estados ='Completado'WHERE idUsuario='" + idUsuario + "'";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();


                return View();
            }
        }
        public IActionResult Procesado(Pedidos pedidos)
        {
            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            int idUsuario = pedidos.idUsuario;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "UPDATE pedidos set Estados ='Procesado'WHERE id='" + idUsuario + "'";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return View();
            }

        }


        public IActionResult Solicitado(Pedidos pedidos)
        {
            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            int idUsuario = pedidos.idUsuario;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "UPDATE pedidos set Estados ='Solicitado'WHERE id='" + idUsuario + "'";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return View();



            }






        }


        public IActionResult CompletadoFilter(Pedidos pedidos)
        {
            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            int idUsuario = pedidos.idUsuario;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "SELECT  lat, lng, FROM Pedidos WHERE Estado ='Completado' '";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                var Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    ViewBag.lat = String.Format("{0}", Reader["lat"]);
                    ViewBag.lng = String.Format("{0}", Reader["lng"]);


                }






                Conexion.Close();

                return View();
            }
        }


        public IActionResult ProcesadoFilter(Pedidos pedidos)
        {
            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            int idUsuario = pedidos.idUsuario;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "SELECT  lat, lng, FROM Pedidos WHERE Estado ='Procesado' '";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                var Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    ViewBag.lat = String.Format("{0}", Reader["lat"]);
                    ViewBag.lng = String.Format("{0}", Reader["lng"]);


                }
                Conexion.Close();


                return View();
            }





        }

        public IActionResult SolicitadoFialter(Pedidos pedidos)
        {
            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            int idUsuario = pedidos.idUsuario;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "SELECT  lat, lng, FROM Pedidos WHERE Estado ='Solicitado' '";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                var Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    ViewBag.lat = String.Format("{0}", Reader["lat"]);
                    ViewBag.lng = String.Format("{0}", Reader["lng"]);


                }
                Conexion.Close();


                return View();
            }


        }
        public IActionResult EnviadoFilter(Pedidos pedidos)
        {
            var connectionBuielder = new SqliteConnectionStringBuilder();
            connectionBuielder.DataSource = "Supermercado.db";

            int id = pedidos.id;
            int idUsuario = pedidos.idUsuario;
            string idOrdenPago = pedidos.Comentario;
            string Estado = pedidos.Estado;
            double lat = pedidos.lat;
            double lng = pedidos.lng;

            using (var Conexion = new SqliteConnection(connectionBuielder.ConnectionString))
            {

                Conexion.Open();
                string Consulta = "SELECT  lat, lng, FROM Pedidos WHERE Estado ='Enviado' '";
                var Comando = new SqliteCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                var Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    ViewBag.lat = String.Format("{0}", Reader["lat"]);
                    ViewBag.lng = String.Format("{0}", Reader["lng"]);

                }
                Conexion.Close();


                return View();
            }
        }
    }
}