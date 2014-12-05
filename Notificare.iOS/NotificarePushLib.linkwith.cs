using System;
#if __UNIFIED__
using ObjCRuntime;
#else
using MonoTouch.ObjCRuntime;
#endif

[assembly: LinkWith (
	"NotificarePushLib.a", 
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64, 
	ForceLoad = true,
	LinkerFlags="-licucore",
	Frameworks = "Foundation, UIKit, CoreLocation, MessageUI, CoreGraphics, PassKit, MapKit, SystemConfiguration, Security, CFNetwork, MobileCoreServices, ImageIO, StoreKit")]
