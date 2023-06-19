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
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");

            btnGuardioes.Source = ImageSource.FromResource("EtectFlix.Posters.Guardioes.jpg");
            btnGenteGrande.Source = ImageSource.FromResource("EtectFlix.Posters.gente_grande.jpg");
            btnGenteGrande2.Source = ImageSource.FromResource("EtectFlix.Posters.gente-grande-2-capa.jpg");
        }

        private async void btnGuardioes_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new GuardiõesDaGalaxia());
            }catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnGenteGrande_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new GenteGrande1());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }

        private async void btnGenteGrande2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new GenteGrande2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro... \n", ex.Message, "Ok");
            }
        }
    }
}