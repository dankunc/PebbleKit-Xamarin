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
	[Register("PBSportsUpdate", true)]
	public unsafe partial class PBSportsUpdate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBSportsUpdate");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBSportsUpdate () : base (NSObjectFlag.Empty)
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
		protected PBSportsUpdate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBSportsUpdate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dictionary")]
		[CompilerGenerated]
		public virtual NSDictionary Dictionary ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dictionary")));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dictionary")));
			}
		}
		
		[Export ("timeStringFromFloat:")]
		[CompilerGenerated]
		public static string TimeStringFromFloat (float seconds)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_float (class_ptr, Selector.GetHandle ("timeStringFromFloat:"), seconds));
		}
		
		[Export ("updateWithTime:distance:data:")]
		[CompilerGenerated]
		public static PBSportsUpdate UpdateWithTime (global::System.Double time, float distance, float data)
		{
			return  Runtime.GetNSObject<PBSportsUpdate> (ApiDefinition.Messaging.IntPtr_objc_msgSend_Double_float_float (class_ptr, Selector.GetHandle ("updateWithTime:distance:data:"), time, distance, data));
		}
		
		[CompilerGenerated]
		public virtual float Data {
			[Export ("data", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("data"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("data"));
				}
			}
			
			[Export ("setData:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setData:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setData:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float Distance {
			[Export ("distance", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("distance"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("distance"));
				}
			}
			
			[Export ("setDistance:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDistance:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setDistance:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Time {
			[Export ("time", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("time"));
				} else {
					return ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("time"));
				}
			}
			
			[Export ("setTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setTime:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setTime:"), value);
				}
			}
		}
		
	} /* class PBSportsUpdate */
}
