using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Notificare.iOS.SampleApp
{
	public partial class Notificare_iOS_SampleAppViewController : UITableViewController
	{
		public NSMutableArray NavSections { get; set; }
		public NSMutableArray SectionTitles { get ; set; }

		MyTableViewSource _Source;

		public Notificare_iOS_SampleAppViewController () : base ("Notificare_iOS_SampleAppViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			_Source = new MyTableViewSource ();
			tableView.Source = _Source;
			_Source.Parent = this;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			ReloadData ();
		}

		public void ReloadData () {
			NavSections = new NSMutableArray();
			SectionTitles = new NSMutableArray();

			SectionTitles.Add(new NSString("Inbox"));

			NotificarePushLib.Shared().FetchInbox(null, null, null, (NSDictionary info) => {

				if (((NSNumber)info.ObjectForKey(new NSString("total"))).IntValue == 0) {
					NavSections.Add(new NSArray());
				} else {
					NavSections.Add(info.ObjectForKey(new NSString("inbox")));
				}
				tableView.ReloadData();
			}, (NSError error) => {
				NavSections.Add(new NSArray());
				tableView.ReloadData();
			});
		}

		class MyTableViewSource : UITableViewSource {

			public Notificare_iOS_SampleAppViewController Parent { get; set; }

			static NSString CellType = new NSString("InboxCell");

			public override int NumberOfSections (UITableView tableView)
			{
				return (int)Parent.NavSections.Count;
			}

			public override int RowsInSection (UITableView tableview, int section)
			{
				return (int)Parent.NavSections.GetItem<NSArray> (section).Count;
			}

			public override float GetHeightForHeader (UITableView tableView, int section)
			{
				return 0;
			}

			public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
			{
				return 44;
			}

			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				UITableViewCell cell = Parent.tableView.DequeueReusableCell (CellType);

				if (cell == null) {
					cell = new UITableViewCell ();
				}
				NotificareDeviceInbox item = Parent.NavSections.GetItem<NSArray> (indexPath.Section).GetItem<NotificareDeviceInbox> (indexPath.Row);
				cell.TextLabel.Text = item.Message;
				return cell;
			}
		}


	}
}

