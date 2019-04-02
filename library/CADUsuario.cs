using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace library
{
    class CADUsuario
    {
        private string conexion;
        //Inicializa la cadena de conexión de la DB.
        public CADUsuario() {
            //Adquiere la cadena de conexión desde un único sitio.
        }

        //Crea un nuevo usuario en la BD con los datos del usuario
        public bool createUsuario(ENUsuario en) {
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
            String comando = "Delete from Cliente wehere id = " + en.nombre;

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
    }
}
