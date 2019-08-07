using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Drawing;
using System.Collections.Generic;
using System;
using Android.Content;
using System.IO;
using Android.Util;

namespace _2
{
    [Activity(Label = "Activity0")]
    public class Activity0 : Activity
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
                while ((s=reader.ReadLine())!=null)
                {
                    str += s;
                }
            }
            catch(IOException e)
            {
                Log.Error("IOException", e.Message);
            }
            finally
            {
                if(reader!=null)
                {
                    try
                    {
                        reader.Close();
                    }
                    catch(IOException e)
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
            SetContentView(Resource.Layout.activity_main);
            Button buttonvistior = FindViewById<Button>(Resource.Id.buttonVisitor);
            EditText editUserName = FindViewById<EditText>(Resource.Id.nameText);
            EditText editPassword = FindViewById<EditText>(Resource.Id.textpassword);
            Button signuppage = FindViewById<Button>(Resource.Id.buttonSign);
            Button show = FindViewById<Button>(Resource.Id.buttonshow);

            buttonvistior.Click += (sender, e) =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (string.IsNullOrEmpty(editUserName.Text))
                    {
                        Toast.MakeText(this, "please enter your username!", ToastLength.Long).Show();
                        break;
                    }
                    if(string.IsNullOrEmpty(editPassword.Text))
                    {
                        Toast.MakeText(this, "Please enter your password", ToastLength.Long).Show();
                        break;
                    }
                    else
                    {
                        
                        Intent intent1 = new Intent(this, typeof(Activity1));
                        StartActivity(intent1);
                    }


                }
                
            };

            signuppage.Click += (sender, e) =>
              {
                  Intent intent2 = new Intent(this, typeof(SignUppage));
                  StartActivity(intent2);
              };

            show.Click += (sender, e) =>
              {
                  Intent intent3 = new Intent(this, typeof(showdata));
                  StartActivity(intent3);
              };

        }


        // Create your application here


    }
}