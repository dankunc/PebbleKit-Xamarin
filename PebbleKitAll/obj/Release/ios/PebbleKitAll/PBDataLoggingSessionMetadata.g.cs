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
	[Protocol (Name = "PBDataLoggingSessionMetadata", WrapperType = typeof (PBDataLoggingSessionMetadataWrapper))]
	public interface IPBDataLoggingSessionMetadata : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
		
	{
	}
	
	public static partial class PBDataLoggingSessionMetadata_Extensions {
		[CompilerGenerated]
		public static bool IsEqualToDataLoggingSessionMetadata (this IPBDataLoggingSessionMetadata This, PBDataLoggingSessionMetadata sessionMetadata)
		{
			if (sessionMetadata == null)
				throw new ArgumentNullException ("sessionMetadata");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("isEqualToDataLoggingSessionMetadata:"), sessionMetadata.Handle);
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetTag (this IPBDataLoggingSessionMetadata This)
		{
			return ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("tag"));
		}
		
		[CompilerGenerated]
		public static global::System.nuint GetTimestamp (this IPBDataLoggingSessionMetadata This)
		{
			return ApiDefinition.Messaging.nuint_objc_msgSend (This.Handle, Selector.GetHandle ("timestamp"));
		}
		
		[CompilerGenerated]
		public static byte GetType (this IPBDataLoggingSessionMetadata This)
		{
			return ApiDefinition.Messaging.byte_objc_msgSend (This.Handle, Selector.GetHandle ("type"));
		}
		
		[CompilerGenerated]
		public static global::System.UInt16 GetItemSize (this IPBDataLoggingSessionMetadata This)
		{
			return ApiDefinition.Messaging.UInt16_objc_msgSend (This.Handle, Selector.GetHandle ("itemSize"));
		}
		
		[CompilerGenerated]
		public static string GetSerialNumber (this IPBDataLoggingSessionMetadata This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("serialNumber")));
		}
		
	}
	
	internal sealed class PBDataLoggingSessionMetadataWrapper : BaseWrapper, IPBDataLoggingSessionMetadata {
		public PBDataLoggingSessionMetadataWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBDataLoggingSessionMetadataWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("encodeWithCoder:")]
		[CompilerGenerated]
		public void EncodeTo (NSCoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException ("encoder");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
		}
		
		[Export ("copyWithZone:")]
		[CompilerGenerated]
		public NSObject Copy (NSZone zone)
		{
			return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBDataLoggingSessionMetadata", true)]
	[Model]
	public unsafe partial class PBDataLoggingSessionMetadata : NSObject, IPBDataLoggingSessionMetadata, INSCoding, INSCopying, INSSecureCoding {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBDataLoggingSessionMetadata () : base (NSObjectFlag.Empty)
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
		[Export ("initWithCoder:")]
		public PBDataLoggingSessionMetadata (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PBDataLoggingSessionMetadata (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBDataLoggingSessionMetadata (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("copyWithZone:")]
		[CompilerGenerated]
		public virtual NSObject Copy (NSZone zone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("encodeWithCoder:")]
		[CompilerGenerated]
		public virtual void EncodeTo (NSCoder encoder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("isEqualToDataLoggingSessionMetadata:")]
		[CompilerGenerated]
		public virtual bool IsEqualToDataLoggingSessionMetadata (PBDataLoggingSessionMetadata sessionMetadata)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("metadataWithTag:timestamp:type:itemSize:serialNumber:")]
		[CompilerGenerated]
		public static NSObject MetadataWithTag (global::System.nuint tag, global::System.nuint timestamp, byte type, global::System.UInt16 itemSize, string serialNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 ItemSize {
			[Export ("itemSize")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SerialNumber {
			[Export ("serialNumber")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Tag {
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
		
		[CompilerGenerated]
		public virtual byte Type {
			[Export ("type")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class PBDataLoggingSessionMetadata */
}
