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

        void GoToFacebook(object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("fb://page/122991994390985"));
        }
    }
}