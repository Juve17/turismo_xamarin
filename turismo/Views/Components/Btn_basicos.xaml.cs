using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace turismo.Views.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Btn_basicos : ContentView
    {
        public Btn_basicos()
        {
            InitializeComponent();
        }
        public event EventHandler Clicked
        {
            add=>button.Clicked+=value;
            remove =>button.Clicked-=value;
        }
        public void SetButtonText(string text)
        {
            button.Text = text;
        }
    }
}