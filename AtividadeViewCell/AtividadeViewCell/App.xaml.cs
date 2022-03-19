using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AtividadeViewCell.Model;

namespace AtividadeViewCell
{
    public partial class App : Application
    {
        public List<Model.Smartphone> Smart = new List<Model.Smartphone>();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
