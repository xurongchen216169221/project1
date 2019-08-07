using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Drawing;
using System.Collections.Generic;
using System;
using Android.Content;
using Android.Util;
using System.IO;

namespace _2
{
    [Activity(Label = "Login page")]
    public class showdata : Activity
    {


        public string ReadData()
        {
            Stream stream = null;
            StreamReader reader = null;
            string str = "";
            try
            {
                stream = this.OpenFileInput("userdata");
                reader = new StreamReader(stream);
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    str += s;
                }
            }
            catch (IOException e)
            {
                Log.Error("IOException", e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    try
                    {
                        reader.Close();
                    }
                    catch (IOException e)
                    {
                        Log.Error("IOException", e.Message);
                    }
                }
            }
            return str;
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Showdata);


            TextView datatext = FindViewById<TextView>(Resource.Id.tvdatashow);
            Button backtomain = FindViewById<Button>(Resource.Id.Bbacktomain);

            datatext.Text = ReadData();
           

            backtomain.Click += (sender, e) =>
            {
                Intent intent2 = new Intent(this, typeof(MainActivity));
                StartActivity(intent2);
            };


        }

        

        // Create your application here

    }
}
