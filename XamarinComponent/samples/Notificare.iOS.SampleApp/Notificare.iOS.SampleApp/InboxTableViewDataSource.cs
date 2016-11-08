using System;
using UIKit;
using Foundation;

namespace Notificare.iOS.SampleApp
{
	[Register ("InboxTableViewDataSource")]
	public class InboxTableViewDataSource : UITableViewSource
	{

		public NSArray InboxItems { get; set; }
		private static NSString cellIdentifier = (NSString)"inboxItemCell";

		public InboxTableViewDataSource() : base()
		{
			InboxItems = new NSArray ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}
			
		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 44;
		}

		public override nfloat GetHeightForHeader (UITableView tableView, nint section)
		{
			return 0;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return (nint)InboxItems.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			}
			cell.TextLabel.Text = InboxItems.GetItem<NotificareDeviceInbox> ((nuint)indexPath.Row).Message;
			cell.SelectionStyle = UITableViewCellSelectionStyle.None;
			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			NotificareDeviceInbox inboxItem = InboxItems.GetItem<NotificareDeviceInbox> ((nuint)indexPath.Row);
			if (inboxItem != null) {
				NotificarePushLib.Shared ().OpenInboxItem(inboxItem);
			}
		}

	}
}

