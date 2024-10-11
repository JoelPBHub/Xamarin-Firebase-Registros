using System;
using System.Collections.Generic;
using System.Text;
using UltimaPractica.Modelo;
using UltimaPractica.Servicios;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace UltimaPractica.VistaModelo
{
    public class VMPractice
    {
        List<MPractice> Form = new List<MPractice>();

        public async Task<object> ViewFormulario()
        {
            var data = await ConexionFirebase.firebase
                .Child("Formulario")
                .OrderByKey()
                .OnceAsync<MPractice>();

            foreach (var rdr in data)
            {
                var parametro = new MPractice();

                parametro.ID_piece = rdr.Key;
                parametro.CodigoPiece = rdr.Object.CodigoPiece;
                parametro.Namepiece = rdr.Object.Namepiece;
                parametro.ID_supplier = rdr.Key;
                parametro.NameSupplier = rdr.Object.NameSupplier;
                parametro.Precio = rdr.Object.Precio;
                Form.Add(parametro);

            }
            return Form;

        }

        public async Task TakePiece(MPractice parametro)
        {
            await ConexionFirebase.firebase
                .Child("Formulario")
                .PostAsync(new MPractice()
                {

                   
                    CodigoPiece = parametro.CodigoPiece,
                    Namepiece = parametro.Namepiece,
                    NameSupplier = parametro.NameSupplier,
                    Precio = parametro.Precio


                });
        }


    }
}
