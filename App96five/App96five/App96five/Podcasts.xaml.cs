using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App96five
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Podcasts : ContentPage
	{
		public Podcasts ()
		{
			InitializeComponent ();
            GoodMorning_01.Source = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/365051201&color=%23ff5500&auto_play=false&hide_related=false&show_comments=false&show_user=false&show_reposts=false&show_teaser=false";
            GoodMorning_02.Source = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/365047988&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true";
        }

        public void SelectGoodMorning()
        {
            GoodMorningView.IsVisible = true;
        }
	}
}