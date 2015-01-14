using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Notificare.Android.Push.GCM;
using Notificare.Android.Billing;
using Notificare.Android.Model;
using Notificare.Android;

namespace Notificare.Sample.Android
{
	[Activity (Label = "Notificare.Sample", MainLauncher = true)]
	public class MainActivity : BaseActivity, Notificare.Android.Notificare.IOnBillingReadyListener, BillingManager.IOnRefreshFinishedListener
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

			Notificare.Android.Notificare.Shared ().AddBillingReadyListener (this);
		}

		void Notificare.Android.Notificare.IOnBillingReadyListener.OnBillingReady ()
		{
			Console.WriteLine ("billing ready");

			Notificare.Android.Notificare.Shared ().BillingManager.Refresh (this);
		}

		void BillingManager.IOnRefreshFinishedListener.OnRefreshFinished() 
		{
			Console.WriteLine ("billing refreshed");
			foreach (NotificareProduct product in Notificare.Android.Notificare.Shared().Products) {
				Console.WriteLine (product.Name);
			}

		}

		void BillingManager.IOnRefreshFinishedListener.OnRefreshFailed(NotificareError error) 
		{
			Console.WriteLine ("billing refresh failed: " + error.Message);

		}

	}

}


