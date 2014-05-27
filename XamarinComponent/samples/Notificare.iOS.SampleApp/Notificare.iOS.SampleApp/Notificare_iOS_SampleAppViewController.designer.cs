// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Notificare.iOS.SampleApp
{
	[Register ("Notificare_iOS_SampleAppViewController")]
	partial class Notificare_iOS_SampleAppViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton preferenceButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel pushEnabledLabel { get; set; }

		[Action ("openPreferences:")]
		partial void openPreferences (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (pushEnabledLabel != null) {
				pushEnabledLabel.Dispose ();
				pushEnabledLabel = null;
			}

			if (preferenceButton != null) {
				preferenceButton.Dispose ();
				preferenceButton = null;
			}
		}
	}
}
