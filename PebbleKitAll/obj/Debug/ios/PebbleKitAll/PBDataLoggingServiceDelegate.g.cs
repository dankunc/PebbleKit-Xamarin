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
	[Protocol (Name = "PBDataLoggingServiceDelegate", WrapperType = typeof (PBDataLoggingServiceDelegateWrapper))]
	public interface IPBDataLoggingServiceDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PBDataLoggingServiceDelegate_Extensions {
		[CompilerGenerated]
		public static bool HasByteArrays (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, byte bytes, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (session == null)
				throw new ArgumentNullException ("session");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_byte_UInt16_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:hasByteArrays:numberOfItems:forDataLoggingSession:"), service.Handle, bytes, numberOfItems, session.Handle);
		}
		
		[CompilerGenerated]
		public static bool HasUInt8s (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, global::System.Byte[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (session == null)
				throw new ArgumentNullException ("session");
			var nsa_data = NSArray.FromObjects (data);
//			NSData nsd_data = NSData.FromArray (data);
//			NSArray nsa_data = (NSArray)NSKeyedUnarchiver.UnarchiveObject (nsd_data);

			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt16_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:hasUInt8s:numberOfItems:forDataLoggingSession:"), service.Handle, nsa_data.Handle, numberOfItems, session.Handle);
			nsa_data.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool HasUInt16s (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, global::System.UInt16[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (session == null)
				throw new ArgumentNullException ("session");
			var nsa_data = NSArray.FromObjects (data);

			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt16_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:hasUInt16s:numberOfItems:forDataLoggingSession:"), service.Handle, nsa_data.Handle, numberOfItems, session.Handle);
			nsa_data.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool HasUInt32s (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, global::System.UInt32[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (session == null)
				throw new ArgumentNullException ("session");
			var nsa_data = NSArray.FromObjects (data);
//			NSData nsd_data = NSData.FromArray (data);
//			NSArray nsa_data = (NSArray)NSKeyedUnarchiver.UnarchiveObject (nsd_data);

			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt16_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:hasUInt32s:numberOfItems:forDataLoggingSession:"), service.Handle, nsa_data.Handle, numberOfItems, session.Handle);
			nsa_data.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool HasSInt8s (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, global::System.SByte[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (session == null)
				throw new ArgumentNullException ("session");
			var nsa_data = NSArray.FromObjects (data);
//			NSData nsd_data = NSData.FromArray (data);
//			NSArray nsa_data = (NSArray)NSKeyedUnarchiver.UnarchiveObject (nsd_data);

			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt16_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:hasSInt8s:numberOfItems:forDataLoggingSession:"), service.Handle, nsa_data.Handle, numberOfItems, session.Handle);
			nsa_data.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool HasSInt16s (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, global::System.Int16[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (session == null)
				throw new ArgumentNullException ("session");
			var nsa_data = NSArray.FromObjects (data);
//			NSData nsd_data = NSData.FromArray (data);
//			NSArray nsa_data = (NSArray)NSKeyedUnarchiver.UnarchiveObject (nsd_data);

			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt16_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:hasSInt16s:numberOfItems:forDataLoggingSession:"), service.Handle, nsa_data.Handle, numberOfItems, session.Handle);
			nsa_data.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool HasSInt32s (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, global::System.Int32[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (data == null)
				throw new ArgumentNullException ("data");
			if (session == null)
				throw new ArgumentNullException ("session");
			var nsa_data = NSArray.FromObjects (data);
//			NSData nsd_data = NSData.FromArray (data);
//			NSArray nsa_data = (NSArray)NSKeyedUnarchiver.UnarchiveObject (nsd_data);

			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt16_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:hasSInt32s:numberOfItems:forDataLoggingSession:"), service.Handle, nsa_data.Handle, numberOfItems, session.Handle);
			nsa_data.Dispose ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void SessionDidFinish (this IPBDataLoggingServiceDelegate This, PBDataLoggingService service, PBDataLoggingSessionMetadata session)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (session == null)
				throw new ArgumentNullException ("session");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("dataLoggingService:sessionDidFinish:"), service.Handle, session.Handle);
		}
		
	}
	
	internal sealed class PBDataLoggingServiceDelegateWrapper : BaseWrapper, IPBDataLoggingServiceDelegate {
		public PBDataLoggingServiceDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBDataLoggingServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBDataLoggingServiceDelegate", true)]
	[Model]
	public unsafe partial class PBDataLoggingServiceDelegate : NSObject, IPBDataLoggingServiceDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBDataLoggingServiceDelegate () : base (NSObjectFlag.Empty)
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
		protected PBDataLoggingServiceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBDataLoggingServiceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dataLoggingService:hasByteArrays:numberOfItems:forDataLoggingSession:")]
		[CompilerGenerated]
		public virtual bool HasByteArrays (PBDataLoggingService service, byte bytes, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dataLoggingService:hasSInt16s:numberOfItems:forDataLoggingSession:")]
		[CompilerGenerated]
		public virtual bool HasSInt16s (PBDataLoggingService service, global::System.Int16[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dataLoggingService:hasSInt32s:numberOfItems:forDataLoggingSession:")]
		[CompilerGenerated]
		public virtual bool HasSInt32s (PBDataLoggingService service, global::System.Int32[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dataLoggingService:hasSInt8s:numberOfItems:forDataLoggingSession:")]
		[CompilerGenerated]
		public virtual bool HasSInt8s (PBDataLoggingService service, global::System.SByte[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dataLoggingService:hasUInt16s:numberOfItems:forDataLoggingSession:")]
		[CompilerGenerated]
		public virtual bool HasUInt16s (PBDataLoggingService service, global::System.UInt16[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dataLoggingService:hasUInt32s:numberOfItems:forDataLoggingSession:")]
		[CompilerGenerated]
		public virtual bool HasUInt32s (PBDataLoggingService service, global::System.UInt32[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dataLoggingService:hasUInt8s:numberOfItems:forDataLoggingSession:")]
		[CompilerGenerated]
		public virtual bool HasUInt8s (PBDataLoggingService service, global::System.Byte[] data, global::System.UInt16 numberOfItems, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("dataLoggingService:sessionDidFinish:")]
		[CompilerGenerated]
		public virtual void SessionDidFinish (PBDataLoggingService service, PBDataLoggingSessionMetadata session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PBDataLoggingServiceDelegate */
}
