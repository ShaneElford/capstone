using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App96five
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void GoToListenNow(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListenNow());
        }

        async void GoToSongFinder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SongFinder());
        }

        async void GoToPodcasts(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Podcasts());
        }

        async void GoToSocialMedia(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SocialMedia());
        }

        async void GoToWhatsOn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WhatsOn());
        }

        async void GoToProgramGuide(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgramGuide());
        }

        async void GoToExploringFaith(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExploringFaith());
        }

        async void GoToDonations(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Donations());
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}