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
	[Protocol (Name = "PBDataLoggingService", WrapperType = typeof (PBDataLoggingServiceWrapper))]
	public interface IPBDataLoggingService : INativeObject, IDisposable
	{
	}
	
	public static partial class PBDataLoggingService_Extensions {
		[CompilerGenerated]
		public static void SetDelegateQueue (this IPBDataLoggingService This, global::CoreFoundation.DispatchQueue delegateQueue)
		{
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegateQueue:"), delegateQueue.Handle);
		}
		
		[CompilerGenerated]
		public static void PollForData (this IPBDataLoggingService This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("pollForData"));
		}
		
		[CompilerGenerated]
		public static NSObject GetWeakDelegate (this IPBDataLoggingService This)
		{
			return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[CompilerGenerated]
		public static void SetWeakDelegate (this IPBDataLoggingService This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
		}
		
	}
	
	internal sealed class PBDataLoggingServiceWrapper : BaseWrapper, IPBDataLoggingService {
		public PBDataLoggingServiceWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBDataLoggingServiceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBDataLoggingService", true)]
	[Model]
	public unsafe partial class PBDataLoggingService : NSObject, IPBDataLoggingService {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBDataLoggingService () : base (NSObjectFlag.Empty)
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
		protected PBDataLoggingService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBDataLoggingService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pollForData")]
		[CompilerGenerated]
		public virtual void PollForData ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("setDelegateQueue:")]
		[CompilerGenerated]
		public virtual void SetDelegateQueue (global::CoreFoundation.DispatchQueue delegateQueue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public PBDataLoggingServiceDelegate Delegate {
			get {
				return WeakDelegate as /**/PBDataLoggingServiceDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class PBDataLoggingService */
}
