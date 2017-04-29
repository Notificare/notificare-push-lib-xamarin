using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

using Notificare.Android.Push.GCM;
using Notificare.Android.Support.V7.App;
using Notificare.Android.Billing;
using Notificare.Android.Beacon;
using Notificare.Android.Model;
using Notificare.Android;

namespace Notificare.Sample.Android
{
	[Activity (Label = "Notificare.Sample", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
	[IntentFilter (new[]{Notificare.Android.Notificare.IntentActionNotificationOpened}, Categories=new[]{Intent.CategoryDefault})]
	public class MainActivity : ActionBarBaseActivity, Notificare.Android.Notificare.IOnNotificareReadyListener, Notificare.Android.Notificare.IOnBillingReadyListener, BillingManager.IOnRefreshFinishedListener
	{

		private const int LocationPermissionRequestCode = 1;

		protected override void OnNewIntent(Intent intent) {
			HandleNotificationOpenedIntent (intent);
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			if (Intent != null && Intent.Action != null)
			{
				HandleNotificationOpenedIntent(Intent);
			}
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				Notificare.Android.Notificare.Shared().StartUserPreferencesActivity(this);
			};

			Notificare.Android.Notificare.Shared ().AddNotificareReadyListener (this);
			Notificare.Android.Notificare.Shared ().AddBillingReadyListener (this);
		}

		protected override void OnDestroy() {
			base.OnDestroy ();
			Notificare.Android.Notificare.Shared ().RemoveBillingReadyListener (this);
			Notificare.Android.Notificare.Shared ().RemoveNotificareReadyListener (this);
		}

		void Notificare.Android.Notificare.IOnNotificareReadyListener.OnNotificareReady(NotificareApplicationInfo info) 
		{
			Console.WriteLine ("notificare ready");
			if (!Notificare.Android.Notificare.Shared ().HasLocationPermissionGranted) {
				if (Notificare.Android.Notificare.Shared ().DidRequestLocationPermission ()) {
					if (Notificare.Android.Notificare.Shared ().ShouldShowRequestPermissionRationale (this)) {
						new AlertDialog.Builder (this)
							.SetMessage (Resource.String.alert_location_permission_rationale)
							.SetTitle (Resource.String.app_name)
							.SetCancelable (false)
							.SetPositiveButton (Resource.String.button_location_permission_rationale_ok, delegate {
								Notificare.Android.Notificare.Shared().RequestLocationPermission(this, LocationPermissionRequestCode);
							})
							.Create ()
							.Show ();
					}
				} else {
					Notificare.Android.Notificare.Shared ().RequestLocationPermission (this, LocationPermissionRequestCode);
				}
			}
		}
			
		public override void OnRequestPermissionsResult (int requestCode, string[] permissions, Permission[] grantResults)
		{
			switch (requestCode) {
			case LocationPermissionRequestCode: 
				if (Notificare.Android.Notificare.Shared ().CheckRequestLocationPermissionResult(permissions, grantResults)) {
					Notificare.Android.Notificare.Shared ().EnableLocationUpdates ();
					Notificare.Android.Notificare.Shared ().EnableBeacons ();
				}
				break;
			}
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


