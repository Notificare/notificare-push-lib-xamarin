// WARNING: This feature is deprecated. Use the "Native References" folder instead.
// Right-click on the "Native References" folder, select "Add Native Reference",
// and then select the static library or framework that you'd like to bind.
//
// Once you've added your static library or framework, right-click the library or
// framework and select "Properties" to change the LinkWith values.

using ObjCRuntime;

[assembly: LinkWith ("libNotificarePushLib.a", SmartLink = false, ForceLoad = true, LinkerFlags = "-licucore", WeakFrameworks = "PassKit UserNotifications", Frameworks = "AVFoundation CoreLocation CoreData MobileCoreServices MessageUI UIKit Foundation CoreGraphics MapKit SystemConfiguration Security CFNetwork ImageIO StoreKit SafariServices")]
