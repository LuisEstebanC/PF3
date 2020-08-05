using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Persona
    {
        public int idUsuario { get; set; }
        public string Estado { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Comentario { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

    }

}