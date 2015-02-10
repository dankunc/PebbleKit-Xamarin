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
	[Register("PBBitmap", true)]
	public unsafe partial class PBBitmap : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBBitmap");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
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
			if (image == null)
				throw new ArgumentNullException ("image");
			return  Runtime.GetNSObject<PBBitmap> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("pebbleBitmapWithUIImage:"), image.Handle));
		}
		
		[CompilerGenerated]
		public virtual GRect Bounds {
			[Export ("bounds", ArgumentSemantic.UnsafeUnretained)]
			get {
				GRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.GRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
						} else {
							ApiDefinition.Messaging.GRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("bounds"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.GRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
					} else {
						ret = ApiDefinition.Messaging.GRect_objc_msgSend (this.Handle, Selector.GetHandle ("bounds"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = ApiDefinition.Messaging.GRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bounds"));
						} else {
							ApiDefinition.Messaging.GRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("bounds"));
						}
					} else if (IntPtr.Size == 8) {
						ret = ApiDefinition.Messaging.GRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bounds"));
					} else {
						ret = ApiDefinition.Messaging.GRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bounds"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 InfoFlags {
			[Export ("infoFlags", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.UInt16_objc_msgSend (this.Handle, Selector.GetHandle ("infoFlags"));
				} else {
					return ApiDefinition.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("infoFlags"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_PixelData_var;
		[CompilerGenerated]
		public virtual NSData PixelData {
			[Export ("pixelData", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pixelData")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pixelData")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_PixelData_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 RowSizeBytes {
			[Export ("rowSizeBytes", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.UInt16_objc_msgSend (this.Handle, Selector.GetHandle ("rowSizeBytes"));
				} else {
					return ApiDefinition.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rowSizeBytes"));
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_PixelData_var = null;
			}
		}
	} /* class PBBitmap */
}
