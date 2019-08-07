using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Drawing;
using System.Collections.Generic;
using System;
using Android.Content;


namespace _2
{
    [Activity(Label = "Login page")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity2);


            ImageView img = FindViewById<ImageView>(Resource.Id.image1);
            ImageView img2 = FindViewById<ImageView>(Resource.Id.image2);
            var imageSwitch = false;
            Button button = FindViewById<Button>(Resource.Id.next);
            Button buttonout = FindViewById<Button>(Resource.Id.@out);
            
            
           
           
            
            button.Click += delegate
            {
                if (imageSwitch)
                {
                    img.SetImageResource(Resource.Drawable.a);
                    img2.SetImageResource(Resource.Drawable.w);
                  
                    imageSwitch = false;
                }
                else
                {
                    img.SetImageResource(Resource.Drawable.back);
                    img2.SetImageResource(Resource.Drawable.w);
                    imageSwitch = true;
                }
            };

            buttonout.Click += (sender, e) =>
            {
                Intent intent2 = new Intent(this, typeof(Activity0));
                StartActivity(intent2);
            };


        }

        

        // Create your application here

    }
}
