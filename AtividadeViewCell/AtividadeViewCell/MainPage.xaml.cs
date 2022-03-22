using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AtividadeViewCell.Model;

namespace AtividadeViewCell
{
    public partial class MainPage : ContentPage
    {
        private App PropriedadesApp;

        public MainPage()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            Smartphone sp = new Smartphone();
            sp.Fabricante = edtFabricante.Text;
            sp.Modelo = edtModelo.Text;
            sp.Cor = edtCor.Text;

            PropriedadesApp.Smart.Add(sp);

            edtFabricante.Text = "";
            edtModelo.Text = "";
            edtCor.Text = "";
        }

        async void btnPesquisar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Search());
        }

        private async void btnFinalizar_Clicked(object sender, EventArgs e)
        {
            var fechar = await DisplayAlert("Fechar", "Deseja encerrar o aplicativo?", "Sim", "Não");
            if (fechar)
            {
                Environment.Exit(0);
            }

        }
    }
}
