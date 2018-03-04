using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.MediaManager;

namespace App96five
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListenNow : ContentPage
	{
		public ListenNow ()
		{
			InitializeComponent ();
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
    }
}