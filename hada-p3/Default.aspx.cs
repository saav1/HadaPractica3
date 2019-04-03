using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using library;


namespace hada_p3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ArrayList listaUsuarios = new ArrayList();

        protected void Page_Load(object sender, EventArgs e){

        }

        public void leer(object sender, EventArgs e) {
            ENUsuario enUsaurios = new ENUsuario();
            listaUsuarios = enUsuarios.listarUsuarios();

            foreach(string s in a){
              LabelMostarUsuarios.Text += s + "\n";
            }

        }
        public void leerPrimero(object sender, EventArgs e) {
          ENUsuario enUsaurios = new ENUsuario();
          listaUsuarios = enUsuarios.listarUsuarios();
          LableMostrarUsuarios.Text = listaUsuarios.IndexOf(0);
        }
        public void leerAnterior(object sender, EventArgs e) {
        }
        public void leerSiguiente(object sender, EventArgs e) {
        }
        public void crear(object sender, EventArgs e) {

            ENUsuario enUsuario = new ENUsuario(textBoxNIF.Text, textBoxNombre.Text, Int32.Parse(textBoxEdad.Text));
            enUsuario.createUsuario();
        }
        public void actualizar(object sender, EventArgs e) {

        }
        public void borrar(object sender, EventArgs e)
        {

        }
    }
}
