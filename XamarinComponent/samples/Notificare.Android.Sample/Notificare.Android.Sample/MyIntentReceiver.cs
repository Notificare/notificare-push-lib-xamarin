using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Notificare.Android.Push.GCM;
using Notificare.Android;

namespace Notificare.Android.Sample
{

	public class AddDeviceTagsCallback: Java.Lang.Object, INotificareCallback
	{
		void INotificareCallback.OnSuccess(Java.Lang.Object success)
		{
			Console.WriteLine ("successfully added device tags");
		}

		void INotificareCallback.OnError(NotificareError error)
		{
			Console.WriteLine ("error adding device tags: " + error.Message);
		}
	}

	public class RegisterDeviceCallback : Java.Lang.Object, INotificareCallback
	{
		void INotificareCallback.OnSuccess(Java.Lang.Object success)
		{
			Console.WriteLine ("successfully registered device");
			// Now, enable location updates
			Notificare.Shared ().EnableLocationUpdates ();
			// Let the user set user preferences from the UserPereferencesActivity, other tags can be added like this
			//Notificare.Shared ().AddDeviceTags (new List<String> (){ "xamarin" }, new AddDeviceTagsCallback ());
		}

		void INotificareCallback.OnError(NotificareError error)
		{
			Console.WriteLine ("error registering device: " + error.Message);
		}
	}

	[BroadcastReceiver]
	public class MyIntentReceiver : DefaultIntentReceiver
	{
		public override void OnReady ()
		{
			Console.WriteLine ("Notificare ready, enable notifications");
			Notificare.Shared ().EnableNotifications ();
		}

		public override void OnRegistrationFinished(String deviceId) 
		{
			Console.WriteLine ("application registered with GCM");
			// register this device
			Notificare.Shared ().RegisterDevice (deviceId, new RegisterDeviceCallback ());
		}

		public override void OnNotificationOpened(String alert, String notificationId, Bundle extras)
		{
			Console.WriteLine ("notification opened");
			base.OnNotificationOpened (alert, notificationId, extras);
		}

	}
}

