using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text;
#if __UNIFIED__
using Foundation;
using UIKit;
using CoreLocation;
using Security;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using MonoTouch.Security;
#endif
using Notificare.iOS;

namespace Notificare.iOS.TestApp
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		Notificare_iOS_TestAppViewController viewController;
		NotificarePushLibDelegate _pushLibDelegate;
		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			viewController = new Notificare_iOS_TestAppViewController ();
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();

			NotificarePushLib.Shared().Launch ();
			_pushLibDelegate = new MyPushLibDelegate ();
			NotificarePushLib.Shared ().Delegate = _pushLibDelegate;

			// Start notifications
			if (options != null && options.ContainsKey( UIApplication.LaunchOptionsRemoteNotificationKey ) ) 
			{
				NotificarePushLib.Shared().HandleOptions (options [UIApplication.LaunchOptionsRemoteNotificationKey] as NSDictionary);
			}

			return true;
		}

		private void AddTags(NSArray tags) {
			NotificarePushLib.Shared ().AddTags (
				tags,
				(NSDictionary info) => {
					Console.WriteLine ("tags added");
				},
				(NSError error) => {
					Console.WriteLine ("error adding tags: {0}", error);
				}
			);
		}

		public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
		{
			Console.WriteLine ("Registering device: {0}", deviceToken );

			// If you have a userID and userName, use RegisterDeviceWithUserID / RegisterDeviceWithUserIDWithUserName
			NotificarePushLib.Shared ().RegisterDevice (
				deviceToken,
				(NSDictionary info) => {
					Console.WriteLine("Device registered: {0}", info);
					// Add tags for this device. Normally, you would leave this up to the user or other conditions in the app.
					AddTags(NSArray.FromStrings("tag_something", "tag_something2"));
					NotificarePushLib.Shared ().StartLocationUpdates ();
				},
				(NSError error) => {
					Console.WriteLine("Error registering device: {0}", error);
				}
			);

		}

		public override void FailedToRegisterForRemoteNotifications (UIApplication application, NSError error)
		{
			Console.WriteLine ("Failed to register for notifications: {0}", error );
		}

		public override void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
		{
			// Open Notification Directly
			NotificarePushLib.Shared ().OpenNotification (userInfo);
		}
			
		public override void HandleAction (UIApplication application, string actionIdentifier, NSDictionary remoteNotificationInfo, Action completionHandler)
		{
			NotificarePushLib.Shared ().HandleActionForNotificationWithData ((NSString)actionIdentifier, 
				remoteNotificationInfo, 
				null, 
				(NSDictionary info) => {
					completionHandler();
				},
				(NSError error) => {
					completionHandler();
				}
			);
		}

		class MyPushLibDelegate : NotificarePushLibDelegate {
			public override void OnReady (NotificarePushLib library, NSDictionary info)
			{
				library.RegisterForNotifications ();
			}

			public override void WillOpenNotification(NotificarePushLib library, NotificareNotification notification)
			{
				Console.WriteLine ("Will open notification");
			}

			public override void DidOpenNotification(NotificarePushLib library, NotificareNotification notification)
			{
				Console.WriteLine ("Did open notification: {0}", notification);
			}

			public override void DidCloseNotification(NotificarePushLib library, NotificareNotification notification)
			{
				Console.WriteLine ("Did close notification");
			}

			public override void DidFailToOpenNotification(NotificarePushLib library, NotificareNotification notification)
			{
				Console.WriteLine ("Failed to open notification");
			}

			public override void WillExecuteAction(NotificarePushLib library, NotificareNotification notification)
			{
				Console.WriteLine ("Will execute action");
			}

			public override void DidExecuteAction(NotificarePushLib library, NSDictionary info)
			{
				Console.WriteLine ("Did execute action");
			}

			public override void ShouldPerformSelectorWithURL(NotificarePushLib library, NSUrl url)
			{
				Console.WriteLine ("Should perform selector: " + url.ToString());
			}

			public override void DidNotExecuteAction(NotificarePushLib library, NSDictionary info)
			{
				Console.WriteLine ("Did not execute action");
			}

			public override void DidFailToExecuteAction(NotificarePushLib library, NSDictionary info)
			{
				Console.WriteLine ("Did fail to execute action");
			}

			public override void DidReceiveLocationServiceAuthorizationStatus(NotificarePushLib library, NSDictionary status)
			{
				Console.WriteLine ("Received location service authorization status: {0}", status ["status"]);
			}

			public override void DidFailToStartLocationServiceWithError (NotificarePushLib library, NSError error) 
			{
				Console.WriteLine ("Failed to start location service: {0}", error);
			}

			public override void DidUpdateLocations (NotificarePushLib library, NSArray locations)
			{
				Console.WriteLine ("Update locations");
			}

			public override void DidRangeBeaconsInRegion (NotificarePushLib library, NSArray beacons, CLRegion region) 
			{
				Console.WriteLine ("Did range {0} beacons", beacons.Count);
			}
		
		}
	}

}

