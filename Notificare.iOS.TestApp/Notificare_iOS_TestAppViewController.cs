using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Notificare.iOS.TestApp
{
	public partial class Notificare_iOS_TestAppViewController : UIViewController
	{

		public Notificare_iOS_TestAppViewController () : base ("Notificare_iOS_TestAppViewController", null)
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

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}
	}
}

