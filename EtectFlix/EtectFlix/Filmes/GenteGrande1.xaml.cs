﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EtectFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenteGrande1 : ContentPage
    {
        public GenteGrande1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("EtectFlix.Posters.gente_grande.jpg");
        }
    }
}