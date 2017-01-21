using Android.App;
using Android.Widget;
using Android.OS;

namespace Animation_Testing_Application
{
    
    [Activity(Label = "Animation_Testing_Application", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Android.Graphics.Drawables.AnimationDrawable _earthDrawable;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            


        }

        public override void OnWindowFocusChanged(bool boolean)
        {
            _earthDrawable = (Android.Graphics.Drawables.AnimationDrawable)
                Resources.GetDrawable(Resource.Drawable.earth_animation);
            ImageView earthImage = FindViewById<ImageView>(Resource.Id.imageView1);
            earthImage.SetImageDrawable((Android.Graphics.Drawables.Drawable) _earthDrawable);
            _earthDrawable.Start();
        }
    }
}

