# Notificare

The official Notificare Xamarin SDK. Rich and interactive push notifications for iOS, Android and Web. Enhance your apps with location based messages that really work.

### Setup iOS

* Sign up for a [Notificare](https://dashboard.notifica.re/#/sign-up) account and create a new application.
* Sign in to [Apple Developer Portal](https://developer.apple.com/account/overview.action) and create an Explicit AppID with Push Notifications enabled.
* Create an APNS Development Certificate (Sandbox) for that App ID
* Create a Development Provisioning Profile for that app and the device(s) you want it to run on.
* Download the APNS certificate and export it as a .p12 file from your keychain. Upload to [Notificare dashboard](https://dashboard.notifica.re/) under Settings - Services
* In Xamarin Studio or Visual Studio, create a new iOS project with the Bundle ID you created the App with in Apple Developer Portal.
* Using Xamarin Studio's built-in Component Store, add the free Notificare component to your project.
* Find your Application Key and Application Secret in the [Notificare dashboard](https://dashboard.notifica.re/) under Settings - App Keys. Use these to fill Notifcare.plist

### Setup Android

* Sign up for a [Notificare](https://dashboard.notifica.re/#/sign-up) account and create a new application.
* Sign in to [Google API Console](https://console.developers.google.com/project) and create a project. Write down the Project Number.
* Go to APIs & auth and enable the Google Cloud Messaging for Android API
* Under credentials, add a server key. Write down the generated API key.
* Enter the newly created API key and your app's package name in [Notificare dashboard](https://dashboard.notifica.re/) under Settings - Services - Android
* In Xamarin Studio or Visual Studio, create a new Android project with that same package name.
* Using Xamarin Studio's built-in Component Store, add the free Notificare component to your project.
* In the same Component Store, add the Google Play Services component for Gingerbread.
* Find your Application Key and Application Secret in the [Notificare dashboard](https://dashboard.notifica.re/) under Settings - App Keys. Use these to fill notificare.properties together with the Project Number from the Google API Console.

### Implementation iOS

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

### Implementation Android

In Android, you need to make a couple of changes if you want to have some control over device registration and event logging.

First of all, you will need your own IntentReceiver, a subclass of DefaultIntentReceiver

```csharp
using Notificare.Android.Push.GCM;
using Notificare.Android;

namespace Notificare.Sample.Android
{
	[BroadcastReceiver]
	public class MyIntentReceiver : DefaultIntentReceiver
	{
		public override void OnRegistrationFinished(String deviceId) 
		{
			Notificare.Android.Notificare.Shared ().RegisterDevice (deviceId, new RegisterDeviceCallback ());
		}
	}

	public class RegisterDeviceCallback : Java.Lang.Object, INotificareCallback
	{
		void INotificareCallback.OnSuccess(Java.Lang.Object success)
		{
			Notificare.Android.Notificare.Shared ().EnableLocationUpdates ();
		}

		void INotificareCallback.OnError(NotificareError error)
		{
			Console.WriteLine ("error");
		}
	}

}

```

The [BroadcastReceiver] attribute will automatically add your IntentReceiver to the AndroidManifest.xml


Now, your app should know this is going to be the IntentReceiver to use, so you need to implement your own Application subclass


```csharp
namespace Notificare.Sample.Android
{
	[Application]
	public class MainApplication : Application
	{
		public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		public override void OnCreate()
		{
			base.OnCreate ();

			// Launch Notificare system
			Notificare.Android.Notificare.Shared ().Launch (this);
			Notificare.Android.Notificare.Shared ().IntentReceiver = Java.Lang.Class.FromType(typeof(MyIntentReceiver));
			Notificare.Android.Notificare.Shared ().AutoCancel = Java.Lang.Boolean.False;

			Notificare.Android.Notificare.Shared ().EnableNotifications ();
		}
	}
}

```

Finally, you should add the following lines to your AndroidManifest.xml

```xml
  <uses-permission android:name="android.permission.GET_ACCOUNTS" />
  <uses-permission android:name="android.permission.WAKE_LOCK" />
  <uses-permission android:name="android.permission.INTERNET" />
  <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
  <uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
  <uses-permission android:name="com.google.android.providers.gsf.permission.READ_GSERVICES" />
  <uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
  <uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
  <uses-permission android:name="com.google.android.c2dm.permission.RECEIVE" />
  <permission android:name=".permission.C2D_MESSAGE" android:protectionLevel="signature" />
  <uses-permission android:name=".permission.C2D_MESSAGE" />
```

add the following inside the AndroidManifest application element


```xml
    <receiver android:name="re.notifica.push.gcm.PushReceiver" android:permission="com.google.android.c2dm.permission.SEND">
      <intent-filter>
        <action android:name="com.google.android.c2dm.intent.RECEIVE" />
        <action android:name="com.google.android.c2dm.intent.REGISTRATION" />
        <!-- Replace with your package name -->
        <category android:name="notificare.sample.android" />
      </intent-filter>
    </receiver>

    <service android:name="re.notifica.push.gcm.PushService" android:label="Notificare Push Service" />
    <activity android:name="re.notifica.ui.NotificationActivity" />
    <activity android:name="re.notifica.ui.UserPreferencesActivity" />
```

If you need to push maps to your app, you will need an API key for Google Maps for Android. See [Android Documentation](https://developers.google.com/maps/documentation/android/start#get_an_android_certificate_and_the_google_maps_api_key) for details

If you want to log app activity events to Notificare, like app opens and session length, your activities should either override re.notifica.push.gcm.BaseActivity, or add the following method calls to OnResume and OnPause

```csharp
	protected override void OnResume (Bundle bundle)
	{
		base.OnResume (bundle);

		...

		Notificare.Android.Notificare.Shared ().SetForeground (Java.Lang.Boolean.True);
		Notificare.Android.Notificare.Shared ().EventLogger.LogStartSession ();
	}

	protected override void OnPause
	{
		base.OnPause();

		...

		Notificare.Android.Notificare.Shared ().SetForeground (Java.Lang.Boolean.False);
		Notificare.Android.Notificare.Shared ().EventLogger.LogStopSession ();
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
