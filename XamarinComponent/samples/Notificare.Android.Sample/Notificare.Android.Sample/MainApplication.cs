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

namespace Notificare.Android.Sample
{
	[Application (Debuggable=true, AllowClearUserData=true, Icon="@drawable/icon", Theme="@style/AppTheme" )]
	public class MainApplication : Application
	{
		public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		public override void OnCreate()
		{
			base.OnCreate ();

			// Launch Notificare system
			Notificare.Shared ().Launch (this);
			// Use our custom intent receiver
			Notificare.Shared ().IntentReceiver = Java.Lang.Class.FromType(typeof(MyIntentReceiver));
			// Use our preferences from XML
			Notificare.Shared ().UserPreferencesResource = Resource.Xml.preferences;
			// Keep notifications in the drawer, remove this line or set to true if you want them to clear automatically when opened
			Notificare.Shared ().AutoCancel = Java.Lang.Boolean.False;

			// Enable notifications
			Notificare.Shared ().EnableNotifications ();
		}
	}
}

