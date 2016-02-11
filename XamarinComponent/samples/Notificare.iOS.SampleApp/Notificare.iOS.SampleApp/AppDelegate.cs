using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Notificare.iOS;

namespace Notificare.iOS.SampleApp
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		Notificare_iOS_SampleAppViewController viewController;
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

			viewController = new Notificare_iOS_SampleAppViewController ();
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();


			NotificarePushLib.Shared().Launch ();
			_pushLibDelegate = new MyPushLibDelegate ();
			NotificarePushLib.Shared ().Delegate = _pushLibDelegate;
			NotificarePushLib.Shared().HandleOptions (options);

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
					viewController.ShowPushEnabled();
					// Add tags for this device. Normally, you would leave this up to the user to set from a preferences view or other conditions in the app.
					// Uncomment the line below to make sure the two tags are enabled at startup, so you can send to these tags from the dashboard
					// If you leave this line out, you will first have to set the tags on the preferences view
					//AddTags(NSArray.FromStrings("tag_something", "tag_something2"));
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

		public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
		{
			NotificarePushLib.Shared().HandleNotificationForApplication(userInfo, application, (NSDictionary info) => {
				completionHandler(UIBackgroundFetchResult.NewData);				
			}, (NSError error) => {
				completionHandler(UIBackgroundFetchResult.Failed);
			});
		}

		public override void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
		{
			// Open Notification Directly
			NotificarePushLib.Shared ().OpenNotification (userInfo);
		}

		class MyPushLibDelegate : NotificarePushLibDelegate {

			public override void OnReady (NotificarePushLib library, NSDictionary info)
			{
				// Start notifications
				Console.WriteLine ("Notificare ready, register for notifications");
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
				Console.WriteLine ("Will exexcute action");
			}

			public override void DidExecuteAction(NotificarePushLib library, NSDictionary info)
			{
				Console.WriteLine ("Did execute action");
			}

			public override void ShouldPerformSelectorWithURL(NotificarePushLib library, NSUrl url)
			{
				Console.WriteLine ("Should perform selector with url: {0}", url);
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
		}

	}
}

