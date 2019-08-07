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


    [Activity(Label = "SignUp page")]
    public class SignUppage : Activity
    {
        /*public void SaveData(string s)
        {
            ISharedPreferences sp = this.GetSharedPreferences("userdata", FileCreationMode.Append);
            ISharedPreferencesEditor editor = sp.Edit();

            editor.PutString("name",sname);
            editor.PutString("password", spassword);
            
            editor.Apply();
        }

    */

            public void SaveData(string s)
        {
            Stream stream = null;
            StreamWriter writer = null;
            try
            {
                stream = this.OpenFileOutput("userdata", Android.Content.FileCreationMode.Append);
                writer = new StreamWriter(stream);
                writer.WriteLine(s+",");
            }
            catch(IOException e)
            {
                Log.Error("IOException", e.Message);
            }
            finally
            {
                try
                {
                    if (writer != null)
                    writer.Close();
                }
                catch(IOException e)
                {
                    Log.Error("IOException", e.Message);
                }
            }
        }


        string sname;
        string spassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.signup);

            EditText crename = FindViewById<EditText>(Resource.Id.editcreatername);
            EditText crepass = FindViewById<EditText>(Resource.Id.editcreaterpass);
            Button signup = FindViewById<Button>(Resource.Id.buttonsignup);
            
            

            signup.Click += (sender, e) =>
            {
                Toast.MakeText(this, "Sign up successfully", ToastLength.Long).Show();
                SaveData(crename.Text);
                SaveData(crepass.Text);
                Intent intent2 = new Intent(this, typeof(Activity0));
                StartActivity(intent2);
            };


        }

        

        // Create your application here

    }
}
