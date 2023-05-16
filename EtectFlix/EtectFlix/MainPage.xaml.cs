using EtectFlix.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace EtectFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");


            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Aventura());
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private void Btn_Open_Comedia(object sender, EventArgs e)
        {

        }

        private void Btn_Open_Drama(object sender, EventArgs e)
        {

        }

        private void Btn_Open_Terror(object sender, EventArgs e)
        {

        }
    }
}
