using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {
        public string nif;
        public string nombre;
        public int edad;
  
        public ENUsuario() { }

        public ENUsuario(string nif, string nombre, int edad) { }

        /*Guarda este usuario en la BD. Para ello hará uso de los métodos 
        apropiados de CADUsuario. Devuelve 'false' si no se ha podido realizar
        la operación.*/
        public bool createUsuario() {
            return true;
        }

        /*Recupera todos los usuarios de la BD y devuelve solo el primer usuario.
         Para ello hará uso de los métodos apropiados de CADUsuario. Devuelve 'false'
         si no se ha podido realizar la operación.*/
        public bool readFirstUsuario() {
            return true;
        }

        /*Recupera todos los usuarios de la BD y devuelve solo el susuario siguiente al indicado.
         Para ello hará uso de los métodos apropiados de CADUsuario. Devuelve 'false' si no se 
         ha podido realizar la operación.*/
        public bool readNextUsuario() {
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
            return true;
        }

        /*Borra este usuario de la BD. Para ello hará uso de lo métodos apropiados de CADUsuario. 
         Devuelve 'false' si no se ha podido realizar la operación.*/
        public bool deleteUsuario() {
            return true;
        }



    }
}
