using System;
using System.Collections.Generic;
using System.Linq;
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

        }

        public void leer(object sender, EventArgs e) {
            LabelMostrarUsuarios.Text = "";

            for (int i = 0; i < listaUsuarios.Count(); i++)
            {
                LabelMostrarUsuarios.Text += listaUsuarios[i].NOMBRE.ToString() + ", ";
            }
        }
        public void leerPrimero(object sender, EventArgs e) {
          
        }
        public void leerAnterior(object sender, EventArgs e) {
        }
        public void leerSiguiente(object sender, EventArgs e) {
        }
        public void crear(object sender, EventArgs e) {
            bool creakOk = true;
            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, textBoxNombre.Text, Int32.Parse(textBoxEdad.Text));
            try{
                enUsuario.createUsuario();
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
