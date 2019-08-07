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
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    
    public class MainActivity : AppCompatActivity
    {
        public string Username = "SIT313";
        public string userpassword = "123456";

        private void SaveTofile(string username)
        {
            var backingFile = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "userdata.txt");
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(backingFile, true))
            {
                writer.WriteLineAsync(username.ToString());
            }




        }

       
            protected override void OnCreate(Bundle savedInstanceState)
            {
                base.OnCreate(savedInstanceState);
                SetContentView(Resource.Layout.user);

                
            Button nextbutton = FindViewById<Button>(Resource.Id.buttonentry);

                nextbutton.Click += delegate
                {

                    {
                        Intent intent = new Intent(this, typeof(Activity0));
                        StartActivity(intent);
                    }
                };

            }

            public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
            {
                Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

                base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            }
        }
    }

