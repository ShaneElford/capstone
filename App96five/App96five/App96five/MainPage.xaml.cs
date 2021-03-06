﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace App96five
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "banner.png");
        }

        async void GoToListenNow(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListenNow { Title = "Listen Now" });
        }

        async void GoToSongFinder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SongFinder { Title = "Song Finder" });
        }

        async void GoToPodcasts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Podcasts { Title = "Podcasts" });
        }

        async void GoToSocialMedia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SocialMedia { Title = "Social Media" });
        }

        async void GoToWhatsOn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WhatsOn { Title = "What's On" });
        }

        async void GoToProgramGuide(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgramGuide { Title = "Program Guide" });
        }

        async void GoToExploringFaith(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExploringFaith { Title = "Exploring Faith" });
        }

        async void GoToDonations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Donations { Title = "Donations" });
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}