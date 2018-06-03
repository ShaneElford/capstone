using System;
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
            NavigationPage.SetHasNavigationBar(this, false);
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

        private void GoToWhatsOn(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.96five.com/noticeboard/"));
        }

        async void GoToProgramGuide(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgramGuide { Title = "Program Guide" });
        }

        private void GoToExploringFaith(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.bible.com/bible"));
        }

        private void GoToDonations(object sender, EventArgs e)
        {
        Device.OpenUri(new Uri("http://96five.com/donate"));
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}