using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using Foundation;
using UIKit;
using CoreLocation;
using CoreGraphics;
using Security;
using StoreKit;
using Notificare.iOS;

namespace Notificare.Sample.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		NotificarePushLibDelegate _pushLibDelegate;
		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//

        public override UIWindow Window
        {
            get;
            set;
        }

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			NotificarePushLib.Shared().Launch ();
			_pushLibDelegate = new MyPushLibDelegate ();
			NotificarePushLib.Shared().Delegate = _pushLibDelegate;

			// Start notifications
			NotificarePushLib.Shared().HandleOptions (launchOptions);
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
					NotificarePushLib.Shared().FetchAssets((NSString)"test", (NSArray assets) => {
						if (assets.Count > 0) {							
							Console.WriteLine(assets.GetItem<NotificareAsset>(0).AssetUrl);
						}
					}, (NSError error) => {
						Console.WriteLine("Error fetching assets: {0}", error);
					});

					NotificarePushLib.Shared().FetchDoNotDisturb((NSDictionary dndInfo) => {
						Console.WriteLine(dndInfo);
						//if (dndInfo.ObjectForKey((NSString)"start") == null) {
							//	NSDate start = NSDate.Now;
							//	NSDate end = start.AddSeconds(3600);
							//	Console.WriteLine("Updating DND with Start {0}, End {1}", start, end);
							//	NotificarePushLib.Shared().UpdateDoNotDisturb(start, end, Console.WriteLine, (NSError error) => {
							//		Console.WriteLine("error updating DND: {0}", error.LocalizedDescription);
							//	});
							//}
						}, (NSError error) => {
							Console.WriteLine("error fetching DND: {0}", error);
						}
					);
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

		public override void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler) {
			NotificarePushLib.Shared().HandleNotificationForApplication(userInfo, application, (NSDictionary info) => {
				Console.WriteLine ("DidReceiveRemoteNotification info: {0}", info);
				completionHandler (UIBackgroundFetchResult.NewData);	
			}, (NSError error) => {
				Console.WriteLine ("DidReceiveRemoteNotification error: {0}", error);
				completionHandler (UIBackgroundFetchResult.Failed);
			});
		}

		public override void HandleAction (UIApplication application, string actionIdentifier, NSDictionary remoteNotificationInfo, NSDictionary responseInfo, Action completionHandler)
		{
			Console.WriteLine ("Response: {0}", responseInfo.ObjectForKey((NSString)"UIUserNotificationActionResponseTypedTextKey"));
			NotificarePushLib.Shared ().HandleActionForNotificationWithData ((NSString)actionIdentifier, 
				remoteNotificationInfo, 
				responseInfo, 
				(NSDictionary info) => {
					Console.WriteLine ("HandleAction info: {0}", info);
					completionHandler();
				},
				(NSError error) => {
					Console.WriteLine ("HandleAction error: {0}", error);
					completionHandler();
				}
			);
		}

		public override void HandleAction(UIApplication application, string actionIdentifier, NSDictionary remoteNotificationInfo, Action completionHandler)
		{
			NotificarePushLib.Shared().HandleActionForNotificationWithData((NSString)actionIdentifier,
				remoteNotificationInfo,
				null,
				(NSDictionary info) =>
				{
					Console.WriteLine("HandleAction info: {0}", info);
					completionHandler();
				},
				(NSError error) =>
				{
					Console.WriteLine("HandleAction error: {0}", error);
					completionHandler();
				}
			);
		}

		class MyPushLibDelegate : NotificarePushLibDelegate {
			public override void OnReady (NotificarePushLib library, NSDictionary info)
			{
				library.RegisterForNotifications ();
			}

			public override void WillHandleNotification(NotificarePushLib library, UserNotifications.UNNotification notification)
			{
				library.HandleNotification(notification, (NSDictionary info) => { 
					Console.WriteLine("HandleNotification info: {0}", info);
				}, (NSError error) => {
					Console.WriteLine("HandleNotification error: {0}", error);
				});
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

