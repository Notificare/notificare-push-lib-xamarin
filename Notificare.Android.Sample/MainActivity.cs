using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Notificare.Android;
using Notificare.Android.Push.GCM;

namespace Notificare.Sample.Android
{
	[Activity (Label = "Notificare.Sample", MainLauncher = true)]
	public class MainActivity : BaseActivity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				Notificare.Android.Notificare.Shared().StartUserPreferencesActivity(this);
			};
		}
	}
}


