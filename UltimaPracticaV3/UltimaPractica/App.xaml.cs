using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UltimaPractica.Vista;

namespace UltimaPractica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PracticeF();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
