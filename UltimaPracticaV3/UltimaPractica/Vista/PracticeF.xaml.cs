using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimaPractica.VistaModelo;
using UltimaPractica.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UltimaPractica.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracticeF : ContentPage
    {
        public PracticeF()
        {
            InitializeComponent();
            
        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtPieza.Text))
            {
                await NewFormulario();
            }
            else
            {
               await DisplayAlert ("Error", "Datos Incompletos o erróneos","OK");
            }
            
        }

        private async Task NewFormulario()
        {
            VMPractice funcion = new VMPractice();
            MPractice parametros = new MPractice();
            parametros.CodigoPiece = txtCodigo.Text;
            parametros.Namepiece = txtPieza.Text;
            parametros.NameSupplier = txtProveedor.Text;
            parametros.Precio = txtPrecio.Text;
            await funcion.TakePiece(parametros);
            await DisplayAlert("Listo", "Pieza agregada", "OK");
            

        }


        private async Task mostrarPiezas()
        {
            VMPractice funcion = new VMPractice();
            var dt = await funcion.ViewFormulario();
            

        }

    }

}