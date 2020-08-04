using System;
using Microsoft.Data.Sqlite;

namespace Final.Models
{
    public class Usuario
    {
        private static Usuario instancia;

        public static Usuario getInstancia() {
            if(instancia == null){
                instancia = new Usuario();

            }
            return instancia;
        }
        
        public bool UsuarioAuthentication { get; set; }
        public bool UsuarioIsAdmin { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Correo { get; set; }
    }
}