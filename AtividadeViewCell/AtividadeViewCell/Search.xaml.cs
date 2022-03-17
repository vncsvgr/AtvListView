using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtividadeViewCell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        private void sbSmartphones_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        async void Voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}