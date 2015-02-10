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
	[Protocol (Name = "PBFirmwareMetadata", WrapperType = typeof (PBFirmwareMetadataWrapper))]
	public interface IPBFirmwareMetadata : INativeObject, IDisposable
	{
	}
	
	public static partial class PBFirmwareMetadata_Extensions {
		[CompilerGenerated]
		public static PBFirmwareVersion GetVersion (this IPBFirmwareMetadata This)
		{
			return  Runtime.GetNSObject<PBFirmwareVersion> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("version")));
		}
		
		[CompilerGenerated]
		public static bool GetIsRecoveryFirmware (this IPBFirmwareMetadata This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRecoveryFirmware"));
		}
		
		[CompilerGenerated]
		public static FirmwareMetadataPlatform GetHardwarePlatform (this IPBFirmwareMetadata This)
		{
			return (FirmwareMetadataPlatform) ApiDefinition.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("hardwarePlatform"));
		}
		
	}
	
	internal sealed class PBFirmwareMetadataWrapper : BaseWrapper, IPBFirmwareMetadata {
		public PBFirmwareMetadataWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBFirmwareMetadataWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBFirmwareMetadata", true)]
	[Model]
	public unsafe partial class PBFirmwareMetadata : NSObject, IPBFirmwareMetadata {
		
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
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("stringToHardwarePlatform:")]
		[CompilerGenerated]
		public static FirmwareMetadataPlatform StringToHardwarePlatform (string hardwarePlatformString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual FirmwareMetadataPlatform HardwarePlatform {
			[Export ("hardwarePlatform")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsRecoveryFirmware {
			[Export ("isRecoveryFirmware")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual PBFirmwareVersion Version {
			[Export ("version")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class PBFirmwareMetadata */
}
