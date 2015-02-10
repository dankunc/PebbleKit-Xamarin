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
	[Register("PBVersionInfo", true)]
	public unsafe partial class PBVersionInfo : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBVersionInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBVersionInfo () : base (NSObjectFlag.Empty)
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
		protected PBVersionInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBVersionInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("hasRecoveryFirmware")]
		[CompilerGenerated]
		public virtual bool HasRecoveryFirmware ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasRecoveryFirmware"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasRecoveryFirmware"));
			}
		}
		
		[Export ("hasSystemResources")]
		[CompilerGenerated]
		public virtual bool HasSystemResources ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasSystemResources"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasSystemResources"));
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint BootloaderVersion {
			[Export ("bootloaderVersion")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("bootloaderVersion"));
				} else {
					return ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bootloaderVersion"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DeviceAddress_var;
		[CompilerGenerated]
		public virtual NSData DeviceAddress {
			[Export ("deviceAddress", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("deviceAddress")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceAddress")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DeviceAddress_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string HardwareVersion {
			[Export ("hardwareVersion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hardwareVersion")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hardwareVersion")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RecoveryFirmwareMetadata_var;
		[CompilerGenerated]
		public virtual PBFirmwareMetadata RecoveryFirmwareMetadata {
			[Export ("recoveryFirmwareMetadata", ArgumentSemantic.Retain)]
			get {
				PBFirmwareMetadata ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PBFirmwareMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("recoveryFirmwareMetadata")));
				} else {
					ret =  Runtime.GetNSObject<PBFirmwareMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recoveryFirmwareMetadata")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RecoveryFirmwareMetadata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RunningFirmwareMetadata_var;
		[CompilerGenerated]
		public virtual PBFirmwareMetadata RunningFirmwareMetadata {
			[Export ("runningFirmwareMetadata", ArgumentSemantic.Retain)]
			get {
				PBFirmwareMetadata ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PBFirmwareMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("runningFirmwareMetadata")));
				} else {
					ret =  Runtime.GetNSObject<PBFirmwareMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("runningFirmwareMetadata")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RunningFirmwareMetadata_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SerialNumber {
			[Export ("serialNumber", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serialNumber")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serialNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_SystemResources_var;
		[CompilerGenerated]
		public virtual PBResourceMetadata SystemResources {
			[Export ("systemResources", ArgumentSemantic.Retain)]
			get {
				PBResourceMetadata ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PBResourceMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("systemResources")));
				} else {
					ret =  Runtime.GetNSObject<PBResourceMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("systemResources")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SystemResources_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_DeviceAddress_var = null;
				__mt_RecoveryFirmwareMetadata_var = null;
				__mt_RunningFirmwareMetadata_var = null;
				__mt_SystemResources_var = null;
			}
		}
	} /* class PBVersionInfo */
}
