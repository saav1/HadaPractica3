using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace library
{
    public class ENUsuario
    {
        //Atributo nif.
        private string nif;
        public string NIF{ get{return nif;} set{nif = value;} }

        //Atributo nombre.
        private string nombre;
        public string NOMBRE{ get{return nombre;} set{nombre = value;} }

        //Atributo edad.
        private int edad;
        public int EDAD{ get{return edad;} set{edad = value;} }


        //Constructor por defecto.
        public ENUsuario() {
          nif = "null";
          nombre = "null";
          edad = -1;
        }

        //Constructor.
        public ENUsuario(string eNif, string eNombre, int eEdad) {
            nif = eNif;
            nombre = eNombre;
            edad = eEdad;
        }

        /*Guarda este usuario en la BD. Para ello hará uso de los métodos
        apropiados de CADUsuario. Devuelve 'false' si no se ha podido realizar
        la operación.*/
        public bool createUsuario() {
            CADUsuario u = new CADUsuario();
            return u.createUsuario(this) ? true : false;
        }

        /*Recupera todos los usuarios de la BD y devuelve solo el primer usuario.
         Para ello hará uso de los métodos apropiados de CADUsuario. Devuelve 'false'
         si no se ha podido realizar la operación.*/
        public bool readFirstUsuario() {
            return true;
        }

        public bool readUsuario() {
            return true;
        }

        /*Recupera todos los usuarios de la BD y devuelve solo el susuario siguiente al indicado.
         Para ello hará uso de los métodos apropiados de CADUsuario. Devuelve 'false' si no se
         ha podido realizar la operación.*/
        public bool readNextUsuario() {
            CADUsuario cadU = new CADUsuario();
            return true;
        }

        /*Recupera todos los usuarios de la BD y devuelve solo el usuario anterior al indicado.
         Para ello hará uso de los métodos apropiados de CADUsuario. Devuelve 'false' si no se
         ha podido realizar la operación.*/
        public bool readPrevUsuario() {
            return true;
        }

        /*Actualiza este usuario en la BD. Para ello hará uso de los métodos apropiados de CADUsuario.
         Devuelve 'false' si no se ha podido realizar la operación.*/
        public bool updateUsuario() {
            CADUsuario u = new CADUsuario();
            return u.updateUsuario(this) ? true : false;
        }

        /*Borra este usuario de la BD. Para ello hará uso de lo métodos apropiados de CADUsuario.
         Devuelve 'false' si no se ha podido realizar la operación.*/
        public bool deleteUsuario() {
            CADUsuario cadU = new CADUsuario();
            return cadU.deteleUsuario(this) ? true : false;
        }

        public ArrayList listarUsuarios() {
            ArrayList a = new ArrayList();
            CADUsuario c = new CADUsuario();
            a = c.ListarClientes();
            return a;
        }

    }
}
