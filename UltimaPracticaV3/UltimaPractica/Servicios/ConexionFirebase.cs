using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace UltimaPractica.Servicios
{
    class ConexionFirebase
    {

        public static FirebaseClient firebase = new FirebaseClient("https://ultimopractica-default-rtdb.firebaseio.com/");

    }
}
