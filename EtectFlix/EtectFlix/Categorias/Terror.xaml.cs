using EtectFlix.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtectFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");

            btnHellsing.Source = ImageSource.FromResource("EtectFlix.Posters.Hellsing.jpg");
            btnSmile.Source = ImageSource.FromResource("EtectFlix.Posters.Smile.jpg");
            btnHallowen.Source = ImageSource.FromResource("EtectFlix.Posters.Hallowen.jpg");

        }

        private async void btnHellsing_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Hellsing());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnSmile_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Smile());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnHallowen_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Hallowen());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }
    }
}