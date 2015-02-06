using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;
using MonoTouch.StoreKit;


namespace Notificare.iOS
{
	[BaseType (typeof (NSObject))]
	public interface NotificareAction
	{

		/*
		 * @property (strong, nonatomic) NSString * actionType;
		 */

		/// <summary>
		/// Gets the type of the action.
		/// </summary>
		/// <value>The type of the action.</value>
		[Export("actionType")]
		NSString ActionType { get; }

		/*
		 * @property (strong, nonatomic) NSString * actionLabel;
		 */

		/// <summary>
		/// Gets the action label.
		/// </summary>
		/// <value>The action label.</value>
		[Export("actionLabel")]
		NSString ActionLabel { get; }


		/*
		 * @property (strong, nonatomic) NSString * actionTarget;
		 */

		/// <summary>
		/// Gets the action target.
		/// </summary>
		/// <value>The action target.</value>
		[Export("actionTarget")]
		NSString ActionTarget { get; }


		/*
		 * @property (nonatomic, assign) BOOL actionKeyboard;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareAction"/> needs keyboard.
		/// </summary>
		/// <value><c>true</c> if action keyboard; otherwise, <c>false</c>.</value>
		[Export("actionKeyboard")]
		bool ActionKeyboard { get; }


		/*
		 * @property (nonatomic, assign) BOOL actionCamera;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareAction"/> needs camera.
		/// </summary>
		/// <value><c>true</c> if action camera; otherwise, <c>false</c>.</value>
		[Export("actionCamera")]
		bool ActionCamera { get; }

	}

	[BaseType (typeof (NSObject))]
	public interface NotificareAttachment
	{

		/*
		 * @property (strong, nonatomic) NSString * attachmentURI;
		 */

		/// <summary>
		/// Gets the attachment URI.
		/// </summary>
		/// <value>The attachment URI.</value>
		[Export("attachmentURI")]
		NSString AttachmentURI { get; }

		/*
		 * @property (strong, nonatomic) NSString * attachmentMimeType;
		 */

		/// <summary>
		/// Gets the MIME type of the attachment.
		/// </summary>
		/// <value>The MIME type of the attachment.</value>
		[Export("attachmentMimeType")]
		NSString AttachmentMimeType { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface NotificareBeacon
	{
		/*
		 * @property (strong, nonatomic) NSString * name;
		 */

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		[Export("name")]
		NSString Name { get; }


		/*
		 * @property (strong, nonatomic) NSString * region;
		 */

		/// <summary>
		/// Gets the region.
		/// </summary>
		/// <value>The region.</value>
		[Export("region")]
		NSString Region { get; }


		/*
		 * @property (strong, nonatomic) NSUUID * beaconUUID;
		 */

		/// <summary>
		/// Gets the beacon UUI.
		/// </summary>
		/// <value>The beacon UUI.</value>
		[Export("beaconUUID")]
		NSUuid BeaconUUID { get; }


		/*
		 * @property (strong, nonatomic) NSString * major;
		 */

		/// <summary>
		/// Gets the major.
		/// </summary>
		/// <value>The major.</value>
		[Export("major")]
		NSString Major { get; }


		/*
		 * @property (strong, nonatomic) NSString * minor;
		 */

		/// <summary>
		/// Gets the minor.
		/// </summary>
		/// <value>The minor.</value>
		[Export("minor")]
		NSString Minor { get; }


		/*
		 * @property (strong, nonatomic) NSString * proximity;
		 */

		/// <summary>
		/// Gets the proximity.
		/// </summary>
		/// <value>The proximity.</value>
		[Export("proximity")]
		NSString Proximity { get; }


		/*
		 * @property (strong, nonatomic) NSDictionary * proximityNotifications;
		 */

		/// <summary>
		/// Gets the proximity notifications.
		/// </summary>
		/// <value>The proximity notifications.</value>
		[Export("proximityNotifications")]
		NSDictionary ProximityNotifications { get; }


		/*
		 * @property (strong, nonatomic) NSString * application;
		 */

		/// <summary>
		/// Gets the application.
		/// </summary>
		/// <value>The application.</value>
		[Export("application")]
		NSString Application { get; }


		/*
		 * @property (strong, nonatomic) NSDictionary * notification;
		 */

		/// <summary>
		/// Gets the notification.
		/// </summary>
		/// <value>The notification.</value>
		[Export("notification")]
		NSDictionary Notification { get; }


		/*
		 * @property (strong, nonatomic) NSString * latitude;
		 */

		/// <summary>
		/// Gets the latitude.
		/// </summary>
		/// <value>The latitude.</value>
		[Export("latitude")]
		NSString Latitude { get; }


		/*
		 * @property (strong, nonatomic) NSString * longitude;
		 */

		/// <summary>
		/// Gets the longitude.
		/// </summary>
		/// <value>The longitude.</value>
		[Export("longitude")]
		NSString Longitude { get; }


		/*
		 * @property (strong, nonatomic) NSString * batteryLevel;
		 */

		/// <summary>
		/// Gets the battery level.
		/// </summary>
		/// <value>The battery level.</value>
		[Export("batteryLevel")]
		NSString BatteryLevel { get; }


		/*
		 * @property (strong, nonatomic) NSString * purpose;
		 */

		/// <summary>
		/// Gets the purpose.
		/// </summary>
		/// <value>The purpose.</value>
		[Export("purpose")]
		NSString Purpose { get; }


		/*
		 * @property (strong, nonatomic) CLBeacon * beacon;
		 */

		/// <summary>
		/// Gets the beacon.
		/// </summary>
		/// <value>The beacon.</value>
		[Export("beacon")]
		CLBeacon Beacon { get; }


		/*
		 * @property (strong, nonatomic) NSString * timezone;
		 */

		/// <summary>
		/// Gets the timezone.
		/// </summary>
		/// <value>The timezone.</value>
		[Export("timezone")]
		NSString Timezone { get; }


		/*
		 * @property (assign, nonatomic) BOOL triggers;	
		 */

		/// <summary>
		/// Gets the triggers.
		/// </summary>
		/// <value>The triggers.</value>
		[Export("triggers")]
		bool Triggers { get; }

	}


	[BaseType (typeof (NSObject))]
	public interface NotificareContent
	{

		/*
		 * @property (strong, nonatomic) NSString * type;
		 */

		/// <summary>
		/// Gets the type.
		/// </summary>
		/// <value>The type.</value>
		[Export("type")]
		NSString Type { get; }

		/*
		 * @property (strong, nonatomic) NSString * data;
		 */

		/// <summary>
		/// Gets the data.
		/// </summary>
		/// <value>The data.</value>
		[Export("data")]
		NSString Data { get; }


		/*
		 * @property (strong, nonatomic) NSDictionary * dataDictionary;
		 */

		/// <summary>
		/// Gets the data dictionary.
		/// </summary>
		/// <value>The data dictionary.</value>
		[Export("dataDictionary")]
		NSDictionary DataDictionary { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface NotificareDevice
	{
		/*


		@property (strong, nonatomic) NSString * username;
		@property (strong, nonatomic) NSNumber * timezone;
		@property (strong, nonatomic) NSString * osVersion;
		@property (strong, nonatomic) NSString * sdkVersion;
		@property (strong, nonatomic) NSString * appVersion;
		@property (strong, nonatomic) NSString * device;
		@property (nonatomic) float latitude;
		@property (nonatomic) float longitude;
		@property (assign, nonatomic) BOOL canReceiveNotifications;
		@property (assign, nonatomic) BOOL allowedLocationServices;
		*/

		/*
		 * @property (strong, nonatomic) NSString * deviceID;
		 */

		/// <summary>
		/// Gets the device ID
		/// </summary>
		/// <value>The device I.</value>
		[Export("deviceID")]
		NSString DeviceID { get; }

		/*
		 * @property (strong, nonatomic) NSString * userID;
		 */

		/// <summary>
		/// Gets the user ID
		/// </summary>
		/// <value>The user ID.</value>
		[Export("userID")]
		NSString UserID { get; }

		/*
		 * @property (strong, nonatomic) NSString * username;
		 */

		/// <summary>
		/// Gets the username.
		/// </summary>
		/// <value>The username.</value>
		[Export("username")]
		NSString Username { get; }

		/*
		 * @property (strong, nonatomic) NSNumber * timezone;
		 */

		/// <summary>
		/// Gets the timezone.
		/// </summary>
		/// <value>The timezone.</value>
		[Export("timezone")]
		NSNumber Timezone { get; }

		/*
		 * @property (strong, nonatomic) NSString * osVersion;
		 */

		/// <summary>
		/// Gets the os version.
		/// </summary>
		/// <value>The os version.</value>
		[Export("osVersion")]
		NSString OsVersion { get; }

		/*
		 * @property (strong, nonatomic) NSString * sdkVersion;
		 */

		/// <summary>
		/// Gets the sdk version.
		/// </summary>
		/// <value>The sdk version.</value>
		[Export("sdkVersion")]
		NSString SdkVersion { get; }

		/*
		 * @property (strong, nonatomic) NSString * appVersion;
		 */

		/// <summary>
		/// Gets the app version.
		/// </summary>
		/// <value>The app version.</value>
		[Export("appVersion")]
		NSString AppVersion { get; }

		/*
		 * @property (strong, nonatomic) NSString * device;
		 */

		/// <summary>
		/// Gets the device string.
		/// </summary>
		/// <value>The device.</value>
		[Export("device")]
		NSString Device { get; }

		/*
		 * @property (nonatomic) float deviceID;
		 */

		/// <summary>
		/// Gets the latitude.
		/// </summary>
		/// <value>The latitude.</value>
		[Export("latitude")]
		float Latitude { get; }

		/*
		 * @property (nonatomic) float deviceID;
		 */

		/// <summary>
		/// Gets the longitude.
		/// </summary>
		/// <value>The longitude.</value>
		[Export("longitude")]
		float Longitude { get; }

		/*
		 * @property (assign, nonatomic) BOOL canReceiveNotifications;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareDevice"/> can receive notifications.
		/// </summary>
		/// <value><c>true</c> if this instance can receive notifications; otherwise, <c>false</c>.</value>
		[Export("canReceiveNotifications")]
		bool CanReceiveNotifications { get; }

		/*
		 * @property (assign, nonatomic) BOOL allowedLocationServices;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareDevice"/> allowed location services.
		/// </summary>
		/// <value><c>true</c> if allowed location services; otherwise, <c>false</c>.</value>
		[Export("allowedLocationServices")]
		bool AllowedLocationServices { get; }


	}

	[BaseType (typeof (NSObject))]
	public interface NotificareNotification
	{
		/*
		 * @property (strong, nonatomic) NSString * notificationID;
		 */

		/// <summary>
		/// Gets the notification ID.
		/// </summary>
		/// <value>The notification ID.</value>
		[Export("notificationID")]
		NSString NotificationID { get; }

		/*
		 * @property (strong, nonatomic) NSDictionary * application;
		 */

		/// <summary>
		/// Gets the application.
		/// </summary>
		/// <value>The application.</value>
		[Export("application")]
		NSDictionary Application { get; }


		/*
		 * @property (strong, nonatomic) NSString * notificationType;
		 */

		/// <summary>
		/// Gets the type of the notification.
		/// </summary>
		/// <value>The type of the notification.</value>
		[Export("notificationType")]
		NSString NotificationType { get; }


		/*
		 * @property (strong, nonatomic) NSString * notificationTime;
		 */

		/// <summary>
		/// Gets the notification time.
		/// </summary>
		/// <value>The notification time.</value>
		[Export("notificationTime")]
		NSString NotificationTime { get; }


		/*
		 * @property (strong, nonatomic) NSString * notificationMessage;
		 */

		/// <summary>
		/// Gets the notification message.
		/// </summary>
		/// <value>The notification message.</value>
		[Export("notificationMessage")]
		NSString NotificationMessage { get; }


		/*
		 * @property (strong, nonatomic) NSString * notificationLatitude;
		 */

		/// <summary>
		/// Gets the notification latitude.
		/// </summary>
		/// <value>The notification latitude.</value>
		[Export("notificationLatitude")]
		NSString NotificationLatitude { get; }


		/*
		 * @property (strong, nonatomic) NSString * notificationLongitude;
		 */

		/// <summary>
		/// Gets the notification latitude.
		/// </summary>
		/// <value>The notification latitude.</value>
		[Export("notificationLongitude")]
		NSString NotificationLongitude { get; }


		/*
		 * @property (strong, nonatomic) NSString * notificationDistance;
		 */

		/// <summary>
		/// Gets the notification distance.
		/// </summary>
		/// <value>The notification distance.</value>
		[Export("notificationDistance")]
		NSString NotificationDistance { get; }


		/*
		 * @property (strong, nonatomic) NSArray * notificationContent;
		 */

		/// <summary>
		/// Gets the content of the notification.
		/// </summary>
		/// <value>The content of the notification.</value>
		[Export("notificationContent")]
		NSArray NotificationContent { get; }


		/*
		 * @property (strong, nonatomic) NSArray * notificationActions;
		 */

		/// <summary>
		/// Gets the notification actions.
		/// </summary>
		/// <value>The notification actions.</value>
		[Export("notificationActions")]
		NSArray NotificationActions { get; }


		/*
		 * @property (strong, nonatomic) NSArray * notificationAttachments;
		 */

		/// <summary>
		/// Gets the notification attachments.
		/// </summary>
		/// <value>The notification attachments.</value>
		[Export("notificationAttachments")]
		NSArray NotificationAttachments { get; }


		/*
		 * @property (strong, nonatomic) NSArray * notificationTags;
		 */

		/// <summary>
		/// Gets the notification tags.
		/// </summary>
		/// <value>The notification tags.</value>
		[Export("notificationTags")]
		NSArray NotificationTags { get; }


		/*
		 * @property (strong, nonatomic) NSArray * notificationSegments;
		 */

		/// <summary>
		/// Gets the notification segments.
		/// </summary>
		/// <value>The notification segments.</value>
		[Export("notificationSegments")]
		NSArray NotificationSegments { get; }


		/*
		 * @property (strong, nonatomic) NSDictionary * notificationExtra;
		 */

		/// <summary>
		/// Gets the notification extra.
		/// </summary>
		/// <value>The notification extra.</value>
		[Export("notificationExtra")]
		NSDictionary NotificationExtra { get; }


		/*
		 * @property (strong, nonatomic) NSDictionary * notificationInfo;
		 */

		/// <summary>
		/// Gets the notification info.
		/// </summary>
		/// <value>The notification info.</value>
		[Export("notificationInfo")]
		NSDictionary NotificationInfo { get; }


		/*
		 * @property (strong, nonatomic) NSNumber * displayMessage;
		 */

		/// <summary>
		/// Gets the display message.
		/// </summary>
		/// <value>The display message.</value>
		[Export("displayMessage")]
		NSNumber DisplayMessage { get; }

	}

	[BaseType (typeof (NSObject))]
	public interface NotificareProduct
	{

		/*
		 * @property (strong, nonatomic) NSString * productName;
		 */

		/// <summary>
		/// Gets the name of the product.
		/// </summary>
		/// <value>The name of the product.</value>
		[Export("productName")]
		NSString ProductName { get; }


		/*
		 * @property (strong, nonatomic) NSString * productDescription;
		 */

		/// <summary>
		/// Gets the product description.
		/// </summary>
		/// <value>The product description.</value>
		[Export("productDescription")]
		NSString ProductDescription { get; }


		/*
		 * @property (strong, nonatomic) NSString * type;
		 */

		/// <summary>
		/// Gets the type.
		/// </summary>
		/// <value>The type.</value>
		[Export("type")]
		NSString Type { get; }


		/*
		 * @property (strong, nonatomic) SKProduct * product;
		 */

		/// <summary>
		/// Gets the product.
		/// </summary>
		/// <value>The product.</value>
		[Export("product")]
		SKProduct Product { get; }


		/*
		 * @property (strong, nonatomic) NSString * application;
		 */

		/// <summary>
		/// Gets the application.
		/// </summary>
		/// <value>The application.</value>
		[Export("application")]
		NSString Application { get; }


		/*
		 * @property (strong, nonatomic) NSString * identifier;
		 */

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		[Export("identifier")]
		NSString Identifier { get; }


		/*
		 * @property (strong, nonatomic) NSArray * stores;
		 */

		/// <summary>
		/// Gets the stores.
		/// </summary>
		/// <value>The stores.</value>
		[Export("stores")]
		NSArray Stores { get; }


		/*
		 * @property (strong, nonatomic) NSArray * downloads;
		 */

		/// <summary>
		/// Gets the downloads.
		/// </summary>
		/// <value>The downloads.</value>
		[Export("downloads")]
		NSArray Downloads { get; }


		/*
		 * @property (strong, nonatomic) NSString * date;
		 */

		/// <summary>
		/// Gets the date.
		/// </summary>
		/// <value>The date.</value>
		[Export("date")]
		NSString Date { get; }


		/*
		 * @property (strong, nonatomic) NSString * priceLocale;
		 */

		/// <summary>
		/// Gets the price locale.
		/// </summary>
		/// <value>The price locale.</value>
		[Export("priceLocale")]
		NSString PriceLocale { get; }


		/*
		 * @property (strong, nonatomic) NSString * price;
		 */

		/// <summary>
		/// Gets the price.
		/// </summary>
		/// <value>The price.</value>
		[Export("price")]
		NSString Price { get; }


		/*
		 * @property (strong, nonatomic) NSString * currency;
		 */

		/// <summary>
		/// Gets the currency.
		/// </summary>
		/// <value>The currency.</value>
		[Export("currency")]
		NSString Currency { get; }


		/*
		 * @property (assign, nonatomic) BOOL active;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareProduct"/> is active.
		/// </summary>
		/// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
		[Export("active")]
		bool Active { get; }


		/*
		 * @property (assign, nonatomic) BOOL purchased;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareProduct"/> is purchased.
		/// </summary>
		/// <value><c>true</c> if purchased; otherwise, <c>false</c>.</value>
		[Export("purchased")]
		bool Purchased { get; }

	}

	[BaseType (typeof (NSObject))]
	public interface NotificareSegment
	{

		/*
		 * @property (strong, nonatomic) NSString * segmentLabel;
		 */

		/// <summary>
		/// Gets the segment label.
		/// </summary>
		/// <value>The segment label.</value>
		[Export("segmentLabel")]
		NSString SegmentLabel { get; }


		/*
		 * @property (strong, nonatomic) NSString * segmentId;
		 */

		/// <summary>
		/// Gets the segment identifier.
		/// </summary>
		/// <value>The segment identifier.</value>
		[Export("segmentId")]
		NSString SegmentId { get; }


		/*
		 * @property (assign, nonatomic) BOOL selected;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareSegment"/> is selected.
		/// </summary>
		/// <value><c>true</c> if selected; otherwise, <c>false</c>.</value>
		[Export("selected")]
		bool Selected { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface NotificareUser
	{

		/*
		 * @property (strong, nonatomic) NSString * accessToken;
		 */

		/// <summary>
		/// Gets the access token.
		/// </summary>
		/// <value>The access token.</value>
		[Export("accessToken")]
		NSString AccessToken { get; }

		/*
		 * @property (strong, nonatomic) NSString * account;
		 */

		/// <summary>
		/// Gets the account.
		/// </summary>
		/// <value>The account.</value>
		[Export("account")]
		NSString Account { get; }


		/*
		 * @property (nonatomic, assign) BOOL active;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareUser"/> is active.
		/// </summary>
		/// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
		[Export("active")]
		bool Active { get; }


		/*
		 * @property (strong, nonatomic) NSString * application;
		 */

		/// <summary>
		/// Gets the application.
		/// </summary>
		/// <value>The application.</value>
		[Export("application")]
		NSString Application { get; }


		/*
		 * @property (nonatomic, assign) BOOL autoGenerated;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareUser"/> auto generated.
		/// </summary>
		/// <value><c>true</c> if auto generated; otherwise, <c>false</c>.</value>
		[Export("autoGenerated")]
		bool AutoGenerated { get; }


		/*
		 * @property (strong, nonatomic) NSMutableArray * segments;
		 */

		/// <summary>
		/// Gets the segments.
		/// </summary>
		/// <value>The segments.</value>
		[Export("segments")]
		NSMutableArray Segments { get; }


		/*
		 * @property (strong, nonatomic) NSString * userID;
		 */

		/// <summary>
		/// Gets the user ID.
		/// </summary>
		/// <value>The user ID.</value>
		[Export("userID")]
		NSString UserID { get; }


		/*
		 * @property (strong, nonatomic) NSString * userName;
		 */

		/// <summary>
		/// Gets the name of the user.
		/// </summary>
		/// <value>The name of the user.</value>
		[Export("userName")]
		NSString UserName { get; }


		/*
		 * @property (nonatomic, assign) BOOL validated;
		 */

		/// <summary>
		/// Gets a value indicating whether this <see cref="Notificare.iOS.NotificareUser"/> is validated.
		/// </summary>
		/// <value><c>true</c> if validated; otherwise, <c>false</c>.</value>
		[Export("validated")]
		bool validated { get; }
	}

	[BaseType (typeof (NSObject))]
	public interface NotificareUserPreference
	{

		/*
		 * @property (strong, nonatomic) NSString * preferenceLabel;
		 */

		/// <summary>
		/// Gets the preference label.
		/// </summary>
		/// <value>The preference label.</value>
		[Export("preferenceLabel")]
		NSString PreferenceLabel { get; }


		/*
		 * @property (strong, nonatomic) NSString * preferenceId;
		 */

		/// <summary>
		/// Gets the preference identifier.
		/// </summary>
		/// <value>The preference identifier.</value>
		[Export("preferenceId")]
		NSString PreferenceId { get; }


		/*
		 * @property (strong, nonatomic) NSString * preferenceType;
		 */

		/// <summary>
		/// Gets the type of the preference.
		/// </summary>
		/// <value>The type of the preference.</value>
		[Export("preferenceType")]
		NSString PreferenceType { get; }


		/*
		 * @property (strong, nonatomic) NSArray * preferenceOptions;
		 */

		/// <summary>
		/// Gets the preference options.
		/// </summary>
		/// <value>The preference options.</value>
		[Export("preferenceOptions")]
		NSArray PreferenceOptions { get; }

	}

	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	interface NotificarePushLibDelegate {

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library onReady:(NSDictionary *)info;
		 */

		/// <summary>
		/// Raises the ready event.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="info">Info.</param>
		[Export ("notificarePushLib:onReady:")]
		void OnReady (NotificarePushLib library, NSDictionary info);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didRegisterForWebsocketsNotifications:(NSString *)token;
		 */

		/// <summary>
		/// Did register for websockets notifications.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="token">Token.</param>
		[Export ("notificarePushLib:didRegisterForWebsocketsNotifications:")]
		void DidRegisterForWebsocketsNotifications (NotificarePushLib library, NSString token);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didReceiveWebsocketNotification:(NSDictionary *)info;
		 */

		/// <summary>
		/// Did receive websocket notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="info">Info.</param>
		[Export ("notificarePushLib:didReceiveWebsocketNotification:")]
		void DidReceiveWebsocketNotification (NotificarePushLib library, NSDictionary info);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailToRegisterWebsocketNotifications:(NSError *)error;
		 */

		/// <summary>
		/// Did fail to register websocket notifications.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="error">Error.</param>
		[Export ("notificarePushLib:didFailToRegisterWebsocketNotifications:")]
		void DidFailToRegisterWebsocketNotifications (NotificarePushLib library, NSError error);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didCloseWebsocketConnection:(NSString *)reason;
		 */

		/// <summary>
		/// Did close websocket connection.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="reason">Reason.</param>
		[Export ("notificarePushLib:didCloseWebsocketConnection:")]
		void DidCloseWebsocketConnection (NotificarePushLib library, NSString reason);


		/*
		 * - (BOOL)notificarePushLib:(NotificarePushLib *)library shouldHandleNotification:(NSDictionary *)info;
		 */

		/// <summary>
		/// Should we handle the notification?
		/// </summary>
		/// <returns><c>true</c>, if we should handle notification, <c>false</c> otherwise.</returns>
		/// <param name="library">The NotifcarePushLib instance.</param>
		/// <param name="info">The notification.</param>
		[Export ("notificarePushLib:shouldHandleNotification:"), DefaultValue ("true")]
		bool ShouldHandleNotification (NotificarePushLib library, NSDictionary info);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didUpdateBadge:(int)badge;
		 */

		/// <summary>
		/// Did update the badge.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="badge">Badge.</param>
		[Export ("notificarePushLib:didUpdatebadge:")]
		void DidUpdateBadge (NotificarePushLib library, int badge);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library willOpenNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Will open notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:willOpenNotification:")]
		void WillOpenNotification (NotificarePushLib library, NotificareNotification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didOpenNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Did open notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:didOpenNotification:")]
		void DidOpenNotification (NotificarePushLib library, NotificareNotification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didCloseNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Did close notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:didCloseNotification:")]
		void DidCloseNotification (NotificarePushLib library, NotificareNotification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailToOpenNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Did fail to open notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:didFailToOpenNotification:")]
		void DidFailToOpenNotification (NotificarePushLib library, NotificareNotification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library willExecuteAction:(Notification *)notification;
		 */

		/// <summary>
		/// Will execute an action on a notification
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:willExecuteAction:")]
		void WillExecuteAction (NotificarePushLib library, NotificareNotification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didExecuteAction:(NSDictionary *)info;
		 */

		/// <summary>
		/// Did execute action.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="info">Info.</param>
		[Export ("notificarePushLib:didExecuteAction:")]
		void DidExecuteAction (NotificarePushLib library, NSDictionary info);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library shouldPerformSelector:(NSString *)selector;
		 */

		/// <summary>
		/// Should perform a selector
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="selector">Selector.</param>
		[Export ("notificarePushLib:shouldPerformSelector:")]
		void ShouldPerformSelector (NotificarePushLib library, NSString selector);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didNotExecuteAction:(NSDictionary *)info;
		 */

		/// <summary>
		/// Did not execute action.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="info">Info.</param>
		[Export ("notificarePushLib:didNotExecuteAction:")]
		void DidNotExecuteAction (NotificarePushLib library, NSDictionary info);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailToExecuteAction:(NSError *)error;
		 */

		/// <summary>
		/// Did fail to execute action.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="info">Info.</param>
		[Export ("notificarePushLib:didFailToExecuteAction:")]
		void DidFailToExecuteAction (NotificarePushLib library, NSDictionary info);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didReceiveLocationServiceAuthorizationStatus:(NSDictionary *)status;
		 */

		/// <summary>
		/// Did  receive location service authorization status.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="status">Status.</param>
		[Export ("notificarePushLib:didReceiveLocationServiceAuthorizationStatus:")]
		void DidReceiveLocationServiceAuthorizationStatus (NotificarePushLib library, NSDictionary status);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailToStartLocationServiceWithError:(NSError *)error;
		 */

		/// <summary>
		/// Did fail to start location service.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="error">Error.</param>
		[Export ("notificarePushLib:didFailToStartLocationServiceWithError:")]
		void DidFailToStartLocationServiceWithError (NotificarePushLib library, NSError error);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didUpdateLocations:(NSArray *)locations;
		 */

		/// <summary>
		/// Updated locations.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="locations">Locations.</param>
		[Export ("notificarePushLib:didUpdateLocations:")]
		void DidUpdateLocations (NotificarePushLib library, NSArray locations);


		/* 
		 * - (void)notificarePushLib:(NotificarePushLib *)library monitoringDidFailForRegion:(CLRegion *)region withError:(NSError *)error;
		 */

		/// <summary>
		/// Monitoring did fail for region.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="region">Region.</param>
		/// <param name="error">Error.</param>
		[Export ("notificarePushLib:monitoringDidFailForRegion:withError:")]
		void MonitoringDidFailForRegionWithError (NotificarePushLib library, CLRegion region, NSError error);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didStartMonitoringForRegion:(CLRegion *)region;
		 */

		/// <summary>
		/// Did start monitoring for region.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="region">Region.</param>
		[Export ("notificarePushLib:didStartMonitoringForRegion:")]
		void DidStartMonitoringForRegion (NotificarePushLib library, CLRegion region);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didDetermineState:(CLRegionState)state forRegion:(CLRegion *)region;
		 */

		/// <summary>
		/// Did determine state for region.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="state">State.</param>
		/// <param name="region">Region.</param>
		[Export ("notificarePushLib:didDetermineState:forRegion:")]
		void DidDetermineStateForRegion (NotificarePushLib library, CLRegionState state, CLRegion region);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didEnterRegion:(CLRegion *)region;
		 */

		/// <summary>
		/// Did enter region.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="region">Region.</param>
		[Export ("notificarePushLib:didEnterRegion:")]
		void DidEnterRegion (NotificarePushLib library, CLRegion region);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didExitRegion:(CLRegion *)region;
		 */

		/// <summary>
		/// Did exit region.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="region">Region.</param>
		[Export ("notificarePushLib:didExitRegion:")]
		void DidExitRegion (NotificarePushLib library, CLRegion region);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library rangingBeaconsDidFailForRegion:(CLBeaconRegion *)region withError:(NSError *)error;
		 */

		/// <summary>
		/// Ranging the beacons did fail for region with error.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="region">Region.</param>
		/// <param name="error">Error.</param>
		[Export ("notificarePushLib:rangingBeaconsDidFailForRegion:withError:")]
		void RangingBeaconsDidFailForRegionWithError (NotificarePushLib library, CLRegion region, NSError error);

		/* 
		 * - (void)notificarePushLib:(NotificarePushLib *)library didRangeBeacons:(NSArray *)beacons inRegion:(CLBeaconRegion *)region;
		 */

		/// <summary>
		/// Did range beacons in region.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="beacons">Beacons.</param>
		/// <param name="region">Region.</param>
		[Export ("notificarePushLib:didRangeBeacons:inRegion:")]
		void DidRangeBeaconsInRegion (NotificarePushLib library, NSArray beacons, CLRegion region);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didChangeAccountNotification:(NSDictionary *)info;
		 */

		/// <summary>
		/// Did change account notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="info">Info.</param>
		[Export ("notificarePushLib:didChangeAccountNotification:")]
		void DidChangeAccountNotification (NotificarePushLib library, NSDictionary info);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailToRequestAccessNotification:(NSError *)error;
		 */

		/// <summary>
		/// Did fail to request access notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="error">Error.</param>
		[Export ("notificarePushLib:didFailToRequestAccessNotification:")]
		void DidFailToRequestAccessNotification (NotificarePushLib library, NSError error);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didReceiveActivationToken:(NSString *)token;
		 */

		/// <summary>
		/// Did receive the activation token.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="token">Token.</param>
		[Export ("notificarePushLib:didReceiveActivationToken:")]
		void DidReceiveActivationToken (NotificarePushLib library, NSString token);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didReceiveResetPasswordToken:(NSString *)token;
		 */

		/// <summary>
		/// Did receive the reset password token.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="token">Token.</param>
		[Export ("notificarePushLib:didReceiveResetPasswordToken:")]
		void DidReceiveResetPasswordToken (NotificarePushLib library, NSString token);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didLoadStore:(NSArray *)products;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered soon the product's store is loaded. Use it to update UI.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="products">Products.</param>
		[Export ("notificarePushLib:didLoadStore:")]
		void DidLoadStore (NotificarePushLib library, NSArray products);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailToLoadStore:(NSError *)error;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered every time the store fails to load. We will automatically retry to load the store.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="error">Error.</param>
		[Export ("notificarePushLib:didFailToLoadStore:")]
		void DidFailToLoadStore (NotificarePushLib library, NSError error);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didCompleteProductTransaction:(SKPaymentTransaction *)transaction;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered when a transaction is completed.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="transaction">Transaction.</param>
		[Export ("notificarePushLib:didCompleteProductTransaction:")]
		void DidCompleteProductTransaction (NotificarePushLib library, SKPaymentTransaction transaction);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didRestoreProductTransaction:(SKPaymentTransaction *)transaction;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered when a transaction is restored.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="transaction">Transaction.</param>
		[Export ("notificarePushLib:didRestoreProductTransaction:")]
		void DidRestoreProductTransaction (NotificarePushLib library, SKPaymentTransaction transaction);


		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailProductTransaction:(SKPaymentTransaction *)transaction withError:(NSError *)error;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered when a transaction fails.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="transaction">Transaction.</param>
		/// <param name="error">Error.</param>
		[Export ("notificarePushLib:didFailProductTransaction:withError:")]
		void DidFailProductTransaction (NotificarePushLib library, SKPaymentTransaction transaction, NSError error);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didStartDownloadContent:(SKPaymentTransaction *)transaction;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered when a transaction's content starts downloading.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="transaction">Transaction.</param>
		[Export ("notificarePushLib:didStartDownloadContent:")]
		void DidStartDownloadContent (NotificarePushLib library, SKPaymentTransaction transaction);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didPauseDownloadContent:(SKDownload *)download;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered when a download is paused.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="download">Download.</param>
		[Export ("notificarePushLib:didPauseDownloadContent:")]
		void DidPauseDownloadContent (NotificarePushLib library, SKDownload download);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didCancelDownloadContent:(SKDownload *)download;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered when a download is cancelled.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="download">Download.</param>
		[Export ("notificarePushLib:didCancelDownloadContent:")]
		void DidCancelDownloadContent (NotificarePushLib library, SKDownload download);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didReceiveProgressDownloadContent:(SKDownload *)download;
		 */
	
		/// <summary>
		/// Optional. This delegate method will be triggered whenever a download progress is updated.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="download">Download.</param>
		[Export ("notificarePushLib:didReceiveProgressDownloadContent:")]
		void DidReceiveProgressDownloadContent (NotificarePushLib library, SKDownload download);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailDownloadContent:(SKDownload *)download;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered whenever a download fails.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="download">Download.</param>
		[Export ("notificarePushLib:didFailDownloadContent:")]
		void DidFailDownloadContent (NotificarePushLib library, SKDownload download);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFinishDownloadContent:(SKDownload *)download;
		 */

		/// <summary>
		/// Optional. This delegate method will be triggered whenever a download progress is finished.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="download">Download.</param>
		[Export ("notificarePushLib:didFinishDownloadContent:")]
		void DidFinishDownloadContent (NotificarePushLib library, SKDownload download);
	}


	public delegate void SuccessProductCallback( NotificareProduct product );
	public delegate void SuccessArrayCallback( NSArray info );
	public delegate void SuccessCallback( NSDictionary info );
	public delegate void ErrorCallback( NSError error );

	// @interface NotificarePushLib : NSObject <NotificareSRWebSocketDelegate,NotificareDelegate,NotificareActionsDelegate,CLLocationManagerDelegate>
	[BaseType (typeof (NSObject))]
	interface NotificarePushLib 
	{
		/*
		 * +(NotificarePushLib*)shared;
		 */

		/// <summary>
		/// The shared singleton implementation.
		/// </summary>
		[Static][Export("shared")]
		NotificarePushLib Shared();

		/*
		 * - (void)launch;
		 */

		/// <summary>
		/// Initializes, checks and retrieves memory data
		/// </summary>
		[Export("launch")]
		void Launch();

		/*
		 * - (void)registerForRemoteNotificationsTypes:(UIRemoteNotificationType)types;
		 */

		/// <summary>
		/// Registers for APNS
		/// </summary>
		/// <param name="types">Types.</param>
		[Export("registerForRemoteNotificationsTypes:")]
		[Obsolete("RegisterForRemoteNotifications is deprecated, please use RegisterForNotifications instead.", true)]
		void RegisterForRemoteNotifications (UIRemoteNotificationType types);


		/*
		 * - (void)registerForNotifications;
		 */

		/// <summary>
		/// Registers for APNS
		/// </summary>
		/// <param name="types">Types.</param>
		[Export("registerForNotifications")]
		void RegisterForNotifications ();

		/* 
		 * -(BOOL)checkRemoteNotifications;
		 */

		/// <summary>
		/// Use this method to quickly identify if the device has been registered with APNS
		/// </summary>
		/// <returns><c>true</c>, if device is registered with APNS, <c>false</c> otherwise.</returns>
		[Export("checkRemoteNotifications")]
		bool CheckRemoteNotifications ();

		/*
		 * - (void)handleOptions:(NSDictionary *)options;
		 */

		/// <summary>
		/// Handles notifications opened from the background
		/// </summary>
		/// <param name="options">Options.</param>
		[Export("handleOptions:")]
		void HandleOptions( NSDictionary options );

		/*
		 * - (void)registerDevice:(NSData *)token;
		 */

		/// <summary>
		/// Registers the APNS token from Apple anonymously
		/// Consider using the method with the completion and error blocks if you want to make sure that you create tags or start location updates
		/// only after successfully register a device token.
		/// </summary>
		/// <param name="token">Token.</param>
		[Export("registerDevice:")]
		[Obsolete ("RegisterDevice is deprecated, use RegisterDevice with callbacks")] 
		void RegisterDevice( NSData token );

		/*
		 * - (void)registerDevice:(NSData *)token completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Registers the APNS token from Apple anonymously
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("registerDevice:completionHandler:errorHandler:")]
		void RegisterDevice( NSData token, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler );


		/*
		 * - (void)registerDevice:(NSData *)token withUserID:(NSString *)userID;
		 */

		/// <summary>
		/// Registers the APNS token from Apple by creating a user profile with any string
		/// This allows the registrations of more than one device in one user profile
		/// You can also map this ID to your existing user ID if you eventually using any means of authentication
		/// Consider using the method with the completion and error blocks if you want to make sure that you create tags or start location updates
		/// only after successfully register a device token.
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User identifier.</param>
		[Export("registerDevice:withUserID:")]
		[Obsolete ("RegisterDeviceWithUserID is deprecated, use RegisterDeviceWithUserID with callbacks")] 
		void RegisterDeviceWithUserID( NSData token, NSString userID );

		/*
		 * - (void)registerDevice:(NSData *)token withUserID:(NSString *)userID completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Registers the APNS token from Apple by creating a user profile with any string
		/// This allows the registrations of more than one device in one user profile
		/// You can also map this ID to your existing user ID if you eventually using any means of authentication
		/// Consider using the method with the completion and error blocks if you want to make sure that you create tags or start location updates
		/// only after successfully register a device token.
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User ID.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("registerDevice:withUserID:completionHandler:errorHandler:")]
		void RegisterDeviceWithUserID( NSData token, NSString userID, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler );

		/*
		 * - (void)registerDevice:(NSData *)token withUserID:(NSString *)userID withUsername:(NSString *)username;
		 */

		/// <summary>
		/// Registers the APNS token from Apple by creating a user profile with any string
		/// This allows the registrations of more than one device in one user profile
		/// You can also map this ID to your existing user ID if you eventually using any means of authentication
		/// Consider using the method with the completion and error blocks if you want to make sure that you create tags or start location updates
		/// only after successfully register a device token.
		/// Adds another string that can be used to display name
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User ID.</param>
		/// <param name="username">Username.</param>
		[Export("registerDevice:withUserID:withUsername:")]
		[Obsolete ("RegisterDeviceWithUserIDWithUsername is deprecated, use RegisterDeviceWithUserIDWithUsername with callbacks")] 
		void RegisterDeviceWithUserIDWithUsername( NSData token, NSString userID, NSString username );

		/*
		 * - (void)registerDevice:(NSData *)token withUserID:(NSString *)userID withUsername:(NSString *)username completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Registers the APNS token from Apple by creating a user profile with any string
		/// This allows the registrations of more than one device in one user profile
		/// You can also map this ID to your existing user ID if you eventually using any means of authentication
		/// Adds another string that can be used to display name
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User ID.</param>
		/// <param name="username">Username.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("registerDevice:withUserID:withUsername:completionHandler:errorHandler:")]
		void RegisterDeviceWithUserIDWithUsername( NSData token, NSString userID, NSString username, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler );

		/*
		 * - (void)registerForWebsockets;
		 */

		/// <summary>
		/// Registers for websockets.
		/// </summary>
		[Export("registerForWebsockets")]
		void RegisterForWebsockets();

		/*
		 * - (void)unregisterForWebsockets;
		 */

		/// <summary>
		/// Unregisters for websockets.
		/// </summary>
		[Export("unregisterForWebsockets")]
		void UnregisterForWebsockets();

		/*
		 * - (void)registerDeviceForWebsockets:(NSString *)token completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Registers the Websockets token from Notificare anonymously
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("registerDeviceForWebsockets:completionHandler:errorHandler:")]
		void RegisterDeviceForWebsockets( NSString token, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler );

		/*
		 * - (void)registerDeviceForWebsockets:(NSString *)token withUserID:(NSString *)userID completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Registers the Websockets token from Notificare by creating a user profile with any string
		/// This allows the registrations of more than one device in one user profile
		/// You can also map this ID to your existing user ID if you eventually using any means of authentication
		/// Consider using the method with the completion and error blocks if you want to make sure that you create tags or start location updates
		/// only after successfully register a device token.
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User ID.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("registerDeviceForWebsockets:withUserID:completionHandler:errorHandler:")]
		void RegisterDeviceForWebsocketsWithUserID( NSString token, NSString userID, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler );

		/*
		 * - (void)registerDeviceForWebsockets:(NSString *)token withUserID:(NSString *)userID withUsername:(NSString *)username completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Registers the Websockets token from Notificare by creating a user profile with any string
		/// This allows the registrations of more than one device in one user profile
		/// You can also map this ID to your existing user ID if you eventually using any means of authentication
		/// Adds another string that can be used to display name
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User ID.</param>
		/// <param name="username">Username.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("registerDeviceForWebsockets:withUserID:withUsername:completionHandler:errorHandler:")]
		void RegisterDeviceForWebsocketsWithUserIDWithUsername( NSString token, NSString userID, NSString username, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler );


		/*
		 * - (void)unregisterDevice;
		 */

		/// <summary>
		/// This method allows you to prevent Notificare from sending notifications
		/// If you also wish to remove the device from APNS also call [[UIApplication sharedApplication] unregisterForRemoteNotifications]
		/// </summary>
		[Export("unregisterDevice")]
		void UnregisterDevice();

		/*
		 * - (void)updateBadge:(NSNumber *)badge;
		 */

		/// <summary>
		/// Update app badge, accepts a NSNumber
		/// </summary>
		/// <param name="badge">Badge.</param>
		[Export("updateBadge:")]
		void UpdateBadge (NSNumber badge);

		/*
		 * - (void)openNotification:(NSDictionary *)notification;
		 */

		/// <summary>
		/// Displays text or rich content notifications. Usually used in the delegate didReceiveRemoteNotification
		/// </summary>
		/// <param name="notification">Notification.</param>
		[Export("openNotification:")]
		void OpenNotification( NSDictionary notification );

		/*
		 * - (void)logOpenNotification:(NSDictionary *)notification;
		 */

		/// <summary>
		/// Logs the open notification manually. This should be used when you don't use the openNotification.
		/// </summary>
		/// <param name="notification">A NSDictionary object usually the result of getNotification: or Apple's userInfo dictionary provided in didReceiveRemoteNotification:.</param>
		[Export("logOpenNotification:")]
		void LogOpenNotification( NSDictionary notification );

		/*
		 * - (void)getNotification:(NSString *)notificationID completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Fetches a notification's full payload. Usually used if you gonna handle the notifications yourself.
		/// </summary>
		/// <param name="notificationID">Notification ID.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("getNotification:completionHandler:errorHandler:")]
		void GetNotification( NSString notificationID, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler );

		/*
		 * - (void)clearNotification:(NSString *)notification;
		 */

		/// <summary>
		/// Deletes a notification. Should be used if you want to remove a notification from our system
		/// </summary>
		/// <param name="notificationID">Notification I.</param>
		[Export("clearNotification:")]
		void ClearNotification( NSString notificationID );

		/*
		 * -(void)startLocationUpdates;
		 */

		/// <summary>
		/// Starts the location manager for geo-targeting, geo-fencing and beacons
		/// </summary>
		[Export ("startLocationUpdates")]
		void StartLocationUpdates();

		/*
		 * -(BOOL)checkLocationUpdates;
		 */

		[Export ("checkLocationUpdates")]
		bool CheckLocationUpdates ();

		/*
		 * - (void)updateLocation:(NSString*)device withLatitude:(float)latitude andLongitude:(float)longitude;
		 */

		/// <summary>
		/// Update the device's location manually
		/// </summary>
		/// <param name="device">Device.</param>
		/// <param name="latitude">Latitude.</param>
		/// <param name="longitude">Longitude.</param>
		[Export ("updateLocation:withLatitude:andLongitude:")]
		void UpdateLocation( NSString device, float latitude, float longitude );

		/*
		 * -(void)stopLocationUpdates;
		 */

		/// <summary>
		/// Stops the location manager from collecting location updates
		/// </summary>
		[Export ("stopLocationUpdates")]
		void StopLocationUpdates();

		/*
		 * - (void)getTags:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */
		/// <summary>
		/// Get the device tags. Tags are used to easily categorize devices according to any kpi, point or area of
		/// </summary>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export ("getTags:errorHandler:")]
		void GetTags ([BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)addTags:(NSArray *)tags;
		 */

		/// <summary>
		/// Add tags. Tags are used to easily categorize devices according to any kpi, point or area of
		/// </summary>
		/// <param name="tags">Tags.</param>
		[Export("addTags:")]
		void AddTags( NSArray tags );

		/*
		 * - (void)addTags:(NSArray *)tags completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */
		/// <summary>
		/// Add tags. Tags are used to easily categorize devices according to any kpi, point or area of
		/// </summary>
		/// <param name="tags">Tags.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("addTags:completionHandler:errorHandler:")]
		void AddTags( NSArray tags, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/* 
		 * - (void)removeTag:(NSString *)tag;
		 */

		/// <summary>
		/// Removes the tag.
		/// </summary>
		/// <param name="tag">Tag.</param>
		[Export("removeTag:")]
		void RemoveTag (NSString tag);

		/* 
		 * - (void)removeTag:(NSString *)tag completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Removes the tag.
		/// </summary>
		/// <param name="tag">Tag.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("removeTag:completionHandler:errorHandler:")]
		void RemoveTag(NSString tag, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)clearTags:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Clears the tags.
		/// </summary>
		/// <param name="tags">Tags.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("clearTags:errorHandler:")]
		void ClearTags( [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)startMonitoringBeaconRegion:(NSUUID *)uuid;
		 */

		/// <summary>
		/// Manually start Beacons without a geofence
		/// </summary>
		/// <param name="uuid">UUID.</param>
		[Export("startMonitoringBeaconRegion:")]
		void StartMonitoringBeaconRegion (NSUuid uuid);

		/*
		 * - (void)startMonitoringBeaconRegion:(NSUUID *)uuid andMajor:(NSNumber *)major;
		 */

		/// <summary>
		/// Manually start Beacons without a geofence
		/// </summary>
		/// <param name="uuid">UUID.</param>
		/// <param name="major">Major.</param>
		[Export("startMonitoringBeaconRegion:andMajor:")]
		void StartMonitoringBeaconRegion (NSUuid uuid, NSNumber major);

		/*
		 * - (void)startMonitoringBeaconRegion:(NSUUID *)uuid andMajor:(NSNumber *)major andMinor:(NSNumber *)minor;
		 */

		/// <summary>
		/// Manually start Beacons without a geofence
		/// </summary>
		/// <param name="uuid">UUID.</param>
		/// <param name="major">Major.</param>
		/// <param name="minor">Minor.</param>
		[Export("startMonitoringBeaconRegion:andMajor:andMinor:")]
		void StartMonitoringBeaconRegion (NSUuid uuid, NSNumber major, NSNumber minor);


		/*
		 * - (void)openBeacon:(NSDictionary *)beacon;
		 */

		/// <summary>
		/// Displays text or rich content attached to that beacon. Usually used in the delegate didRangeBeacons
		/// </summary>
		/// <param name="beacon">Beacon.</param>
		[Export("openBeacon:")]
		[Obsolete ("use OpenNotificareBeacon instead.")]
		void OpenBeacon (NSDictionary beacon);

		/*
		 * - (void)openNotificareBeacon:(NotificareBeacon *)beacon;
		 */

		/// <summary>
		/// Displays the beacon's content. A NotificareBeacon object can be retrieved from the NSArray containing a list of beacons in the delegate didRangeBeacons:inRegion:.
		/// </summary>
		/// <param name="beacon">Beacon.</param>
		[Export("openNotificareBeacon:")]
		void OpenNotificareBeacon (NotificareBeacon beacon);



		/*
		 * - (void)openBeacons;
		 */

		/// <summary>
		/// Displays text or rich content attached to ranged beacons. Usually used in the delegate didRangeBeacons
		/// </summary>
		[Export("openBeacons")]
		void OpenBeacons ();

		/*
		 * - (void)openUserPreferences;
		 */

		/// <summary>
		/// Displays a view with for user control of notifications, location updates and key-value pairs inserted in NotificareTags.plist
		/// </summary>
		[Export("openUserPreferences")]
		void OpenUserPreferences();


		/*
		 * - (void)reply:(NSString *)notification withLabel:(NSString *)label andData:(NSDictionary *)data;
		 */

		/// <summary>
		/// Register an action event manually. Usually needed when you handling notifications yourself and want to use the actions to register a certain user choice.
		/// </summary>
		/// <param name="notification">Notification.</param>
		/// <param name="label">Label.</param>
		/// <param name="data">Data.</param>
		[Export("reply:withLabel:andData:")]
		void ReplyWithLabelAndData (NSString notification, NSString label, [NullAllowed] NSDictionary data);

		/*
		 * - (void)handleAction:(NSString *)action forNotification:(NSDictionary *)notification withData:(NSDictionary *)data completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Handles the action for notification with data for iOS8.
		/// </summary>
		/// <param name="action">Action.</param>
		/// <param name="notification">Notification.</param>
		/// <param name="data">Data.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export ("handleAction:forNotification:withData:completionHandler:errorHandler:")]
		void HandleActionForNotificationWithData (NSString action, NSDictionary notification, [NullAllowed] NSDictionary data, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);


		/*
		 * - (void)logCustomEvent:(NSString *)name withData:(NSDictionary *)data completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Logs the custom event with data.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="data">Data.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export ("logCustomEvent:withData:completionHandler:errorHandler:")]
		void LogCustomEventWithData (NSString name, [NullAllowed] NSDictionary data, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);


		/*
		 * - (void)saveToInbox:(NSDictionary *)notification forApplication:(UIApplication *)application completionHandler:(SuccessBlock)result errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Saves to inbox for application.
		/// </summary>
		/// <param name="notification">Notification.</param>
		/// <param name="application">Application.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export ("saveToInbox:forApplication:completionHandler:errorHandler:")]
		void SaveToInboxForApplication (NSDictionary notification, UIApplication application, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);


		/*
		 * - (void)removeFromInbox:(NSDictionary *)notification;
		 */

		/// <summary>
		/// Removes from inbox.
		/// </summary>
		/// <param name="notification">Notification.</param>
		[Export ("removeFromInbox:")]
		void RemoveFromInbox (NSDictionary notification);


		/*
		 * -(void)openInbox;
		 */

		/// <summary>
		/// Opens the inbox.
		/// </summary>
		[Export ("openInbox")]
		void OpenInbox ();


		/*
		 * - (NSArray *)myInbox
		 */

		/// <summary>
		/// The inbox.
		/// </summary>
		/// <returns>The inbox.</returns>
		[Export ("myInbox")]
		NSArray MyInbox ();


		/*
		 * -(int)myBadge;
		 */

		/// <summary>
		/// The badge.
		/// </summary>
		/// <returns>The badge.</returns>
		[Export ("myBadge")]
		int MyBadge ();


		/*
		 * - (void)createAccount:(NSDictionary *)params completionHandler:(SuccessBlock)result errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Creates the account.
		/// </summary>
		/// <param name="parameters">Parameters.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("createAccount:completionHandler:errorHandler:")]
		[Obsolete ("use CreateAccountWithNameAndPassword instead.")]
		void CreateAccount(NSDictionary parameters, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)createAccount:(NSString *)email withName:(NSString *)name andPassword:(NSString *)password completionHandler:(SuccessBlock)result errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Creates the account with name and password.
		/// </summary>
		/// <param name="email">Email.</param>
		/// <param name="name">Name.</param>
		/// <param name="password">Password.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("createAccount:withName:andPassword:completionHandler:errorHandler:")]
		void CreateAccountWithNameAndPassword(NSString email, NSString name, NSString password, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);


		/*
		 * - (void)resetPassword:(NSDictionary *)params withToken:(NSString *)token completionHandler:(SuccessBlock)result errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Resets the password.
		/// </summary>
		/// <param name="password">Password.</param>
		/// <param name="token">Token.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("resetPassword:withToken:completionHandler:errorHandler:")]
		void ResetPassword(NSString password, NSString token, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)validateAccount:(NSString *)token completionHandler:(SuccessBlock)result errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Validates the account.
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("validateAccount:completionHandler:errorHandler:")]
		void ValidateAccount(NSString token, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)sendPassword:(NSDictionary *)params completionHandler:(SuccessBlock)result errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Sends the password.
		/// </summary>
		/// <param name="email">Email.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("sendPassword:completionHandler:errorHandler:")]
		void SendPassword(NSString email, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)loginWithUsername:(NSString *)username andPassword:(NSString *)password completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Logins the with username and password.
		/// </summary>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("loginWithUsername:andPassword:completionHandler:errorHandler:")]
		void LoginWithUsernameAndPassword(NSString username, NSString password, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)logoutAccount;
		 */

		/// <summary>
		/// Use this method should be log out any authenticated user. This method should also be used to allow the user to forget a device.
		/// </summary>
		[Export("logoutAccount")]
		void LogoutAccount();

		/*
		 * - (BOOL)isLoggedIn;
		 */

		/// <summary>
		/// Use this helper method to check if the user is logged in or not. This is meant to help the app's UI display any user related method without having to request the full User Object.
		/// </summary>
		/// <returns><c>true</c> if this instance is logged in; otherwise, <c>false</c>.</returns>
		[Export("isLoggedIn")]
		bool IsLoggedIn();

		/*
		 * - (void)fetchAccountDetails:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Fetchs the account details.
		/// </summary>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("fetchAccountDetails:errorHandler:")]
		void FetchAccountDetails([BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)generateAccessToken:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Generates the access token.
		/// </summary>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("generateAccessToken:errorHandler:")]
		void GenerateAccessToken([BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)changePassword:(NSDictionary *)params completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Changes the password.
		/// </summary>
		/// <param name="password">Password.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("changePassword:completionHandler:errorHandler:")]
		void ChangePassword(NSString password, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)fetchUserPreferences:(SuccessArrayBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// List of all NotificareUserPreference objects. These objects will contain information about user selectable segments. Should be used to show the user's selectable segments defined for this application.
		/// </summary>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("fetchUserPreferences:errorHandler:")]
		void FetchUserPreferences([BlockCallback] SuccessArrayCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)addSegment:(NotificareSegment *)segment toPreference:(NotificareUserPreference *)preference completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Use this method to allow an authenticated user to add himself/herself to a segment previously created and added to the user preferences. These are retrievable by the method described below.
		/// </summary>
		/// <param name="segment">Segment.</param>
		/// <param name="preference">Preference.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("addSegment:toPreference:completionHandler:errorHandler:")]
		void AddSegmentToPreference(NotificareSegment segment, NotificareUserPreference preference, [BlockCallback] SuccessArrayCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)removeSegment:(NotificareSegment *)segment fromPreference:(NotificareUserPreference *)preference completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)errorBlock;
		 */

		/// <summary>
		/// Use this method to allow an authenticated user to remove himself/herself from a segment previously created and added to the user preferences. These are retrievable by the method described below.
		/// </summary>
		/// <param name="segment">Segment.</param>
		/// <param name="preference">Preference.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("removeSegment:fromPreference:completionHandler:errorHandler:")]
		void RemoveSegmentFromPreference(NotificareSegment segment, NotificareUserPreference preference, [BlockCallback] SuccessArrayCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)checkAccount:(NSString *)user completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Checks the account.
		/// </summary>
		/// <param name="user">User.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("checkAccount:completionHandler:errorHandler:")]
		void CheckAccount(NSString user, [BlockCallback] SuccessCallback completionHandler, [BlockCallback] ErrorCallback errorHandler);

		/*
		 * - (void)handleOpenURL:(NSURL *)url;
		 */

		/// <summary>
		/// Opens the URL
		/// </summary>
		/// <param name="url">URL.</param>
		[Export("handleOpenURL:")]
		void HandleOpenURL(NSUrl url);

		/*
		 * - (void)fetchProducts:(SuccessArrayBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Use this method to get a list of all the NotificareProduct objects that you created in both iTunes Connect and Notificare dashboard.
		/// </summary>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="erorHandler">Eror handler.</param>
		[Export("fetchProducts:errorHandler:")]
		void FetchProducts([BlockCallback] SuccessArrayCallback completionHandler, [BlockCallback] ErrorCallback erorHandler);

		/*
		 * - (void)fetchPurchasedProducts:(SuccessArrayBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Use this method to get a list of all the non-consumable product identifiers that this AppleID has purchased.
		/// </summary>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="erorHandler">Eror handler.</param>
		[Export("fetchPurchasedProducts:errorHandler:")]
		void FetchPurchasedProducts([BlockCallback] SuccessArrayCallback completionHandler, [BlockCallback] ErrorCallback erorHandler);


		/*
		 * - (void)fetchProduct:(NSString *)productIdentifier completionHandler:(SuccessProductBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Use this method to get specific NotificareProduct object by providing a product identifier (SKU).
		/// </summary>
		/// <param name="productIdentifier">Product identifier.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="erorHandler">Eror handler.</param>
		[Export("fetchProduct:completionHandler:errorHandler:")]
		void FetchProduct(NSString productIdentifier, [BlockCallback] SuccessProductCallback completionHandler, [BlockCallback] ErrorCallback erorHandler);


		/*
		 * - (void)buyProduct:(NotificareProduct *)product;
		 */

		/// <summary>
		/// Use this method to allow the user to buy a product. Use the NotificareProduct object retreived by the methods above to buy a product.
		/// </summary>
		/// <param name="product">Product.</param>
		[Export("buyProduct:")]
		void BuyProduct(NotificareProduct product);


		/*
		 * - (void)pauseDownloads:(NSArray *)downloads;
		 */

		/// <summary>
		/// Use this method to pause any active downloads.
		/// </summary>
		/// <param name="downloads">Downloads.</param>
		[Export("pauseDownloads:")]
		void PauseDownloads(NSArray downloads);


		/*
		 * - (void)cancelDownloads:(NSArray *)downloads;
		 */

		/// <summary>
		/// Use this method to cancel one or more active downloads.
		/// </summary>
		/// <param name="downloads">Downloads.</param>
		[Export("cancelDownloads:")]
		void CancelDownloads(NSArray downloads);


		/*
		 * - (void)resumeDownloads:(NSArray *)downloads;
		 */

		/// <summary>
		/// Use this method to resume one or more paused downloads.
		/// </summary>
		/// <param name="downloads">Downloads.</param>
		[Export("resumeDownloads:")]
		void ResumeDownloads(NSArray downloads);


		/*
		 * - (NSString *)contentPathForProduct:(NSString *)productIdentifier;
		 */

		/// <summary>
		/// Retrieve the path for the download content of a product using its SKU.
		/// </summary>
		/// <returns>The path for product.</returns>
		/// <param name="productIdentifier">Product identifier.</param>
		[Export("contentPathForProduct:")]
		NSString ContentPathForProduct(NSString productIdentifier);


		/*
		 * - (NSString *)sdkVersion;
		 */

		/// <summary>
		/// Retrieve the SDK version. Used by other frameworks to identify the native version.
		/// </summary>
		/// <value>The sdk version.</value>
		[Export("sdkVersion")]
		NSString SdkVersion { get; }

		// Properties

		/*
		 * @property (nonatomic, assign) id <NotificarePushLibDelegate> delegate;
		 */

		/// <summary>
		/// Public delegate to handle Notificare events
		/// </summary>
		/// <value>The delegate.</value>
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NotificarePushLibDelegate Delegate { get; set; }

		/*
		 * @property (strong, nonatomic) NotificareDevice * myDevice;
		 */

		/// <summary>
		/// A NotificareDevice object containing all information about the device properties like the device token, language, location, etc.
		/// </summary>
		/// <value>My device.</value>
		[Export("myDevice")]
		NotificareDevice MyDevice { get; }

		/*
		 * @property (strong, nonatomic) NSString * deviceToken __attribute__((deprecated("use myDevice instead.")));
		 */

		/// <summary>
		/// Returns the device Token 
		/// </summary>
		/// <value>The device token.</value>
		[Export("deviceToken")]
		[Obsolete ("use MyDevice instead.")]
		NSString DeviceToken { get; }

		/*
		 * @property (strong, nonatomic) NSString * device __attribute__((deprecated("use myDevice instead.")));
		 */
		/// <summary>
		/// Gets the device.
		/// </summary>
		/// <value>The device.</value>
		[Export("device")]
		[Obsolete ("use MyDevice instead.")]
		NSString Device { get; }

		/*
		 * @property (strong, nonatomic) NSString * userID __attribute__((deprecated("use myDevice or user instead.")));
		 */

		/// <summary>
		/// Gets the user ID.
		/// </summary>
		/// <value>The user I.</value>
		[Export("userID")]
		[Obsolete ("use MyDevice or User instead.")]
		NSString UserID { get; }

		/*
		 * @property (strong, nonatomic) NotificareUser * user;
		 */

		/// <summary>
		/// A NotificareUser object representing the current user
		/// </summary>
		/// <value>The user.</value>
		[Export("user")]
		NotificareUser User { get; }

		/*
		 * @property (strong, nonatomic) NSString * username __attribute__((deprecated("use myDevice or user instead.")));
		 */

		/// <summary>
		/// Gets the name of the user.
		/// </summary>
		/// <value>The name of the user.</value>
		[Export("username")]
		[Obsolete ("use MyDevice or User instead.")]
		NSString Username { get; }


		/*
		 * @property (nonatomic, assign) UIRemoteNotificationType notificationTypes;
		 */

		/// <summary>
		/// Gets the notification types.
		/// </summary>
		/// <value>The notification types.</value>
		[Export("notificationTypes")]
		UIRemoteNotificationType NotificationTypes { get; }


		/*
		 * @property (assign) BOOL isOpen;
		 */

		/// <summary>
		/// Boolean for checking if notification is open
		/// </summary>
		/// <value><c>true</c> if this instance is open; otherwise, <c>false</c>.</value>
		[Export("isOpen")]
		bool IsOpen{ get; }

		/*
		 * @property (assign) BOOL isFixingGPS;
		 */

		/// <summary>
		/// Boolean for checking if position is being fixed
		/// </summary>
		/// <value><c>true</c> if position is being fixed; otherwise, <c>false</c>.</value>
		[Export("isFixingGPS")]
		bool IsFixingGPS{ get; }

		/*
		 * @property (assign) BOOL displayMessage;
		 */

		/// <summary>
		/// Gets or sets a value indicating whether we should always display alert message.
		/// </summary>
		/// <value><c>true</c> if display message; otherwise, <c>false</c>.</value>
		[Export("displayMessage")]
		bool DisplayMessage { get; set; }

		/*
		 * @property (strong, nonatomic) CLRegion * currentFence __attribute__((deprecated("use currentRegions instead.")));
		 */

		/// <summary>
		/// Gets the current fence.
		/// </summary>
		/// <value>The current fence.</value>
		[Export("currentFence")]
		[Obsolete ("use CurrentRegions instead.")]
		CLRegion CurrentFence { get; }

		/*
		 * @property (strong, nonatomic) NSMutableArray * currentRegions;
		 */

		/// <summary>
		/// NSMutableArray containing the CLRegion objects the user is currently inside
		/// </summary>
		/// <value>The current regions.</value>
		[Export("currentRegions")]
		NSMutableArray CurrentRegions { get; }

		/*
		 * @property (strong, nonatomic) NSMutableArray * currentBeacons;
		 */

		/// <summary>
		/// NSMutableArray containing the CLBeaconRegion objects the user is currently in range
		/// </summary>
		/// <value>The current beacons.</value>
		[Export("currentBeacons")]
		NSMutableArray CurrentBeacons { get; }

		/*
		 * @property (strong, nonatomic) NSMutableArray * notificationQueue;
		 */

		/// <summary>
		/// Returns all queued notifications
		/// </summary>
		/// <value>The notification queue.</value>
		[Export("notificationQueue")]
		NSMutableArray NotificationQueue { get; }

		/*
		 * @property (strong, nonatomic) NSDictionary * activeNotification;
		 */

		/// <summary>
		/// Gets the active notification.
		/// </summary>
		/// <value>The active notification.</value>
		[Export("activeNotification")]
		NSDictionary ActiveNotification { get; }

		/*
		 * @property (strong, nonatomic) CLLocationManager *locationManager;
		 */

		/// <summary>
		/// Core Location Manager that handles significant change updates
		/// </summary>
		/// <value>The location manager.</value>
		[Export("locationManager")]
		CLLocationManager LocationManager { get; set; } 



		/*
		 * @property (strong, nonatomic) NSMutableArray *lastLocations;
		 */

		/// <summary>
		/// A mutable array that holds lasts readings from Core Location
		/// </summary>
		/// <value>The last locations.</value>
		[Export("lastLocations")]
		NSMutableArray LastLocations { get; }

		/*
		 * @property (strong, nonatomic) NSMutableArray * regionSessions;
		 */

		/// <summary>
		/// A mutable array that holds hold the enter/exit time and location updates
		/// </summary>
		/// <value>The region session.</value>
		[Export("regionSessions")]
		NSMutableArray RegionSessions { get; }

		/*
		 * @property (strong, nonatomic) NSMutableArray * beaconSession;
		 */

		/// <summary>
		/// A mutable dictionary that holds hold the range time in each of the beacons in range
		/// </summary>
		/// <value>The beacon session.</value>
		[Export("beaconSession")]
		NSMutableDictionary BeaconSession { get; }

		/*
		 * @property (strong, nonatomic) CLBeaconRegion *beaconRegion;
		 */

		/// <summary>
		/// A iBeacon region with UUID loaded from plist
		/// </summary>
		/// <value>The beacon region.</value>
		[Export("beaconRegion")]
		CLBeaconRegion BeaconRegion { get; }

		/*
		 * @property (nonatomic, assign) BOOL shouldAlwaysLogBeacons;
		 */

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Notificare.iOS.NotificarePushLib"/> should always log beacons.
		/// </summary>
		/// <value><c>true</c> if should always log beacons; otherwise, <c>false</c>.</value>
		[Export ("shouldAlwaysLogBeacons")]
		bool ShouldAlwaysLogBeacons { get; set; }

		/*
		 * @property (nonatomic, assign) BOOL ranging;
		 */

		/// <summary>
		/// A BOOL to flag when iBeacon is in range
		/// </summary>
		/// <value><c>true</c> if ranging; otherwise, <c>false</c>.</value>
		[Export("ranging")]
		bool Ranging { get; }


		/*
		 * @property (strong, nonatomic) NSMutableArray * beacons;
		 */

		/// <summary>
		/// Returns Beacons being monitored
		/// </summary>
		/// <value>The beacons.</value>
		[Export("beacons")]
		NSMutableArray Beacons { get; }


		/*
		 * @property (strong, nonatomic) NSMutableArray * stateBeacons;
		 */

		/// <summary>
		/// Returns an array of beacons that were triggered by entry
		/// </summary>
		/// <value>The state beacons.</value>
		[Export("stateBeacons")]
		NSMutableArray StateBeacons { get; }


		/*
		 * @property (strong, nonatomic) NSDictionary * applicationInfo;
		 */

		/// <summary>
		/// Returns application's public info
		/// </summary>
		/// <value>The application info.</value>
		[Export("applicationInfo")]
		NSDictionary ApplicationInfo { get; }


		/*
		 * @property (strong, nonatomic) NSMutableArray * geofences;
		 */

		/// <summary>
		/// Returns Regions being monitored
		/// </summary>
		/// <value>The geo fences.</value>
		[Export("geoFences")]
		NSMutableArray GeoFences { get; }


		/*
		 * @property (strong, nonatomic) NSMutableArray * stateEntries;
		 */

		/// <summary>
		/// Returns an array of regions that were triggered by entry
		/// </summary>
		/// <value>The state entries.</value>
		[Export("stateEntries")]
		NSMutableArray StateEntries { get; }

		/*
		 * @property (strong, nonatomic) NSMutableSet * productIdentifiers;
		 */

		[Export("productIdentifiers")]
		NSMutableSet ProductIdentifiers { get; }


		/*
		 * @property (strong, nonatomic) NSMutableArray * products;
		 */

		[Export("products")]
		NSMutableArray Products { get; }

		/*
		 * @property (strong, nonatomic) NSMutableArray * pendingTransactions;
		 */

		[Export("pendingTransactions")]
		NSMutableArray PendingTransactions { get; }


		/*
		 * @property (strong, nonatomic) NSMutableSet * purchasedProducts;
		 */

		[Export("purchasedProducts")]
		NSMutableSet PurchasedProducts { get; }

		/*
		 * @property (strong, nonatomic) SKProductsRequest * storeRequest;
		 */

		[Export("storeRequest")]
		SKProductsRequest StoreRequest { get; }

	}




}

