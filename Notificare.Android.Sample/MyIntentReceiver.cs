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

namespace Notificare.Sample.Android
{
	public class RegisterDeviceCallback : Java.Lang.Object, INotificareCallback
	{
		void INotificareCallback.OnSuccess(Java.Lang.Object success)
		{
			Console.WriteLine ("success");
			Notificare.Android.Notificare.Shared ().EnableLocationUpdates ();
		}

		void INotificareCallback.OnError(NotificareError error)
		{
			Console.WriteLine ("error");
		}
	}

	[BroadcastReceiver]
	public class MyIntentReceiver : DefaultIntentReceiver
	{
		public override void OnRegistrationFinished(String deviceId) 
		{
			Notificare.Android.Notificare.Shared ().RegisterDevice (deviceId, new RegisterDeviceCallback ());
		}

		public override void OnNotificationOpened(String alert, String notificationId, Bundle extras)
		{
			Console.WriteLine ("notification opened");
			base.OnNotificationOpened (alert, notificationId, extras);
		}

	}
}

