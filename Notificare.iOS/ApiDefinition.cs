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
		/// Shared this instance.
		/// </summary>
		[Static][Export("shared")]
		NotificarePushLib Shared();

		/*
		 * - (void)launch;
		 */

		/// <summary>
		/// Launch this instance.
		/// </summary>
		[Export("launch")]
		void Launch();

		/*
		 * - (void)registerForRemoteNotificationsTypes:(UIRemoteNotificationType)types;
		 */

		/// <summary>
		/// Registers for remote notifications.
		/// </summary>
		/// <param name="types">Types.</param>
		[Export("registerForRemoteNotificationsTypes:")]
		void RegisterForRemoteNotifications (UIRemoteNotificationType types);

		/*
		 * - (void)handleOptions:(NSDictionary *)options;
		 */

		/// <summary>
		/// Handles the launch options.
		/// </summary>
		/// <param name="options">Options.</param>
		[Export("handleOptions:")]
		void HandleOptions( NSDictionary options );

		/*
		 * - (void)registerDevice:(NSData *)token;
		 */

		/// <summary>
		/// Registers the device.
		/// </summary>
		/// <param name="token">Token.</param>
		[Export("registerDevice:")]
		void RegisterDevice( NSData token );

		/*
		 * - (void)registerDevice:(NSData *)token completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Registers the device.
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
		/// Registers the device with user identifier
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User identifier.</param>
		[Export("registerDevice:withUserID:")]
		void registerDeviceWithUserID( NSData token, NSString userID );

		/*
		 * - (void)registerDevice:(NSData *)token withUserID:(NSString *)userID withUsername:(NSString *)username;
		 */

		/// <summary>
		/// Registers the device with user identifier and username.
		/// </summary>
		/// <param name="token">Token.</param>
		/// <param name="userID">User ID.</param>
		/// <param name="username">Username.</param>
		[Export("registerDevice:withUserID:withUsername:")]
		void registerDeviceWithUserIDAndUsername( NSData token, NSString userID, NSString username );

		/*
		 * - (void)openNotification:(NSDictionary *)notification;
		 */

		/// <summary>
		/// Opens the notification.
		/// </summary>
		/// <param name="notification">Notification.</param>
		[Export("openNotification:")]
		void OpenNotification( NSDictionary notification );

		/*
		 * - (void)getNotification:(NSString *)notificationID completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */

		/// <summary>
		/// Gets the notification.
		/// </summary>
		/// <param name="notificationID">Notification ID.</param>
		/// <param name="completionHandler">Completion handler.</param>
		/// <param name="errorHandler">Error handler.</param>
		[Export("getNotification:completionHandler:errorHandler:")]
		void GetNotification( NSString notificationID, SuccessCallback completionHandler, ErrorCallback errorHandler );


		/*
		 * - (void)addTags:(NSArray *)tags;
		 */

		/// <summary>
		/// Adds the tags.
		/// </summary>
		/// <param name="tags">Tags.</param>
		[Export("addTags:")]
		void AddTags( NSArray tags );

		/*
		 * - (void)addTags:(NSArray *)tags completionHandler:(SuccessBlock)info errorHandler:(ErrorBlock)error;
		 */
		//
		[Export("addTags:completionHandler:errorHandler:")]
		void AddTags( NSArray tags, SuccessCallback info, ErrorCallback error );

		/*
		 * - (void)clearNotification:(NSString *)notification;
		 */

		/// <summary>
		/// Clears the notification.
		/// </summary>
		/// <param name="notificationID">Notification I.</param>
		[Export("clearNotification:")]
		void ClearNotification( NSString notificationID );

		/*
		 * - (void)unregisterDevice;
		 */

		/// <summary>
		/// Unregisters the device.
		/// </summary>
		[Export("unregisterDevice")]
		void UnregisterDevice();

		/*
		 * -(void)startLocationUpdates;
		 */

		/// <summary>
		/// Starts the location updates.
		/// </summary>
		[Export ("startLocationUpdates")]
		void StartLocationUpdates();

		/*
		 * - (void)updateLocation:(NSString*)device withLatitude:(float)latitude andLongitude:(float)longitude;
		 */

		/// <summary>
		/// Updates the location.
		/// </summary>
		/// <param name="device">Device.</param>
		/// <param name="latitude">Latitude.</param>
		/// <param name="longitude">Longitude.</param>
		[Export ("updateLocation:withLatitude:andLongitude:")]
		void updateLocation( NSString device, float latitude, float longitude );

		/*
		 * Properties
		 */
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		INotificarePushLibDelegate Delegate { get; set; }


		/// <summary>
		/// Gets or sets the location manager.
		/// </summary>
		/// <value>The location manager.</value>
		[Export("locationManager")]
		CLLocationManager LocationManager { get; set; } 

		/// <summary>
		/// Gets or sets the device token.
		/// </summary>
		/// <value>The device token.</value>
		[Export("deviceToken")]
		NSString DeviceToken { get; set; }

		/// <summary>
		/// Gets or sets the user ID.
		/// </summary>
		/// <value>The user ID.</value>
		[Export("userID")]
		NSString userID { get; set; }

		/// <summary>
		/// Gets or sets the name of the user.
		/// </summary>
		/// <value>The name of the user.</value>
		[Export("userName")]
		NSString userName { get; set; }

	}

	#endregion
}

