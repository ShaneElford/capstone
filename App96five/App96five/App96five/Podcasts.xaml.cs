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
            GoodMorningView.Source = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/users/284954437&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true";
            FamilyWorshipView.Source = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/playlists/318406640&color=%23ff5500&auto_play=false&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true";
            LifeWordsView.Source = "https://itunes.apple.com/us/podcast/lifewords-q-a-with-david-reay/id897421376?mt=2#TrackList";
            OpenHouseView.Source = "https://itunes.apple.com/au/podcast/open-house/id1084940084?mt=2#TrackList";
            TalkingLifeView.Source = "https://m.soundcloud.com/search/tracks?q=96five%20talking%20life";
        }

        public void SelectGoodMorning()
        {
            if (GoodMorningView.IsVisible == false)
            {
                GoodMorning.IsVisible = true;
                GoodMorningView.IsVisible = true;
                FamilyWorship.IsVisible = false;
                LifeWords.IsVisible = false;
                OpenHouse.IsVisible = false;
                TalkingLife.IsVisible = false;
            }
            else
            {
                GoodMorning.IsVisible = true;
                GoodMorningView.IsVisible = false;
                FamilyWorship.IsVisible = true;
                LifeWords.IsVisible = true;
                OpenHouse.IsVisible = true;
                TalkingLife.IsVisible = true;
            }
        }
        public void SelectFamilyWorship()
        {
            if (FamilyWorshipView.IsVisible == false)
            {
                GoodMorning.IsVisible = false;
                FamilyWorship.IsVisible = true;
                FamilyWorshipView.IsVisible = true;
                LifeWords.IsVisible = false;
                OpenHouse.IsVisible = false;
                TalkingLife.IsVisible = false;
            }
            else
            {
                GoodMorning.IsVisible = true;
                FamilyWorship.IsVisible = true;
                FamilyWorshipView.IsVisible = false;
                LifeWords.IsVisible = true;
                OpenHouse.IsVisible = true;
                TalkingLife.IsVisible = true;
            }
        }
        public void SelectLifeWords()
        {
            if (LifeWordsView.IsVisible == false)
            {
                GoodMorning.IsVisible = false;
                FamilyWorship.IsVisible = false;
                LifeWords.IsVisible = true;
                LifeWordsView.IsVisible = true;
                OpenHouse.IsVisible = false;
                TalkingLife.IsVisible = false;
            }
            else
            {
                GoodMorning.IsVisible = true;
                FamilyWorship.IsVisible = true;
                LifeWords.IsVisible = true;
                LifeWordsView.IsVisible = false;
                OpenHouse.IsVisible = true;
                TalkingLife.IsVisible = true;
            }
        }
        public void SelectOpenHouse()
        {
            if (OpenHouseView.IsVisible == false)
            {
                GoodMorning.IsVisible = false;
                FamilyWorship.IsVisible = false;
                LifeWords.IsVisible = false;
                OpenHouse.IsVisible = true;
                OpenHouseView.IsVisible = true;
                TalkingLife.IsVisible = false;
            }
            else
            {
                GoodMorning.IsVisible = true;
                FamilyWorship.IsVisible = true;
                LifeWords.IsVisible = true;
                OpenHouse.IsVisible = true;
                OpenHouseView.IsVisible = false;
                TalkingLife.IsVisible = true;
            }
        }
        public void SelectTalkingLife()
        {
            if (TalkingLifeView.IsVisible == false)
            {
                GoodMorning.IsVisible = false;
                FamilyWorship.IsVisible = false;
                LifeWords.IsVisible = false;
                OpenHouse.IsVisible = false;
                TalkingLife.IsVisible = true;
                TalkingLifeView.IsVisible = true;
            }
            else
            {
                GoodMorning.IsVisible = true;
                FamilyWorship.IsVisible = true;
                LifeWords.IsVisible = true;
                OpenHouse.IsVisible = true;
                TalkingLife.IsVisible = true;
                TalkingLifeView.IsVisible = false;
            }
        }
    }
}