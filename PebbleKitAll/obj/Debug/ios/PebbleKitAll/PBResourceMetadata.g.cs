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
	[Register("PBResourceMetadata", true)]
	public unsafe partial class PBResourceMetadata : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBResourceMetadata");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBResourceMetadata () : base (NSObjectFlag.Empty)
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
		protected PBResourceMetadata (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBResourceMetadata (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("isValid")]
		[CompilerGenerated]
		public virtual bool IsValid ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isValid"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isValid"));
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Crc {
			[Export ("crc")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("crc"));
				} else {
					return ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("crc"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string FriendlyVersion {
			[Export ("friendlyVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("friendlyVersion")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("friendlyVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Timestamp {
			[Export ("timestamp")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("timestamp"));
				} else {
					return ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timestamp"));
				}
			}
			
		}
		
	} /* class PBResourceMetadata */
}
