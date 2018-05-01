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
    public class Now
    {
        public string time { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string duration { get; set; }
        public string album { get; set; }
        public string token { get; set; }
        public string albumart_url { get; set; }
    }

    public class Recent
    {
        public string time { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string duration { get; set; }
        public string album { get; set; }
        public string token { get; set; }
        public string albumart_url { get; set; }
    }

    public class Show
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public object showAnnouncers { get; set; }
        public string showArtwork { get; set; }
        public string showName { get; set; }
        public string showURL { get; set; }
        public string day { get; set; }
        public string token { get; set; }
    }

    public class Station
    {
        public Now now { get; set; }
        public List<Recent> recent { get; set; }
        public Show show { get; set; }
        public int secsUntilRefresh { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListenNow : ContentPage
    {
        private const string station_96five = "http://onair.hopemedia.com.au/api/station.php?station=hope1032";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<Station> _station;

        public ListenNow()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await _Client.GetStringAsync(station_96five);
            var content2 = "[" + content + "]";
            var station = JsonConvert.DeserializeObject<List<Station>>(content2);
            _station = new ObservableCollection<Station>(station);
            now_96five.ItemsSource = _station;
            base.OnAppearing();
        }

        async void Play96Five()
        {
            await CrossMediaManager.Current.Play("http://stream2.cnmns.net/96five-mp3");
        }

        async void PlayInspire()
        {
            await CrossMediaManager.Current.Play("http://stream2.cnmns.net/inspire-mp3");
        }

        async void PlayFresh()
        {
            await CrossMediaManager.Current.Play("http://stream2.cnmns.net/fresh-mp3");
        }

        async void Stop()
        {
            await CrossMediaManager.Current.Stop();
        }

    }
}