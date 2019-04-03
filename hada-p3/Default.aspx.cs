using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using library;


namespace hada_p3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<ENUsuario> listaUsuarios = new List<ENUsuario>();

        protected void Page_Load(object sender, EventArgs e){
            SqlConnection conn = null;
            ENUsuario enUsu = new ENUsuario();
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EPS\Desktop\HadaPractica3\hada-p3\App_Data\Database.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand com = new SqlCommand(@"SELECT * FROM Usuarios", conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    enUsu.ID = (Int16)dr["id"];
                    enUsu.NIF = dr["nif"].ToString();
                    enUsu.NOMBRE = dr["nombre"].ToString();
                    enUsu.EDAD = (Int16)dr["edad"];
                    listaUsuarios.Add(enUsu);
                }

            }
            catch (Exception)
            {
                
            }
            finally
            {
                if (conn != null) conn.Close();
            }
            
        }

        public void leer(object sender, EventArgs e) {
            LabelMostrarUsuarios.Text = "";

            for (int i = 0; i < listaUsuarios.Count(); i++)
            {
                LabelMostrarUsuarios.Text += "ID: " + listaUsuarios[i].ID + "\n"+
                                             "NOMBRE: " + listaUsuarios[i].NOMBRE + "\n"+
                                             "NIF: " + listaUsuarios[i].NIF + "\n"+
                                             "EDAD: " + listaUsuarios[i].EDAD+"|| ";
            }
            /*  textBoxNIF.Text = listaUsuarios[i].NIF;
                textBoxNombre.Text = listaUsuarios[i].NOMBRE;
                textBoxEdad.Text = listaUsuarios[i].EDAD.ToString();*/
        }
        public void leerPrimero(object sender, EventArgs e) {
            CADUsuario cadU = new CADUsuario();
            ENUsuario enU = new ENUsuario();

            if (cadU.readFirstUsuario(ref enU))
            {
                textBoxNIF.Text = enU.NIF;
                textBoxNombre.Text = enU.NOMBRE;
                textBoxEdad.Text = enU.EDAD.ToString();
            }
            else {
                LabelMostrarUsuarios.Text = "No se puede leer primer usuario.";
            }



        }
        public void leerAnterior(object sender, EventArgs e) {
        }
        public void leerSiguiente(object sender, EventArgs e) {
        }
        public void crear(object sender, EventArgs e) {
            bool creakOk = true;
            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, textBoxNombre.Text, Int32.Parse(textBoxEdad.Text));
            try{
                if (enUsuario.createUsuario())
                {
                    LabelMostrarUsuarios.Text = "Se ha guardado el usuario en la BD";
                }
                else {
                    creakOk = false;
                    LabelMostrarUsuarios.Text = "No se ha guardado el usuario.";
                }
            }
            catch (Exception) {
                LabelMostrarUsuarios.Text = "No se ha podido crear el usuario!";
                creakOk = false;
            }

            if (creakOk) {
                //Agregamos el usario al ArrayList
                listaUsuarios.Add(enUsuario);
                LabelMostrarUsuarios.Text = "Se añade el usuario al array ";
            }
        }
        public void actualizar(object sender, EventArgs e) {

        }
        public void borrar(object sender, EventArgs e)
        {

        }
    }
}
