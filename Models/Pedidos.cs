using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Pedidos
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idOrdenPago { get; set; }
        public int idproducto { get; set; }
        public string Estado { get; set; }
        public string Comentario { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

    }

}