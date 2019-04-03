using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using library;
using System.Data;

namespace hada_p3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e){


        }

        public void leer(object sender, EventArgs e) {
            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, "", 0);
            CADUsuario cadUsuario = new CADUsuario();

            try
            {
                if (cadUsuario.readUsuario(ref enUsuario))
                {
                    LabelMostrarUsuarios.Text = "Se ha leido el usuario";
                    textBoxNIF.Text = enUsuario.NIF;
                    textBoxNombre.Text = enUsuario.NOMBRE;
                    textBoxEdad.Text = enUsuario.EDAD.ToString();
                }
                else
                {
                    LabelMostrarUsuarios.Text = "No se ha leido el usuario";
                }
            }
            catch (Exception ex)
            {
                LabelMostrarUsuarios.Text = ex.ToString();
                // LabelMostrarUsuarios.Text = "No se ha podido leer el primero";
            }

        }
        public void leerPrimero(object sender, EventArgs e) {
            ENUsuario enUsuario = new ENUsuario();
            CADUsuario cadUsuario = new CADUsuario();

            try
            {
                if (cadUsuario.readFirstUsuario(ref enUsuario))
                {
                    LabelMostrarUsuarios.Text = "Se ha leido el primero";
                    textBoxNIF.Text = enUsuario.NIF;
                    textBoxNombre.Text = enUsuario.NOMBRE;
                    textBoxEdad.Text = enUsuario.EDAD.ToString();
                }
                else
                {
                    LabelMostrarUsuarios.Text = "No se ha leido el primero";
                }
            }
            catch (Exception ex)
            {
                LabelMostrarUsuarios.Text = ex.ToString();
               // LabelMostrarUsuarios.Text = "No se ha podido leer el primero";
            }

        }
        public void leerAnterior(object sender, EventArgs e) {

        }
        public void leerSiguiente(object sender, EventArgs e) {
            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, textBoxNombre.Text, Int32.Parse(textBoxEdad.Text));
            try
            {
                if (enUsuario.readNextUsuario())
                {
                    LabelMostrarUsuarios.Text = "Se ha leido el siguiente";
                }
                else
                {
                    LabelMostrarUsuarios.Text = "No se ha leido el siguiente";
                }
            }
            catch (Exception)
            {
                LabelMostrarUsuarios.Text = "No se ha podido leer el usuario";
            }
        }
        public void crear(object sender, EventArgs e) {
            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, textBoxNombre.Text, Int32.Parse(textBoxEdad.Text));
            try{
                if (enUsuario.createUsuario())
                {
                    LabelMostrarUsuarios.Text = "Se ha guardado el usuario en la BD";
                }
                else {
                    LabelMostrarUsuarios.Text = "No se ha guardado el usuario.";
                }
            }
            catch (Exception) {
                LabelMostrarUsuarios.Text = "No se ha podido crear el usuario!";
            }
        }
        public void actualizar(object sender, EventArgs e) {
            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, textBoxNombre.Text, Int32.Parse(textBoxEdad.Text));
            try
            {
                if (enUsuario.updateUsuario())
                {
                    LabelMostrarUsuarios.Text = "Se ha actualizado el usuario en la BD";
                }
                else
                {
                    LabelMostrarUsuarios.Text = "No se ha actualizado el usuario.";
                }
            }
            catch (Exception)
            {
                LabelMostrarUsuarios.Text = "No se ha actualizado el usuario!";
            }
        }
        public void borrar(object sender, EventArgs e)
        {
            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, "", 0);
            try
            {
                if (enUsuario.deleteUsuario())
                {
                    LabelMostrarUsuarios.Text = "Se ha borrado el usuario en la BD";
                    textBoxNIF.Text = "";
                    textBoxEdad.Text = "";
                    textBoxNombre.Text = "";
                }
                else
                {
                    LabelMostrarUsuarios.Text = "No se ha borrado el usuario.";
                }
            }
            catch (Exception)
            {
                LabelMostrarUsuarios.Text = "No se ha podido borrar el usuario!";
            }
        }
    }
}
