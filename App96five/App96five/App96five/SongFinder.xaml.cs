using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.MediaManager;
using System.Net.Http;
using Newtonsoft.Json;

namespace App96five
{
    public class Track
    {
        public string firstSeen { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public double similarity { get; set; }
        public string album { get; set; }
        public string token { get; set; }
        public Uri albumart_url { get; set; }
        public int weeksOn { get; set; }
    }

    public class Artist
    {
        public string firstSeen { get; set; }
        public string artistName { get; set; }
        public double similarity { get; set; }
    }

    public class SongRequest
    {
        public List<Track> tracks { get; set; }
        public List<Artist> artists { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SongFinder : ContentPage
    {
        private const string search_96five = "http://onair.hopemedia.com.au/api/music_search.php?station=hope1032&query=";
        private const string search_inspire = "http://onair.hopemedia.com.au/api/music_search.php?station=inspiredigital&query=";
        private const string search_fresh = "http://onair.hopemedia.com.au/api/music_search.php?station=fresh&query=";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<SongRequest> _96fivesearch;
        private ObservableCollection<SongRequest> _inspiresearch;
        private ObservableCollection<SongRequest> _freshsearch;

        public SongFinder()
        {
            InitializeComponent();
        }

        protected async void songSearch(object sender, EventArgs e)
        {
            string search = ((Entry)sender).Text;
            if (NetworkCheck.IsInternet())
            {
                var result_96five = await _Client.GetStringAsync(search_96five + search);
                var station1 = JsonConvert.DeserializeObject<List<SongRequest>>("[" + result_96five + "]");
                _96fivesearch = new ObservableCollection<SongRequest>(station1);
                display_96five.ItemsSource = _96fivesearch;

                var result_inspire = await _Client.GetStringAsync(search_inspire + search);
                var station2 = JsonConvert.DeserializeObject<List<SongRequest>>("[" + result_inspire + "]");
                _inspiresearch = new ObservableCollection<SongRequest>(station2);
                display_inspire.ItemsSource = _inspiresearch;

                var result_fresh = await _Client.GetStringAsync(search_fresh + search);
                var station3 = JsonConvert.DeserializeObject<List<SongRequest>>("[" + result_fresh + "]");
                _freshsearch = new ObservableCollection<SongRequest>(station3);
                display_fresh.ItemsSource = _freshsearch;
            }
            else
            {
                await DisplayAlert("96Five", NetworkCheck.errorMessage, "OK");
            }
        }
        public void Select96Five()
        {
            display_96five.IsVisible = true;
            display_inspire.IsVisible = false;
            display_fresh.IsVisible = false;
        }
        
        public void SelectInspire()
        {
            display_96five.IsVisible = false;
            display_inspire.IsVisible = true;
            display_fresh.IsVisible = false;
        }
        
        public void SelectFresh()
        {
            display_96five.IsVisible = false;
            display_inspire.IsVisible = false;
            display_fresh.IsVisible = true;
        }
    }
}