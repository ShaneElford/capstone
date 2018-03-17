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

	public partial class SocialMedia : ContentPage
	{
		public SocialMedia ()
		{
			InitializeComponent ();
		}

        void GoToFacebook(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/96five/"));
        }
        //fb://page/122991994390985
        void GoToInstagram(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com/96five/?hl=en"));
        }
        //instagram://user?username=1099802346
        void GoToTwitter(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/96five"));
        }
//twitter://user?user_id=80201377
        void GoToYoutube(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/channel/UCKPR63G0OnP-zi6ZswXXB1w"));
        }
    }
}