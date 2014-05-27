# Notificare

The official Notificare Xamarin SDK. Rich and interactive push notifications for iOS, Android and Web. Enhance your apps with location based messages that really work.

### Setup

* Sign up for a [Notificare](https://dashboard.notifica.re/#/sign-up) account and create a new application.
* Sign in to [Apple Developer Portal](https://developer.apple.com/account/overview.action) and create an Explicit AppID with Push Notifications enabled.
* Create an APNS Development Certificate (Sandbox) for that App ID
* Create a Development Provisioning Profile for that app and the device(s) you want it to run on.
* Download the APNS certificate and export it as a .p12 file from your keychain. Upload to [Notificare dashboard](https://dashboard.notifica.re/) under Settings - Services
* In Xamarin Studio or Visual Studio, create a new iOS or Android project with the Bundle ID you created the App with in Apple Developer Portal.
* Using Xamarin Studio's built-in Component Store, add the free Notificare component to your project.
* Find your Application Key and Application Secret in the [Notificare dashboard](https://dashboard.notifica.re/) under Settings - App Keys.

### Implementation

If you're building an iOS app, add the NotificareResources.bundle from the Notificare.iOS.SampleApp to your project. This bundle contains user interface elements that are used in displaying the notifications.
Then, add this to your `AppDelegate.cs` file:

```csharp
using Notificare.iOS;
```

```csharp
public partial class AppDelegate : UIApplicationDelegate
{
	...

	public override bool FinishedLaunching (UIApplication app, NSDictionary options)
	{

	...

		// Initialize Notificare
		NotificarePushLib.Shared().Launch ();

		// Start notifications
		NotificarePushLib.Shared().RegisterForRemoteNotifications (UIRemoteNotificationType.Alert | UIRemoteNotificationType.Sound | UIRemoteNotificationType.Badge);
		if (options != null && options.ContainsKey( UIApplication.LaunchOptionsRemoteNotificationKey ) ) 
		{
			NotificarePushLib.Shared().HandleOptions (options [UIApplication.LaunchOptionsRemoteNotificationKey] as NSDictionary);
		}

	...
		
	}

	public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
	{
		Console.WriteLine ("Registering device: {0}", deviceToken );

		// If you have a userID and userName, use RegisterDeviceWithUserID / RegisterDeviceWithUserIDWithUserName
		NotificarePushLib.Shared ().RegisterDevice (
			deviceToken,
			(NSDictionary info) => {
				Console.WriteLine("Device registered: {0}", info);
				NotificarePushLib.Shared ().StartLocationUpdates ();
			},
			(NSError error) => {
				Console.WriteLine("Error registering device: {0}", error);
			}
		);

	}

	public override void ReceivedRemoteNotification (UIApplication application, NSDictionary userInfo)
	{
		// Open Notification Directly
		NotificarePushLib.Shared ().OpenNotification (userInfo);
	}

	...

}
```

### Documentation

[Developer Documentation](https://notificare.atlassian.net/wiki/display/notificare/Getting+started+with+Xamarin)
[Dashboard Documentation](https://notificare.atlassian.net/wiki/display/notificare/Web+Dashboard+Interface+Guide)
[Terms & Conditions](http://notifica.re/terms/)

### Contact

[Contact](http://notifica.re/contact)
[Blog](http://notifica.re/blog)
[Twitter](https://twitter.com/notificare)
