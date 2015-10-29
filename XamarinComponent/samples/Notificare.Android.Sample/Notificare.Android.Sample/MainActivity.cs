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
using Notificare.Android.Model;

namespace Notificare.Android.Sample
{
	[Activity (Label = "Notificare.Android.Sample", Name = "notificare.android.sample.MainActivity", MainLauncher = true, Icon = "@drawable/icon", Theme="@style/Theme.AppCompat.Light.DarkActionBar" )]
	public class MainActivity : ActionBarBaseActivity, Notificare.IOnNotificareReadyListener
	{
		private const int LocationPermissionRequestCode = 1;

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

			Notificare.Shared ().AddNotificareReadyListener (this);

		}

		protected override void OnDestroy() {
			base.OnDestroy ();
			Notificare.Shared ().RemoveNotificareReadyListener (this);
		}

		void Notificare.IOnNotificareReadyListener.OnNotificareReady(NotificareApplicationInfo info) 
		{
			Console.WriteLine ("notificare ready");
			if (!Notificare.Shared ().HasLocationPermissionGranted) {
				if (Notificare.Shared ().DidRequestLocationPermission ()) {
					if (Notificare.Shared ().ShouldShowRequestPermissionRationale (this)) {
						new AlertDialog.Builder (this)
							.SetMessage (Resource.String.alert_location_permission_rationale)
							.SetTitle (Resource.String.app_name)
							.SetCancelable (false)
							.SetPositiveButton (Resource.String.button_location_permission_rationale_ok, delegate {
								Notificare.Shared().RequestLocationPermission(this, LocationPermissionRequestCode);
							})
							.Create ()
							.Show ();
					}
				} else {
					Notificare.Shared ().RequestLocationPermission (this, LocationPermissionRequestCode);
				}
			}
		}

		public override void OnRequestPermissionsResult (int requestCode, string[] permissions, Permission[] grantResults)
		{
			switch (requestCode) {
			case LocationPermissionRequestCode: 
				if (Notificare.Shared ().CheckRequestLocationPermissionResult(permissions, grantResults)) {
					Notificare.Shared ().EnableLocationUpdates ();
					Notificare.Shared ().EnableBeacons ();
				}
				break;
			}
		}

	}
}


