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

        private async void Btn_Open_Comedia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Comedia());
            }catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_Drama(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync (new Drama());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_Terror(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Terror());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void Btn_Open_Guerra(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Guerra());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void btnFc_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new FiccaoCientifica());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void btnSus_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Suspense());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void btnInfantil_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Infantil());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void btnAni_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Animacao());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void btnDocu_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Documenntario());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void btnNacional_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Nacional());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }

        private async void btnRomance_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Romance());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message, "Ok");
            }
        }
    }
}
