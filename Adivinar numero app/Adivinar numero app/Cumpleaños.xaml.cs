using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adivinar_numero_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cumpleaños : ContentPage
    {
        public Cumpleaños()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                int numero = int.Parse(resultado.Text);

                int resta = numero - 365;

                int a = resta / 1000;
                int b = (resta % 1000) / 100;
                int c = (resta % 1000) % 100 / 10;
                int d = (((resta % 1000) % 100) % 100) % 10 / 1;

                string cadena = ""+a+""+b+"/"+c+""+d;

                cumple.Text = cadena.ToString();     
            }
             else
            {
                DisplayAlert("Datos Erroneos","Por favor ingresa la información primero","Ok");
            }


        }
    }
}