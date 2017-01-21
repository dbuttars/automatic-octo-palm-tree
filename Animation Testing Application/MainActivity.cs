using Android.App;
using Android.Widget;
using Android.OS;

namespace Animation_Testing_Application
{
    
    [Activity(Label = "Animation_Testing_Application", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       // Android.Graphics.Drawables.AnimationDrawable _earthDrawable;
        Android.Graphics.Drawables.AnimationDrawable _levelDrawable;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            


        }

        private int ConvertPixelsToDp(float pixelValue)
        {
            var dp = (int)((pixelValue) / Resources.DisplayMetrics.Density);
            return dp;
        }

        public override void OnWindowFocusChanged(bool boolean)
        {
            /**_earthDrawable = (Android.Graphics.Drawables.AnimationDrawable)
                Resources.GetDrawable(Resource.Drawable.earth_animation);
            ImageView earthImage = FindViewById<ImageView>(Resource.Id.imageView1);
            earthImage.SetImageDrawable((Android.Graphics.Drawables.Drawable) _earthDrawable);
            _earthDrawable.Start(); **/

            _levelDrawable = (Android.Graphics.Drawables.AnimationDrawable)
               Resources.GetDrawable(Resource.Drawable.moon_floating_all_locked);
            ImageView levelImage = FindViewById<ImageView>(Resource.Id.imageView1);
            levelImage.SetImageDrawable((Android.Graphics.Drawables.Drawable)_levelDrawable);
            _levelDrawable.Start();
            

        }
    }
}

