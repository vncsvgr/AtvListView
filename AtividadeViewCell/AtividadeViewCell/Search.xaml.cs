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
        private App PropriedadesApp;

        public Search()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            lstSmartphones.ItemsSource = PropriedadesApp.Smart;

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void sbSmartphones_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstSmartphones.ItemsSource = PropriedadesApp.Smart.Where(
                x => x.Modelo.ToUpper().Contains(sbSmartphones.Text.ToUpper()));
        }

        async void Voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void lstSmartphones_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var a = e.SelectedItem as Model.Smartphone;

            var resp = await DisplayAlert("Exclusão", "Deseja excluir o aparelho " + a.Modelo + "?", "Sim", "Não");

            if (resp)
            {
                var item = PropriedadesApp.Smart.Find(x => x.Modelo == a.Modelo);
                PropriedadesApp.Smart.Remove(item);
                lstSmartphones.ItemsSource = null;
                lstSmartphones.ItemsSource = PropriedadesApp.Smart;
            }
        }
    }
}