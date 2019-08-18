using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PugSoundboard
{
    public partial class App : Application
    {
        private PugMainPage mainPage;

        public App()
        {
            InitializeComponent();

            mainPage = new PugMainPage();
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            mainPage.StopAudio();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
