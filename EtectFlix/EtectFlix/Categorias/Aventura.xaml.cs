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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");

            btnDemon.Source = ImageSource.FromResource("EtectFlix.Posters.DemonSlayer.jpg");
            btnMyhero.Source = ImageSource.FromResource("EtectFlix.Posters.MyHero.jpg");
            btnSailor.Source = ImageSource.FromResource("EtectFlix.Posters.sailormoon.jpg");
        }


        private async void btnDemon_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new DemonSlayer());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnMyhero_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new MyHeroAcademia());
            }catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnSailor_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new SailorMoon());
            }catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um eroo... \n", ex.Message, "Ok");
            }
        }
    }
}