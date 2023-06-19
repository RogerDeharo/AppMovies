﻿using EtectFlix.Filmes;
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
	public partial class Guerra : ContentPage
	{
		public Guerra ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("EtectFlix.Img.logo.png");


        }

    }
}