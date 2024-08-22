using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using turismo.Views.Productos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace turismo.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VLPrincipal : ContentPage
    {
        public VLPrincipal()
        {
            InitializeComponent();
            btnIngresar.Clicked += OnButtonClicked;
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.text;
            string pass = txtcontraseña.text;
            if(usuario=="admin" && pass=="admin" )
            {
                await Navigation.PushModalAsync(new VPPrincipal()); 

            }
            else
            {
                lblrespuesta.Text = "Incorrecto";
            }
        }
    }
}