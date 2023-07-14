using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Portada : ContentPage
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void btninicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

       
    }
}