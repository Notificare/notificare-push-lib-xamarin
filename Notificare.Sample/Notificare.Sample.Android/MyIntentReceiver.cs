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
using Notificare.Android.Model;
using Notificare.Android;

namespace Notificare.Sample.Android
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

    public class UserLoginCallback : Java.Lang.Object, INotificareCallback
    {
        void INotificareCallback.OnSuccess(Java.Lang.Object p0)
        {
            Console.WriteLine("logged in");
        }
        void INotificareCallback.OnError(NotificareError error)
        {
            Console.WriteLine("error logging in: " + error.Message);
        }
    }

	public class RegisterDeviceCallback : Java.Lang.Object, INotificareCallback
	{
		void INotificareCallback.OnSuccess(Java.Lang.Object success)
		{
			Console.WriteLine ("successfully registered device");
			// Now, enable location updates
			if (Notificare.Android.Notificare.Shared ().IsLocationUpdatesEnabled().BooleanValue()) {
				Notificare.Android.Notificare.Shared ().EnableLocationUpdates ();
				//Notificare.Android.Notificare.Shared ().EnableBeacons ();
			}
			Notificare.Android.Notificare.Shared ().AddDeviceTags (new List<String> (){ "xamarin" }, new AddDeviceTagsCallback ());
		}

		void INotificareCallback.OnError(NotificareError error)
		{
			Console.WriteLine ("error registering device: " + error.Message);
		}
	}

	[BroadcastReceiver]
	public class MyIntentReceiver : DefaultIntentReceiver
	{
		public override void OnRegistrationFinished(String deviceId) 
		{
			Console.WriteLine ("application registered with GCM as " + deviceId);
			// register this device
			Notificare.Android.Notificare.Shared ().RegisterDevice (deviceId, new RegisterDeviceCallback ());
		}
			
		public override void OnReady ()
		{
			Console.WriteLine ("notificare ready");
			Notificare.Android.Notificare.Shared ().EnableNotifications ();
		}

		public override void OnRangingBeacons(IList<NotificareBeacon> Beacons) {
			foreach (NotificareBeacon Beacon in Beacons) {
				Console.WriteLine (Beacon.CurrentDistance);
			}
		}
	}
}

