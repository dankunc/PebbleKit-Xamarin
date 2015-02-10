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
	[Protocol (Name = "PBResourceMetadata", WrapperType = typeof (PBResourceMetadataWrapper))]
	public interface IPBResourceMetadata : INativeObject, IDisposable
	{
	}
	
	public static partial class PBResourceMetadata_Extensions {
		[CompilerGenerated]
		public static bool IsValid (this IPBResourceMetadata This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isValid"));
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetTimestamp (this IPBResourceMetadata This)
		{
			return ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("timestamp"));
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetCrc (this IPBResourceMetadata This)
		{
			return ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("crc"));
		}
		
		[CompilerGenerated]
		public static string GetFriendlyVersion (this IPBResourceMetadata This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("friendlyVersion")));
		}
		
	}
	
	internal sealed class PBResourceMetadataWrapper : BaseWrapper, IPBResourceMetadata {
		public PBResourceMetadataWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBResourceMetadataWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBResourceMetadata", true)]
	[Model]
	public unsafe partial class PBResourceMetadata : NSObject, IPBResourceMetadata {
		
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
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Crc {
			[Export ("crc")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string FriendlyVersion {
			[Export ("friendlyVersion", ArgumentSemantic.Retain)]
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
		
	} /* class PBResourceMetadata */
}
