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
	[Protocol (Name = "PBBitmap", WrapperType = typeof (PBBitmapWrapper))]
	public interface IPBBitmap : INativeObject, IDisposable
	{
	}
	
	public static partial class PBBitmap_Extensions {
		[CompilerGenerated]
		public static NSData GetPixelData (this IPBBitmap This)
		{
			return  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("pixelData")));
		}
		
		[CompilerGenerated]
		public static global::System.UInt16 GetRowSizeBytes (this IPBBitmap This)
		{
			return ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("rowSizeBytes"));
		}
		
		[CompilerGenerated]
		public static global::System.UInt16 GetInfoFlags (this IPBBitmap This)
		{
			return ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("infoFlags"));
		}
		
		[CompilerGenerated]
		public static GRect GetBounds (this IPBBitmap This)
		{
			GRect ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = ApiDefinition.Messaging.GRect_objc_msgSend (This.Handle, Selector.GetHandle ("bounds"));
				} else {
					ApiDefinition.Messaging.GRect_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("bounds"));
				}
			} else if (IntPtr.Size == 8) {
				ret = ApiDefinition.Messaging.GRect_objc_msgSend (This.Handle, Selector.GetHandle ("bounds"));
			} else {
				ret = ApiDefinition.Messaging.GRect_objc_msgSend (This.Handle, Selector.GetHandle ("bounds"));
			}
			return ret;
		}
		
	}
	
	internal sealed class PBBitmapWrapper : BaseWrapper, IPBBitmap {
		public PBBitmapWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBBitmapWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBBitmap", true)]
	[Model]
	public unsafe partial class PBBitmap : NSObject, IPBBitmap {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBBitmap () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PBBitmap (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBBitmap (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pebbleBitmapWithUIImage:")]
		[CompilerGenerated]
		public static PBBitmap PebbleBitmapWithUIImage (global::UIKit.UIImage image)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual GRect Bounds {
			[Export ("bounds", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 InfoFlags {
			[Export ("infoFlags", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSData PixelData {
			[Export ("pixelData", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 RowSizeBytes {
			[Export ("rowSizeBytes", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class PBBitmap */
}
