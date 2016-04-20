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

			// Launch Notificare system
			Notificare.Android.Notificare.Shared ().Launch (this);
			Notificare.Android.Notificare.Shared ().SetDebugLogging (Java.Lang.Boolean.True);
			// Use our custom intent receiver
			Notificare.Android.Notificare.Shared ().IntentReceiver = Java.Lang.Class.FromType(typeof(MyIntentReceiver));
			// Keep notifications in the drawer, remove this line or set to true if you want them to clear automatically when opened
			Notificare.Android.Notificare.Shared ().AutoCancel = Java.Lang.Boolean.True;
			Notificare.Android.Notificare.Shared ().AllowJavaScript = Java.Lang.Boolean.True;
			Notificare.Android.Notificare.Shared ().AllowOrientationChange = Java.Lang.Boolean.True;
		}
	}
}

