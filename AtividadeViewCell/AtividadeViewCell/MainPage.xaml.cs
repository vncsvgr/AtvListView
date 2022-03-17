using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AtividadeViewCell
{
    public partial class MainPage : ContentPage
    {
        List<Smartphones> smartphones = new List<Smartphones>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            Smartphones sp = new Smartphones();
            sp.Fabricante = edtFabricante.Text;
            sp.Modelo = edtModelo.Text;
            sp.Cor = edtCor.Text;

            smartphones.Add(sp);

            
        }

        async void btnPesquisar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Search());
        }
    }
}
