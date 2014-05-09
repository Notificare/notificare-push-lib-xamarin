using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace Notificare.iOS
{
	#region NotificarePushLib

	[BaseType (typeof (NSObject))]
	interface Notification
	{

	}

	[BaseType (typeof (NSObject))]
	[Model, Protocol]
	interface NotificarePushLibDelegate {

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
		 * - (void)notificarePushLib:(NotificarePushLib *)library willOpenNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Will open notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:willOpenNotification:")]
		void WillOpenNotification (NotificarePushLib library, Notification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didOpenNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Did open notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:didOpenNotification:")]
		void DidOpenNotification (NotificarePushLib library, Notification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didCloseNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Did close notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:didCloseNotification:")]
		void DidCloseNotification (NotificarePushLib library, Notification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library didFailToOpenNotification:(Notification *)notification;
		 */

		/// <summary>
		/// Did fail to open notification.
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:didFailToOpenNotification:")]
		void DidFailToOpenNotification (NotificarePushLib library, Notification notification);

		/*
		 * - (void)notificarePushLib:(NotificarePushLib *)library willExecuteAction:(Notification *)notification;
		 */

		/// <summary>
		/// Will execute an action on a notification
		/// </summary>
		/// <param name="library">Library.</param>
		/// <param name="notification">Notification.</param>
		[Export ("notificarePushLib:willExecuteAction:")]
		void WillExecuteAction (NotificarePushLib library, Notification notification);

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
		[Export ("notificarePushLib:didRangeBeacons:inRegion")]
		void DidRangeBeaconsInRegion (NotificarePushLib library, NSArray beacons, CLRegion region);

	}

	interface INotificarePushLibDelegate {}

	public delegate void SuccessCallback( NSDictionary info );
	public delegate void ErrorCallback( NSError error );

	// @interface NotificarePushLib : NSObject <SRWebSocketDelegate,NotificareDelegate,NotificareActionsDelegate,CLLocationManagerDelegate>
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
		void RegisterForRemoteNotifications (UIRemoteNotificationType types);

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
		void RegisterDevice( NSData token, SuccessCallback completionHandler, ErrorCallback errorHandler );


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
		void RegisterDeviceWithUserID( NSData token, NSString userID, SuccessCallback completionHandler, ErrorCallback errorHandler );

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
		void RegisterDeviceWithUserIDWithUsername( NSData token, NSString userID, NSString username, SuccessCallback completionHandler, ErrorCallback errorHandler );

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
		 * - (void)getNotification:(NSString *)notificationID completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Fetches a notification's full payload. Usually used if you gonna handle the notifications yourself.
		/// </summary>
		/// <param name="notificationID">Notification ID.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("getNotification:completionHandler:errorHandler:")]
		void GetNotification( NSString notificationID, SuccessCallback completionHandler, ErrorCallback errorHandler );

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
		void GetTags (SuccessCallback completionHandler, ErrorCallback errorHandler);

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
		void AddTags( NSArray tags, SuccessCallback completionHandler, ErrorCallback errorHandler);

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
		void RemoveTag(NSString tag, SuccessCallback completionHandler, ErrorCallback errorHandler);

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
		void ClearTags( SuccessCallback completionHandler, ErrorCallback errorHandler);

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
		void OpenBeacon (NSDictionary beacon);

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
		void ReplyWithLabelAndData (NSString notification, NSString label, NSDictionary data);



		// Properties

		/*
		 * @property (nonatomic, assign) id <NotificarePushLibDelegate> delegate;
		 */

		/// <summary>
		/// Public delegate to handle Notificare events
		/// </summary>
		/// <value>The delegate.</value>
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		INotificarePushLibDelegate Delegate { get; set; }

		/*
		 * @property (strong, nonatomic) NSString * deviceToken;
		 */

		/// <summary>
		/// Returns the device Token 
		/// </summary>
		/// <value>The device token.</value>
		[Export("deviceToken")]
		NSString DeviceToken { get; }

		/*
		 * @property (strong, nonatomic) NSString * device;
		 */
		/// <summary>
		/// Gets the device.
		/// </summary>
		/// <value>The device.</value>
		[Export("device")]
		NSString Device { get; }

		/*
		 * @property (strong, nonatomic) NSString * userID;
		 */
		/// <summary>
		/// Gets the user ID.
		/// </summary>
		/// <value>The user I.</value>
		[Export("userID")]
		NSString UserID { get; }

		/*
		 * @property (strong, nonatomic) NSString * username;
		 */

		/// <summary>
		/// Gets the name of the user.
		/// </summary>
		/// <value>The name of the user.</value>
		[Export("userName")]
		NSString UserName { get; }

		/*
		 * @property (nonatomic, assign) UIRemoteNotificationType notificationTypes;
		 */

		/// <summary>
		/// Gets the notification types.
		/// </summary>
		/// <value>The notification types.</value>
		[Export("notificationTypes")]
		UIRemoteNotificationType notificationTypes { get; }


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
		 * @property (assign) BOOL displayMessage;
		 */

		/// <summary>
		/// Gets or sets a value indicating whether we should always display alert message.
		/// </summary>
		/// <value><c>true</c> if display message; otherwise, <c>false</c>.</value>
		[Export("displayMessage")]
		bool DisplayMessage { get; set; }

		/*
		 * @property (strong, nonatomic) CLRegion * currentFence;
		 */

		/// <summary>
		/// Gets the current fence.
		/// </summary>
		/// <value>The current fence.</value>
		[Export("currentFence")]
		CLRegion CurrentFence { get; }

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
		 * @property (strong, nonatomic) NSMutableArray * regionSession;
		 */

		/// <summary>
		/// A mutable dictionary that holds hold the enter/exit time and location updates
		/// </summary>
		/// <value>The region session.</value>
		[Export("regionSession")]
		NSMutableArray RegionSession { get; }

		/*
		 * @property (strong, nonatomic) NSMutableArray * beaconSession;
		 */

		/// <summary>
		/// A mutable dictionary that holds hold the range time in each of the beacons in range
		/// </summary>
		/// <value>The beacon session.</value>
		[Export("beaconSession")]
		NSMutableArray BeaconSession { get; }

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
		 * @property (nonatomic, assign) BOOL ranging;
		 */

		/// <summary>
		/// A BOOL to flag when iBeacon is in range
		/// </summary>
		/// <value><c>true</c> if ranging; otherwise, <c>false</c>.</value>
		[Export("ranging")]
		bool Ranging { get; }


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
		 * @property (strong, nonatomic) NSMutableArray * beacons;
		 */

		/// <summary>
		/// Returns Beacons being monitored
		/// </summary>
		/// <value>The beacons.</value>
		[Export("beacons")]
		NSMutableArray Beacons { get; }


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
		 * @property (strong, nonatomic) NSMutableArray * stateBeacons;
		 */

		/// <summary>
		/// Returns an array of beacons that were triggered by entry
		/// </summary>
		/// <value>The state beacons.</value>
		[Export("stateBeacons")]
		NSMutableArray StateBeacons { get; }

	}

	#endregion
}

