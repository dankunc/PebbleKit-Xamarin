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
	public unsafe static partial class stdint  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSNumber");
		
		[Export ("int16Value")]
		[CompilerGenerated]
		public static short Int16Value (this NSNumber This)
		{
			return ApiDefinition.Messaging.short_objc_msgSend (This.Handle, Selector.GetHandle ("int16Value"));
		}
		
		[Export ("int32Value")]
		[CompilerGenerated]
		public static int Int32Value (this NSNumber This)
		{
			return ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("int32Value"));
		}
		
		[Export ("int8Value")]
		[CompilerGenerated]
		public static global::System.SByte Int8Value (this NSNumber This)
		{
			return ApiDefinition.Messaging.SByte_objc_msgSend (This.Handle, Selector.GetHandle ("int8Value"));
		}
		
		[Export ("isFloat")]
		[CompilerGenerated]
		public static bool IsFloat (this NSNumber This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isFloat"));
		}
		
		[Export ("isSigned")]
		[CompilerGenerated]
		public static bool IsSigned (this NSNumber This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSigned"));
		}
		
		[Export ("numberWithInt16:")]
		[CompilerGenerated]
		public static NSNumber NumberWithInt16 (this NSNumber This, short value)
		{
			return  Runtime.GetNSObject<NSNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend_short (class_ptr, Selector.GetHandle ("numberWithInt16:"), value));
		}
		
		[Export ("numberWithInt32:")]
		[CompilerGenerated]
		public static NSNumber NumberWithInt32 (this NSNumber This, int value)
		{
			return  Runtime.GetNSObject<NSNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend_int (class_ptr, Selector.GetHandle ("numberWithInt32:"), value));
		}
		
		[Export ("numberWithInt8:")]
		[CompilerGenerated]
		public static NSNumber NumberWithInt8 (this NSNumber This, global::System.SByte value)
		{
			return  Runtime.GetNSObject<NSNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend_SByte (class_ptr, Selector.GetHandle ("numberWithInt8:"), value));
		}
		
		[Export ("numberWithUint16:")]
		[CompilerGenerated]
		public static NSNumber NumberWithUint16 (this NSNumber This, global::System.UInt16 value)
		{
			return  Runtime.GetNSObject<NSNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt16 (class_ptr, Selector.GetHandle ("numberWithUint16:"), value));
		}
		
		[Export ("numberWithUint32:")]
		[CompilerGenerated]
		public static NSNumber NumberWithUint32 (this NSNumber This, global::System.UInt32 value)
		{
			return  Runtime.GetNSObject<NSNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("numberWithUint32:"), value));
		}
		
		[Export ("numberWithUint8:")]
		[CompilerGenerated]
		public static NSNumber NumberWithUint8 (this NSNumber This, byte value)
		{
			return  Runtime.GetNSObject<NSNumber> (ApiDefinition.Messaging.IntPtr_objc_msgSend_byte (class_ptr, Selector.GetHandle ("numberWithUint8:"), value));
		}
		
		[Export ("uint16Value")]
		[CompilerGenerated]
		public static global::System.UInt16 Uint16Value (this NSNumber This)
		{
			return ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("uint16Value"));
		}
		
		[Export ("uint32Value")]
		[CompilerGenerated]
		public static global::System.UInt32 Uint32Value (this NSNumber This)
		{
			return ApiDefinition.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("uint32Value"));
		}
		
		[Export ("uint8Value")]
		[CompilerGenerated]
		public static byte Uint8Value (this NSNumber This)
		{
			return ApiDefinition.Messaging.byte_objc_msgSend (This.Handle, Selector.GetHandle ("uint8Value"));
		}
		
		[Export ("width")]
		[CompilerGenerated]
		public static byte Width (this NSNumber This)
		{
			return ApiDefinition.Messaging.byte_objc_msgSend (This.Handle, Selector.GetHandle ("width"));
		}
		
	} /* class stdint */
}
