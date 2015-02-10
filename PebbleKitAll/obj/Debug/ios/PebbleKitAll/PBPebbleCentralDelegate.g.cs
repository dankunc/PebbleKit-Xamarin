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
	[Protocol (Name = "PBPebbleCentralDelegate", WrapperType = typeof (PBPebbleCentralDelegateWrapper))]
	public interface IPBPebbleCentralDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PBPebbleCentralDelegate_Extensions {
		[CompilerGenerated]
		public static void WatchDidConnect (this IPBPebbleCentralDelegate This, PBPebbleCentral central, PBWatch watch, bool isNew)
		{
			if (central == null)
				throw new ArgumentNullException ("central");
			if (watch == null)
				throw new ArgumentNullException ("watch");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("pebbleCentral:watchDidConnect:isNew:"), central.Handle, watch.Handle, isNew);
		}
		
		[CompilerGenerated]
		public static void WatchDidDisconnect (this IPBPebbleCentralDelegate This, PBPebbleCentral central, PBWatch watch)
		{
			if (central == null)
				throw new ArgumentNullException ("central");
			if (watch == null)
				throw new ArgumentNullException ("watch");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pebbleCentral:watchDidDisconnect:"), central.Handle, watch.Handle);
		}
		
	}
	
	internal sealed class PBPebbleCentralDelegateWrapper : BaseWrapper, IPBPebbleCentralDelegate {
		public PBPebbleCentralDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBPebbleCentralDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBPebbleCentralDelegate", true)]
	[Model]
	public unsafe partial class PBPebbleCentralDelegate : NSObject, IPBPebbleCentralDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBPebbleCentralDelegate () : base (NSObjectFlag.Empty)
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
		protected PBPebbleCentralDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBPebbleCentralDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("pebbleCentral:watchDidConnect:isNew:")]
		[CompilerGenerated]
		public virtual void WatchDidConnect (PBPebbleCentral central, PBWatch watch, bool isNew)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("pebbleCentral:watchDidDisconnect:")]
		[CompilerGenerated]
		public virtual void WatchDidDisconnect (PBPebbleCentral central, PBWatch watch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PBPebbleCentralDelegate */
}
