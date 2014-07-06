using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Notificare.Android.Push.GCM;

namespace Notificare.Android.Sample
{
	[Activity (Label = "Notificare.Android.Sample", MainLauncher = true, Icon = "@drawable/icon")]
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
				Notificare.Shared().StartUserPreferencesActivity(this);
			};
		}
	}
}


