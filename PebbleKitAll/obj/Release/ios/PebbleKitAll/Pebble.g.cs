//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace PebbleKitAll {
	public unsafe static partial class Pebble  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSError");
		
		[Export ("pebbleErrorWithCode:underLyingError:")]
		[CompilerGenerated]
		public static NSError PebbleErrorWithCode (this NSError This, PBErrorCode code, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			return  Runtime.GetNSObject<NSError> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, Selector.GetHandle ("pebbleErrorWithCode:underLyingError:"), (UInt32)code, error.Handle));
		}
		
		[Export ("pebbleErrorWithCode:")]
		[CompilerGenerated]
		public static NSError PebbleErrorWithCode (this NSError This, PBErrorCode code)
		{
			return  Runtime.GetNSObject<NSError> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("pebbleErrorWithCode:"), (UInt32)code));
		}
		
	} /* class Pebble */
}
