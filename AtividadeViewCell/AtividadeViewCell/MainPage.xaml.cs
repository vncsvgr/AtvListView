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

        private void btnFinalizar_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
