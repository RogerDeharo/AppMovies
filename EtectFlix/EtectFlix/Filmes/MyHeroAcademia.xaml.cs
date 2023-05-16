using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtectFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyHeroAcademia : ContentPage
    {
        public MyHeroAcademia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("EtectFlix.Posters.MyHero.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=""400"" height=""315"" src=""https://www.youtube.com/embed/RugjT3HYbes"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" allowfullscreen></iframe>";
            visualizador.Source = htmlSource;
        }
    }
}