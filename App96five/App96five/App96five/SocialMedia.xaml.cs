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
            try
            {
                Device.OpenUri(new Uri("fb://page/122991994390985")); // launch app if present
            }
            catch (Exception)
            {
                Device.OpenUri(new Uri("https://www.facebook.com/96five/")); // else launch web browser
            }
        }
        void GoToInstagram(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("instagram://user?username=1099802346")); // launch app if present
            }
            catch (Exception)
            {
                Device.OpenUri(new Uri("https://www.instagram.com/96five/?hl=en")); // else launch web browser
            }
        }
        void GoToTwitter(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("twitter://user?user_id=80201377")); // launch app if present
            }
            catch (Exception)
            {
                Device.OpenUri(new Uri("https://twitter.com/96five")); // else launch web browser
            }
        }
        void GoToYoutube(object sender, EventArgs e)
        {
            try
            {
                Device.OpenUri(new Uri("vdn.youtube://user/96five"));
            }
            catch (Exception)
            {
                Device.OpenUri(new Uri("https://www.youtube.com/channel/UCKPR63G0OnP-zi6ZswXXB1w"));
            }
        }
    }
}