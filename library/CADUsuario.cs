using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADUsuario
    {
        //Inicializa la cadena de conexión de la DB.
        public CADUsuario() { }

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
            return true;
        }
    }
}
