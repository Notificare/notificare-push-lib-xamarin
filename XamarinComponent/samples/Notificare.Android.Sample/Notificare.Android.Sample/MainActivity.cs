using System;
using System.Collections.Generic;

using Java.Util;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Text.Format;
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

		private ListView listView;
		protected ArrayAdapter<NotificareInboxItem> inboxListAdapter;
		private const String TAG = "InboxActivity";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			listView = FindViewById<ListView>(Resource.Id.inboxList);

			Notificare.Shared ().AddNotificareReadyListener (this);

			inboxListAdapter = new InboxListAdapter(this, Resource.Layout.InboxListCell);
			listView.Adapter = inboxListAdapter;

			TextView EmptyText = FindViewById<TextView>(Resource.Id.empty_message);
			listView.EmptyView = EmptyText;

			listView.ItemClick += (sender, e) => {
				NotificareInboxItem MyItem = inboxListAdapter.GetItem(e.Position);
				Notificare.Shared().InboxManager.MarkItem(MyItem);
				Notificare.Shared().OpenNotification(this, MyItem.Notification);
			};

		}

		protected override void OnResume() {
			base.OnResume();
			inboxListAdapter.Clear();
			if (Notificare.Shared().InboxManager != null) {
				NotificareInboxManager manager = Notificare.Shared ().InboxManager;
				Java.Util.ISortedSet items = manager.Items;
				Console.WriteLine ("We have {0} items", Notificare.Shared ().InboxManager.Items.Size ());
				foreach (NotificareInboxItem item in Notificare.Shared ().InboxManager.Items.ToArray()) {
					inboxListAdapter.Add(item);
				}
			}
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

		/**
     	 * List adapter to show a row per beacon
     	 */
		public class InboxListAdapter: ArrayAdapter<NotificareInboxItem> {

			private Activity context;
			private int resource;

			public InboxListAdapter(Activity context, int resource): base(context, resource)
			{
				this.context = context;
				this.resource = resource;
			}

			public override View GetView(int position, View convertView, ViewGroup parent) {
				LayoutInflater inflater = context.LayoutInflater;
				View rowView = convertView;
				if (rowView == null) {
					rowView = inflater.Inflate(resource, null, true);
				}
				TextView dateView = rowView.FindViewById<TextView>(Resource.Id.inbox_date);
				TextView messageView = rowView.FindViewById<TextView>(Resource.Id.inbox_message);
				NotificareInboxItem item = GetItem(position);

				dateView.Text = DateUtils.GetRelativeTimeSpanString(item.Timestamp.Time, new Date().Time, DateUtils.SecondInMillis);
				messageView.Text = item.Notification.Message;
				dateView.SetTextColor(Color.Black);
				messageView.SetTextColor(Color.Black);
				if (item.Status.BooleanValue()) {
					dateView.SetTextColor(Color.Gray);
					messageView.SetTextColor(Color.Gray);
				}
				return rowView;
			}
		}


	}
}


