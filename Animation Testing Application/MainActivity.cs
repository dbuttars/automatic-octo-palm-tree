﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace Animation_Testing_Application
{
    [Activity(Label = "Animation_Testing_Application", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

