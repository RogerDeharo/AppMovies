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
    public partial class DemonSlayer : ContentPage
    {
        public DemonSlayer()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("EtectFlix.Posters.DemonSlayer.jpg");

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width=""410"" height=""310"" src=""https://www.youtube.com/embed/YhrA6hjQbTw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" allowfullscreen></iframe>";
            visualizador.Source = htmlSource;
        }
    }
}