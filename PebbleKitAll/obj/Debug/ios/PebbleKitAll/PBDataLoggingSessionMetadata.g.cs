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
	[Register("PBDataLoggingSessionMetadata", true)]
	public unsafe partial class PBDataLoggingSessionMetadata : NSObject, INSCoding, INSCopying, INSSecureCoding {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBDataLoggingSessionMetadata");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
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
			if (IsDirectBinding) {
				return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			} else {
				return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			}
		}
		
		[Export ("encodeWithCoder:")]
		[CompilerGenerated]
		public virtual void EncodeTo (NSCoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException ("encoder");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			}
		}
		
		[Export ("isEqualToDataLoggingSessionMetadata:")]
		[CompilerGenerated]
		public virtual bool IsEqualToDataLoggingSessionMetadata (PBDataLoggingSessionMetadata sessionMetadata)
		{
			if (sessionMetadata == null)
				throw new ArgumentNullException ("sessionMetadata");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToDataLoggingSessionMetadata:"), sessionMetadata.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isEqualToDataLoggingSessionMetadata:"), sessionMetadata.Handle);
			}
		}
		
		[Export ("metadataWithTag:timestamp:type:itemSize:serialNumber:")]
		[CompilerGenerated]
		public static NSObject MetadataWithTag (global::System.nuint tag, global::System.nuint timestamp, byte type, global::System.UInt16 itemSize, string serialNumber)
		{
			if (serialNumber == null)
				throw new ArgumentNullException ("serialNumber");
			var nsserialNumber = NSString.CreateNative (serialNumber);
			
			NSObject ret;
			ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint_nuint_byte_UInt16_IntPtr (class_ptr, Selector.GetHandle ("metadataWithTag:timestamp:type:itemSize:serialNumber:"), tag, timestamp, type, itemSize, nsserialNumber));
			NSString.ReleaseNative (nsserialNumber);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 ItemSize {
			[Export ("itemSize")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.UInt16_objc_msgSend (this.Handle, Selector.GetHandle ("itemSize"));
				} else {
					return ApiDefinition.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("itemSize"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SerialNumber {
			[Export ("serialNumber")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serialNumber")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serialNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Tag {
			[Export ("tag")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("tag"));
				} else {
					return ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tag"));
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
		
		[CompilerGenerated]
		public virtual byte Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.byte_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				} else {
					return ApiDefinition.Messaging.byte_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
				}
			}
			
		}
		
	} /* class PBDataLoggingSessionMetadata */
}
