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
	[Protocol (Name = "PBWatchDelegate", WrapperType = typeof (PBWatchDelegateWrapper))]
	public interface IPBWatchDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class PBWatchDelegate_Extensions {
		[CompilerGenerated]
		public static void WatchDidDisconnect (this IPBWatchDelegate This, PBWatch watch)
		{
			if (watch == null)
				throw new ArgumentNullException ("watch");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("watchDidDisconnect:"), watch.Handle);
		}
		
		[CompilerGenerated]
		public static void HandleError (this IPBWatchDelegate This, PBWatch watch, NSError error)
		{
			if (watch == null)
				throw new ArgumentNullException ("watch");
			if (error == null)
				throw new ArgumentNullException ("error");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("watch:handleError:"), watch.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void WatchWillResetSession (this IPBWatchDelegate This, PBWatch watch)
		{
			if (watch == null)
				throw new ArgumentNullException ("watch");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("watchWillResetSession:"), watch.Handle);
		}
		
		[CompilerGenerated]
		public static void WatchDidOpenSession (this IPBWatchDelegate This, PBWatch watch)
		{
			if (watch == null)
				throw new ArgumentNullException ("watch");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("watchDidOpenSession:"), watch.Handle);
		}
		
		[CompilerGenerated]
		public static void WatchDidCloseSession (this IPBWatchDelegate This, PBWatch watch)
		{
			if (watch == null)
				throw new ArgumentNullException ("watch");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("watchDidCloseSession:"), watch.Handle);
		}
		
	}
	
	internal sealed class PBWatchDelegateWrapper : BaseWrapper, IPBWatchDelegate {
		public PBWatchDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBWatchDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBWatchDelegate", true)]
	[Model]
	public unsafe partial class PBWatchDelegate : NSObject, IPBWatchDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBWatchDelegate () : base (NSObjectFlag.Empty)
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
		protected PBWatchDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBWatchDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("watch:handleError:")]
		[CompilerGenerated]
		public virtual void HandleError (PBWatch watch, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("watchDidCloseSession:")]
		[CompilerGenerated]
		public virtual void WatchDidCloseSession (PBWatch watch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("watchDidDisconnect:")]
		[CompilerGenerated]
		public virtual void WatchDidDisconnect (PBWatch watch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("watchDidOpenSession:")]
		[CompilerGenerated]
		public virtual void WatchDidOpenSession (PBWatch watch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("watchWillResetSession:")]
		[CompilerGenerated]
		public virtual void WatchWillResetSession (PBWatch watch)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class PBWatchDelegate */
}
