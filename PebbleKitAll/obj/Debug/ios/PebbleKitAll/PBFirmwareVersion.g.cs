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
	[Register("PBFirmwareVersion", true)]
	public unsafe partial class PBFirmwareVersion : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBFirmwareVersion");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBFirmwareVersion () : base (NSObjectFlag.Empty)
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
		protected PBFirmwareVersion (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBFirmwareVersion (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("compare:")]
		[CompilerGenerated]
		public virtual NSComparisonResult Compare (PBFirmwareVersion aVersion)
		{
			if (aVersion == null)
				throw new ArgumentNullException ("aVersion");
			NSComparisonResult ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (NSComparisonResult) ApiDefinition.Messaging.Int64_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("compare:"), aVersion.Handle);
				} else {
					ret = (NSComparisonResult) ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("compare:"), aVersion.Handle);
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (NSComparisonResult) ApiDefinition.Messaging.Int64_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("compare:"), aVersion.Handle);
				} else {
					ret = (NSComparisonResult) ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("compare:"), aVersion.Handle);
				}
			}
			return ret;
		}
		
		[Export ("firmwareVersionWithOS:major:minor:suffix:commitHash:timestamp:")]
		[CompilerGenerated]
		public static PBFirmwareVersion FirmwareVersionWithOS (global::System.nint os, global::System.nint major, global::System.nint minor, string suffix, string commitHash, global::System.nuint timestamp)
		{
			if (suffix == null)
				throw new ArgumentNullException ("suffix");
			if (commitHash == null)
				throw new ArgumentNullException ("commitHash");
			var nssuffix = NSString.CreateNative (suffix);
			var nscommitHash = NSString.CreateNative (commitHash);
			
			PBFirmwareVersion ret;
			ret =  Runtime.GetNSObject<PBFirmwareVersion> (ApiDefinition.Messaging.IntPtr_objc_msgSend_nint_nint_nint_IntPtr_IntPtr_nuint (class_ptr, Selector.GetHandle ("firmwareVersionWithOS:major:minor:suffix:commitHash:timestamp:"), os, major, minor, nssuffix, nscommitHash, timestamp));
			NSString.ReleaseNative (nssuffix);
			NSString.ReleaseNative (nscommitHash);
			
			return ret;
		}
		
		[Export ("firmwareVersionWithTag:commitHash:timestamp:")]
		[CompilerGenerated]
		public static PBFirmwareVersion FirmwareVersionWithTag (string tag, string commitHash, global::System.nuint timestamp)
		{
			if (tag == null)
				throw new ArgumentNullException ("tag");
			if (commitHash == null)
				throw new ArgumentNullException ("commitHash");
			var nstag = NSString.CreateNative (tag);
			var nscommitHash = NSString.CreateNative (commitHash);
			
			PBFirmwareVersion ret;
			ret =  Runtime.GetNSObject<PBFirmwareVersion> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint (class_ptr, Selector.GetHandle ("firmwareVersionWithTag:commitHash:timestamp:"), nstag, nscommitHash, timestamp));
			NSString.ReleaseNative (nstag);
			NSString.ReleaseNative (nscommitHash);
			
			return ret;
		}
		
		[Export ("isEqualOrNewer:")]
		[CompilerGenerated]
		public virtual bool IsEqualOrNewer (PBFirmwareVersion other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualOrNewer:"), other.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualOrNewer:"), other.Handle);
			}
		}
		
		[Export ("isEqualVersionOnly:")]
		[CompilerGenerated]
		public virtual bool IsEqualVersionOnly (PBFirmwareVersion other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualVersionOnly:"), other.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualVersionOnly:"), other.Handle);
			}
		}
		
		[Export ("isNewer:")]
		[CompilerGenerated]
		public virtual bool IsNewer (PBFirmwareVersion other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isNewer:"), other.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isNewer:"), other.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string CommitHash {
			[Export ("commitHash")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("commitHash")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("commitHash")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Major {
			[Export ("major")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("major"));
				} else {
					return ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("major"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Minor {
			[Export ("minor")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("minor"));
				} else {
					return ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minor"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Os {
			[Export ("os")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("os"));
				} else {
					return ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("os"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Suffix {
			[Export ("suffix")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("suffix")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("suffix")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Tag {
			[Export ("tag")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tag")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tag")));
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
		
	} /* class PBFirmwareVersion */
}
