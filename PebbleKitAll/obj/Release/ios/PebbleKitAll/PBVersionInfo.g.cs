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
	[Protocol (Name = "PBVersionInfo", WrapperType = typeof (PBVersionInfoWrapper))]
	public interface IPBVersionInfo : INativeObject, IDisposable
	{
	}
	
	public static partial class PBVersionInfo_Extensions {
		[CompilerGenerated]
		public static bool HasRecoveryFirmware (this IPBVersionInfo This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasRecoveryFirmware"));
		}
		
		[CompilerGenerated]
		public static bool HasSystemResources (this IPBVersionInfo This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasSystemResources"));
		}
		
		[CompilerGenerated]
		public static PBFirmwareMetadata GetRunningFirmwareMetadata (this IPBVersionInfo This)
		{
			return  Runtime.GetNSObject<PBFirmwareMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("runningFirmwareMetadata")));
		}
		
		[CompilerGenerated]
		public static PBFirmwareMetadata GetRecoveryFirmwareMetadata (this IPBVersionInfo This)
		{
			return  Runtime.GetNSObject<PBFirmwareMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("recoveryFirmwareMetadata")));
		}
		
		[CompilerGenerated]
		public static PBResourceMetadata GetSystemResources (this IPBVersionInfo This)
		{
			return  Runtime.GetNSObject<PBResourceMetadata> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("systemResources")));
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetBootloaderVersion (this IPBVersionInfo This)
		{
			return ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("bootloaderVersion"));
		}
		
		[CompilerGenerated]
		public static string GetHardwareVersion (this IPBVersionInfo This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("hardwareVersion")));
		}
		
		[CompilerGenerated]
		public static string GetSerialNumber (this IPBVersionInfo This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("serialNumber")));
		}
		
		[CompilerGenerated]
		public static NSData GetDeviceAddress (this IPBVersionInfo This)
		{
			return  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("deviceAddress")));
		}
		
	}
	
	internal sealed class PBVersionInfoWrapper : BaseWrapper, IPBVersionInfo {
		public PBVersionInfoWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBVersionInfoWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBVersionInfo", true)]
	[Model]
	public unsafe partial class PBVersionInfo : NSObject, IPBVersionInfo {
		
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
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hasSystemResources")]
		[CompilerGenerated]
		public virtual bool HasSystemResources ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint BootloaderVersion {
			[Export ("bootloaderVersion")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSData DeviceAddress {
			[Export ("deviceAddress", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string HardwareVersion {
			[Export ("hardwareVersion", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PBFirmwareMetadata RecoveryFirmwareMetadata {
			[Export ("recoveryFirmwareMetadata", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PBFirmwareMetadata RunningFirmwareMetadata {
			[Export ("runningFirmwareMetadata", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SerialNumber {
			[Export ("serialNumber", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PBResourceMetadata SystemResources {
			[Export ("systemResources", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class PBVersionInfo */
}
