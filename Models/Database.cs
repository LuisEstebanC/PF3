using System;
using Microsoft.Data.Sqlite;

namespace Final.Models
{
    public class Database
    {
        private static Database instancia;
        public static SqliteConnectionStringBuilder connectionStringBuilder;
        public static SqliteConnection connection;
        public static Database getInstancia() {
            if(instancia == null){
                instancia = new Database();

                connectionStringBuilder = new SqliteConnectionStringBuilder();
                connectionStringBuilder.DataSource = "./Supermercado.db";
                connection = new SqliteConnection(connectionStringBuilder.ConnectionString);

            }
            return instancia;
        }

        public void InsertData(string Consulta){

            connection.Open();
            
            var insertCmd = connection.CreateCommand();

            insertCmd.CommandText = Consulta ;
            insertCmd.ExecuteNonQuery();
            
            connection.Close();
            
        }

            public SqliteDataReader GetData(){

            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Productos";

            var reader = selectCmd.ExecuteReader();

            return reader;
            
        }

        public SqliteDataReader GetCategorias(){

            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT DISTINCT Categoria FROM Productos";

            var reader = selectCmd.ExecuteReader();

            return reader;
            
        }

        public SqliteDataReader GetProductoCategorias(string Categoria){

            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Productos WHERE Categoria = '"+Categoria+"';";

            var reader = selectCmd.ExecuteReader();

            return reader;
            
        }

            public SqliteDataReader GetData(string Query){

            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = Query;

            var reader = selectCmd.ExecuteReader();

            return reader;
            
        }

        public SqliteDataReader GetUserAuthentication(string Correo_User, string Password_User){

            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT correo, password, rol FROM Usuario WHERE correo='"+Correo_User+"' AND password='"+Password_User+"';";
            
            var reader = selectCmd.ExecuteReader();

            return reader;
        }

        public SqliteDataReader GetUserEmail(string Correo_User){

            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT correo FROM Usuario WHERE correo='"+Correo_User+"';";

            var reader = selectCmd.ExecuteReader();

            return reader;
        }

        public SqliteDataReader GetBithdayData(string mes)
        {


            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT nombre,apellido,correo, strftime('%m',Fecha_nacimiento) FROM Usuario WHERE strftime('%m',Fecha_nacimiento) = '" + mes + "';";

            var reader = selectCmd.ExecuteReader();

            return reader;

        }
    }
}