using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace library
{
    class CADUsuario
    {
        private string conexion;
        //Inicializa la cadena de conexión de la DB.
        public CADUsuario() {
            //Adquiere la cadena de conexión desde un único sitio.
            conexion = "Data Source = MSSQLLocalDB; AttachDbFilename = Database.mdf; Integrated Security = True";
        }

        //Crea un nuevo usuario en la BD con los datos del usuario
        public bool createUsuario(ENUsuario en) {
            SqlConnection c = new SqlConnection(conexion);
            try {
                c.Open();
                SqlCommand com = new SqlCommand("Insert into Usuarios (id, nombre, nif, edad) values (" + 0 + ", 'Stalyn', '20E'," + 22 + ")", c);
            }
            catch (Exception e) {

            }
            return true;
        }

        //Devuelve solo el usuario indicado leído de la DB
        public bool readFirstUsuario(ENUsuario en) {
            return true;
        }

        //Devuelve solo el usuario siguiente al indicado
        public bool readNextUsuario(ENUsuario en) {
            return true;
        }

        //Devuelve solo el usuario anterior al indicado
        public bool readPrevUsuario(ENUsuario en) {
            return true;
        }

        //Actualiza los datos de un usuario en la BD con los datos del
        //usuario por el parámetro en.
        public bool updateUsuario(ENUsuario en) {
            return true;
        }

        //Borra el usuario representado en 'en' de la BD
        public bool deteleUsuario(ENUsuario en) {
            SqlConnection conn = null;
            //Encapsula todo el acceso a datos dentro del try
            String comando = "Delete from Usuario wehere id = " + en.id;

            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sqlex)
            {
                //Envuelve la excepción actual en una excepción más relevante.
                //throw new CADException("Error borrando el cliente.: " + clienteID, sqlex);
            }
            finally
            {
                if (conn != null) conn.Close(); //Se asegura de cerrar la conexión. 
            }

            return true;
        }


        //Ejemplos
        //1.Listar Clientes
        public ArrayList ListarClientes() {
            ArrayList lista = new ArrayList();

            SqlConnection c = new SqlConnection(conexion);
            c.Open();
            SqlCommand com = new SqlCommand("Select * from cliente ", c);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read()) {
                lista.Add(dr["nombre"].ToString());
            }
            dr.Close();
            c.Close();

            return lista;
        }


        
    }
}
