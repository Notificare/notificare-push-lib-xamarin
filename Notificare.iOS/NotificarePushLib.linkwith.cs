using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith (
	"NotificarePushLib.a", 
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64, 
	ForceLoad = true,
	LinkerFlags="-licucore",
	Frameworks = "Foundation, UIKit, CoreLocation, MessageUI, CoreGraphics, PassKit, MapKit, SystemConfiguration, Security, CFNetwork, MobileCoreServices, ImageIO, StoreKit")]
