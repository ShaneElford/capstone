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
	public partial class Donations : ContentPage
	{
		public Donations ()
		{
			InitializeComponent ();
            DonationDisplay.Source = "http://96five.com/donate";
        }
    }
}