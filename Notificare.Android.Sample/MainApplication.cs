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

namespace Notificare.Sample.Android
{
	[Application]
	public class MainApplication : Application
	{
		public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		public override void OnCreate()
		{
			base.OnCreate ();

			Console.WriteLine ("Loading...");

			// Launch Notificare system
			Notificare.Android.Notificare.Shared ().Launch (this);
			Notificare.Android.Notificare.Shared ().IntentReceiver = Java.Lang.Class.FromType(typeof(MyIntentReceiver));
			Notificare.Android.Notificare.Shared ().AutoCancel = Java.Lang.Boolean.False;

			// Will this work?
			Notificare.Android.Notificare.Shared ().EnableNotifications ();
			Console.WriteLine ("Done loading");

		}
	}
}

