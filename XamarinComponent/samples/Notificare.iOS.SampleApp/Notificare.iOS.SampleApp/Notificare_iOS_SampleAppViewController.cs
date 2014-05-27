using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Notificare.iOS.SampleApp
{
	public partial class Notificare_iOS_SampleAppViewController : UIViewController
	{
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
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public void ShowPushEnabled()
		{
			this.pushEnabledLabel.Hidden = false;
			this.preferenceButton.Enabled = true;
		}

		partial void openPreferences (NSObject sender)
		{
			NotificarePushLib.Shared().OpenUserPreferences();
		}

	}
}

