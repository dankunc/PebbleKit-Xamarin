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
	[Register("PBFirmwareMetadata", true)]
	public unsafe partial class PBFirmwareMetadata : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBFirmwareMetadata");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBFirmwareMetadata () : base (NSObjectFlag.Empty)
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
		protected PBFirmwareMetadata (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBFirmwareMetadata (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hardwarePlatformToString:")]
		[CompilerGenerated]
		public static string HardwarePlatformToString (FirmwareMetadataPlatform hardwarePlatform)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("hardwarePlatformToString:"), (UInt32)hardwarePlatform));
		}
		
		[Export ("stringToHardwarePlatform:")]
		[CompilerGenerated]
		public static FirmwareMetadataPlatform StringToHardwarePlatform (string hardwarePlatformString)
		{
			if (hardwarePlatformString == null)
				throw new ArgumentNullException ("hardwarePlatformString");
			var nshardwarePlatformString = NSString.CreateNative (hardwarePlatformString);
			
			FirmwareMetadataPlatform ret;
			ret = (FirmwareMetadataPlatform) ApiDefinition.Messaging.UInt32_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("stringToHardwarePlatform:"), nshardwarePlatformString);
			NSString.ReleaseNative (nshardwarePlatformString);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual FirmwareMetadataPlatform HardwarePlatform {
			[Export ("hardwarePlatform")]
			get {
				if (IsDirectBinding) {
					return (FirmwareMetadataPlatform) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("hardwarePlatform"));
				} else {
					return (FirmwareMetadataPlatform) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hardwarePlatform"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsRecoveryFirmware {
			[Export ("isRecoveryFirmware")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRecoveryFirmware"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRecoveryFirmware"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Version_var;
		[CompilerGenerated]
		public virtual PBFirmwareVersion Version {
			[Export ("version")]
			get {
				PBFirmwareVersion ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PBFirmwareVersion> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("version")));
				} else {
					ret =  Runtime.GetNSObject<PBFirmwareVersion> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("version")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Version_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Version_var = null;
			}
		}
	} /* class PBFirmwareMetadata */
}
