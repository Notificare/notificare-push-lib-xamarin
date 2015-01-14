using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Notificare.Android.Push.GCM;
using Notificare.Android.Model;

namespace Notificare.Android.Sample
{
	[Activity (Label = "Notificare.Android.Sample", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : BaseActivity, Notificare.IOnNotificareReadyListener
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

		void Notificare.IOnNotificareReadyListener.OnNotificareReady(NotificareApplicationInfo info) 
		{
			Console.WriteLine ("Notificare ready");
		}


	}
}


