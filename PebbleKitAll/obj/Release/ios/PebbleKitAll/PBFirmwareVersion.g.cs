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
	[Protocol (Name = "PBFirmwareVersion", WrapperType = typeof (PBFirmwareVersionWrapper))]
	public interface IPBFirmwareVersion : INativeObject, IDisposable
	{
	}
	
	public static partial class PBFirmwareVersion_Extensions {
		[CompilerGenerated]
		public static NSComparisonResult Compare (this IPBFirmwareVersion This, PBFirmwareVersion aVersion)
		{
			if (aVersion == null)
				throw new ArgumentNullException ("aVersion");
			NSComparisonResult ret;
			if (IntPtr.Size == 8) {
				ret = (NSComparisonResult) ApiDefinition.Messaging.Int64_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("compare:"), aVersion.Handle);
			} else {
				ret = (NSComparisonResult) ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("compare:"), aVersion.Handle);
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static bool IsEqualOrNewer (this IPBFirmwareVersion This, PBFirmwareVersion other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("isEqualOrNewer:"), other.Handle);
		}
		
		[CompilerGenerated]
		public static bool IsNewer (this IPBFirmwareVersion This, PBFirmwareVersion other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("isNewer:"), other.Handle);
		}
		
		[CompilerGenerated]
		public static bool IsEqualVersionOnly (this IPBFirmwareVersion This, PBFirmwareVersion other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("isEqualVersionOnly:"), other.Handle);
		}
		
		[CompilerGenerated]
		public static global::System.nint GetOs (this IPBFirmwareVersion This)
		{
			return ApiDefinition.Messaging.nint_objc_msgSend (This.Handle, Selector.GetHandle ("os"));
		}
		
		[CompilerGenerated]
		public static global::System.nint GetMajor (this IPBFirmwareVersion This)
		{
			return ApiDefinition.Messaging.nint_objc_msgSend (This.Handle, Selector.GetHandle ("major"));
		}
		
		[CompilerGenerated]
		public static global::System.nint GetMinor (this IPBFirmwareVersion This)
		{
			return ApiDefinition.Messaging.nint_objc_msgSend (This.Handle, Selector.GetHandle ("minor"));
		}
		
		[CompilerGenerated]
		public static string GetSuffix (this IPBFirmwareVersion This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("suffix")));
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetTimestamp (this IPBFirmwareVersion This)
		{
			return ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("timestamp"));
		}
		
		[CompilerGenerated]
		public static string GetCommitHash (this IPBFirmwareVersion This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("commitHash")));
		}
		
		[CompilerGenerated]
		public static string GetTag (this IPBFirmwareVersion This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tag")));
		}
		
	}
	
	internal sealed class PBFirmwareVersionWrapper : BaseWrapper, IPBFirmwareVersion {
		public PBFirmwareVersionWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBFirmwareVersionWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBFirmwareVersion", true)]
	[Model]
	public unsafe partial class PBFirmwareVersion : NSObject, IPBFirmwareVersion {
		
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
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("firmwareVersionWithOS:major:minor:suffix:commitHash:timestamp:")]
		[CompilerGenerated]
		public static PBFirmwareVersion FirmwareVersionWithOS (global::System.nint os, global::System.nint major, global::System.nint minor, string suffix, string commitHash, global::System.nuint timestamp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("firmwareVersionWithTag:commitHash:timestamp:")]
		[CompilerGenerated]
		public static PBFirmwareVersion FirmwareVersionWithTag (string tag, string commitHash, global::System.nuint timestamp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isEqualOrNewer:")]
		[CompilerGenerated]
		public virtual bool IsEqualOrNewer (PBFirmwareVersion other)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isEqualVersionOnly:")]
		[CompilerGenerated]
		public virtual bool IsEqualVersionOnly (PBFirmwareVersion other)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isNewer:")]
		[CompilerGenerated]
		public virtual bool IsNewer (PBFirmwareVersion other)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual string CommitHash {
			[Export ("commitHash")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Major {
			[Export ("major")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Minor {
			[Export ("minor")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Os {
			[Export ("os")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Suffix {
			[Export ("suffix")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Tag {
			[Export ("tag")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Timestamp {
			[Export ("timestamp")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class PBFirmwareVersion */
}
