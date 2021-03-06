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
    public partial class Adivinar_Numero : ContentPage
    {
        public Adivinar_Numero()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Resultado.Text))
            {
                int numero = int.Parse(Resultado.Text);

                int division = numero / 10;
                int resultado = division - 4;

                Tunumero.Text = resultado.ToString();

            }
            else
            {
                DisplayAlert("Datos Erroneos",
                    "Por favor ingresa la inforamacion primero", "Ok");
            }
        }
    }
}