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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void leer(object sender, EventArgs e) {
        }
        public void leerPrimero(object sender, EventArgs e) {
        }
        public void leerAnterior(object sender, EventArgs e) {
        }
        public void leerSiguiente(object sender, EventArgs e) {
        }
        public void crear(object sender, EventArgs e) {
            ENUsuario n = new ENUsuario();
            n.createUsuario();

        }
        public void actualizar(object sender, EventArgs e) {
        }

    }
}