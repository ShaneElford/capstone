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
    public class Recent
    {
        public string body { get; set; }
        public string time { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string duration { get; set; }
        public string album { get; set; }
        public string token { get; set; }
        public Uri albumart_url { get; set; }
    }

    public class Station
    {
        public List<Recent> recent { get; set; }
        public int secsUntilRefresh { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListenNow : ContentPage
    {
        private const string station_96five = "http://onair.hopemedia.com.au/api/station.php?station=fresh&now=false&show=false";
        private const string station_inspire = "http://onair.hopemedia.com.au/api/station.php?station=inspiredigital&now=false&show=false";
        private const string station_fresh = "http://onair.hopemedia.com.au/api/station.php?station=fresh&now=false&show=false";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<Station> _96fivestation;
        private ObservableCollection<Station> _inspirestation;
        private ObservableCollection<Station> _freshstation;

        public ListenNow()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            if (NetworkCheck.IsInternet())
            {
                var content_96five = await _Client.GetStringAsync(station_96five);
                var station1 = JsonConvert.DeserializeObject<List<Station>>("[" + content_96five + "]");
                _96fivestation = new ObservableCollection<Station>(station1);
                now_96five.ItemsSource = _96fivestation;

                var content_inspire = await _Client.GetStringAsync(station_inspire);
                var station2 = JsonConvert.DeserializeObject<List<Station>>("[" + content_inspire + "]");
                _inspirestation = new ObservableCollection<Station>(station2);
                now_inspire.ItemsSource = _inspirestation;

                var content_fresh = await _Client.GetStringAsync(station_fresh);
                var station3 = JsonConvert.DeserializeObject<List<Station>>("[" + content_fresh + "]");
                _freshstation = new ObservableCollection<Station>(station3);
                now_fresh.ItemsSource = _freshstation;
            }
            else
            {
                await DisplayAlert("96Five", NetworkCheck.errorMessage, "OK");
            }
            base.OnAppearing();
        }

        public void Select96Five()
        {
            now_96five.IsVisible = true;
            now_inspire.IsVisible = false;
            now_fresh.IsVisible = false;
        }

        async void Play96Five()
        {
            await CrossMediaManager.Current.Stop();
            await CrossMediaManager.Current.Play("http://stream2.cnmns.net/96five-mp3");
        }
        public void SelectInspire()
        {
            now_96five.IsVisible = false;
            now_inspire.IsVisible = true;
            now_fresh.IsVisible = false;
        }

        async void PlayInspire()
        {
            await CrossMediaManager.Current.Stop();
            await CrossMediaManager.Current.Play("http://stream2.cnmns.net/inspire-mp3");
        }
        public void SelectFresh()
        {
            now_96five.IsVisible = false;
            now_inspire.IsVisible = false;
            now_fresh.IsVisible = true;
        }

        async void PlayFresh()
        {
            await CrossMediaManager.Current.Stop();
            await CrossMediaManager.Current.Play("http://stream2.cnmns.net/fresh-mp3");
        }

        async void Stop()
        {
            await CrossMediaManager.Current.Stop();
        }

    }
}