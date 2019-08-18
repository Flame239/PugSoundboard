using Xamarin.Forms;

namespace PugSoundboard.views
{
    public class PugFace : ImageButton
    {
        public string Audio
        { get; set; }

        public PugFace()
        {
            // elements in grid (in rows with height 'Auto') require HeightRequest to be set for proper layout sizing
            // Here we assume image has 1:1 aspect ratio
            this.BindingContext = this;
            this.SetBinding(HeightRequestProperty, "Width");

            BackgroundColor = Color.Transparent;
            Margin = new Thickness(10, 0, 10, 0);
        }
    }
}

