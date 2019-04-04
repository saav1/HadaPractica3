using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows;

namespace library
{
    public class CADUsuario
    {
        private string conexion;
        //Inicializa la cadena de conexión de la DB.
        public CADUsuario() {
            //Adquiere la cadena de conexión desde un único sitio.
            conexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EPS\Desktop\HadaPractica3\hada-p3\App_Data\Database.mdf;Integrated Security=True";
        }


        //Crea un nuevo usuario en la BD con los datos del usuario
        public bool createUsuario(ENUsuario en) {
            ENUsuario cl = en;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand com = new SqlCommand(@"INSERT INTO Usuarios(nif,nombre,edad) VALUES('" + en.NIF + "','" + en.NOMBRE + "','" + en.EDAD + "')", conn);
                com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
            return true;
        }
        public bool readUsuario(ENUsuario en) {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand com = new SqlCommand(@"SELECT * FROM Usuarios where Usuarios.nif = '" +en.NIF+ "'", conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                { 
                    en.NOMBRE = dr["nombre"].ToString();
                    en.EDAD = (Int32)dr["edad"];
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
            return true;
        }
        //Devuelve solo el usuario indicado leído de la DB
        public bool readFirstUsuario(ENUsuario en) {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand com = new SqlCommand(@"SELECT TOP 1 * FROM Usuarios", conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read()) {
                    en.NIF = dr["nif"].ToString();
                    en.NOMBRE = dr["nombre"].ToString();
                    en.EDAD = (Int32)dr["edad"];
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
            return true;
        }

        //Devuelve solo el usuario siguiente al indicado
        public bool readNextUsuario(ENUsuario en) {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand com = new SqlCommand(@"SELECT * FROM Usuarios where Usuarios.id > (select id from Usuarios where Usuarios.nif = '"+en.NIF+"')ORDER BY id DESC",conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read()) {
                    en.NIF = dr["nif"].ToString();
                    en.NOMBRE = dr["nombre"].ToString();
                    en.EDAD = (Int32)dr["edad"];
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conn != null) { conn.Close(); }
            }
            return true;
        }

        //Devuelve solo el usuario anterior al indicado
        public bool readPrevUsuario(ENUsuario en) {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand com = new SqlCommand(@"SELECT * FROM Usuarios where Usuarios.id < (select id from Usuarios where Usuarios.nif = '" + en.NIF + "')ORDER BY id ASC", conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    en.NIF = dr["nif"].ToString();
                    en.NOMBRE = dr["nombre"].ToString();
                    en.EDAD = (Int32)dr["edad"];
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conn != null) { conn.Close(); }
            }
            return true;
        }

        //Actualiza los datos de un usuario en la BD con los datos del
        //usuario por el parámetro en.
        public bool updateUsuario(ENUsuario en) {
            ENUsuario cl = en;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand com = new SqlCommand(@"UPDATE Usuarios SET Usuarios.nombre = '"+en.NOMBRE+"',Usuarios.edad =  "+en.EDAD+
                    " WHERE Usuarios.nif = " + en.NIF, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (conn != null) conn.Close();
            }
            return true;
        }
    

        //Borra el usuario representado en 'en' de la BD
        public bool deteleUsuario(ENUsuario en) {
            SqlConnection conn = null;
                        
            try
            {
                conn = new SqlConnection(conexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM Usuarios WHERE Usuarios.nif = '"+en.NIF+"';", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //Ha fallado la acción BD.
                return false;
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
            SqlCommand com = new SqlCommand("Select * from Usuarios", c);
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
