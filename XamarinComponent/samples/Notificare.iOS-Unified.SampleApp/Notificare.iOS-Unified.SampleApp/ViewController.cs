using System;

using UIKit;
using Foundation; 

namespace Notificare.iOS.SampleApp
{
	public partial class ViewController : UIViewController
	{
		public InboxTableViewDataSource dataSource;
		public UITableView inboxTableView;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			inboxTableView = new UITableView (View.Bounds);
			dataSource = new InboxTableViewDataSource ();
			inboxTableView.Source = dataSource;
			Add (inboxTableView);
		}

		public void ReloadInbox() {
			NotificarePushLib.Shared ().FetchInbox (null, null, null, (NSDictionary info) => {
				if (((NSNumber)info.ObjectForKey ((NSString)"total")).NIntValue == 0) {
					dataSource.InboxItems = new NSArray ();
				} else {
					dataSource.InboxItems = (NSArray)info.ObjectForKey ((NSString)"inbox");
				}
				inboxTableView.ReloadData ();
			}, (NSError error) => {
				dataSource.InboxItems = new NSArray ();
				inboxTableView.ReloadData ();
			});
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			ReloadInbox ();
		}

	}
}

