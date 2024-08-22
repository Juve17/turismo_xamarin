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
    public partial class Input_text : ContentView
    {
        public Input_text()
        {
            InitializeComponent();
        }
        public string text
        {
            get => entry.Text;
            set=>entry.Text = value;
        }
    }
}