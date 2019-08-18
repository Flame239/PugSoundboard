using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using Plugin.SimpleAudioPlayer;
using PugSoundboard.views;
using Xamarin.Forms;

namespace PugSoundboard
{
    [DesignTimeVisible(true)]
    public partial class PugMainPage : ContentPage
    {
        private readonly ISimpleAudioPlayer player = CrossSimpleAudioPlayer.Current;

        public PugMainPage()
        {
            InitializeComponent();
        }

        async void OnPugFaceClicked(object sender, EventArgs e)
        {
            if (player.IsPlaying)
            {
                return;
            }
            var pugFace = (PugFace)sender;
            player.Load(GetStreamFromFile(pugFace.Audio));
            player.Play();
            await pugFace.ScaleTo(1.2, 250, Easing.CubicIn);
            await pugFace.ScaleTo(1, 250, Easing.CubicOut);
        }

        private Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("PugSoundboard.sounds." + filename);
            return stream;
        }

        public void StopAudio()
        {
            player.Stop();
        }
    } 
}
