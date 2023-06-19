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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");

            btnKoeNo.Source = ImageSource.FromResource("EtectFlix.Posters.Koe-no-Katachi-poster-film.jpg");
            btnSuzume.Source = ImageSource.FromResource("EtectFlix.Posters.suzume-poster.jpg");
            btnviolet.Source = ImageSource.FromResource("EtectFlix.Posters.Violet.jpg");
        }

        private async void btnKoeNo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new aVozDoSilencio());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnSuzume_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Suzume());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnviolet_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Violet());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }
    }
}