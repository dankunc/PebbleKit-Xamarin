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
	[Protocol (Name = "PBWatch", WrapperType = typeof (PBWatchWrapper))]
	public interface IPBWatch : INativeObject, IDisposable
	{
	}
	
	public static partial class PBWatch_Extensions {
		[CompilerGenerated]
		public static string FriendlyDescription (this IPBWatch This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("friendlyDescription")));
		}
		
		[CompilerGenerated]
		public unsafe static void CloseSession (this IPBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onDone)
		{
			if (onDone == null)
				throw new ArgumentNullException ("onDone");
			BlockLiteral *block_ptr_onDone;
			BlockLiteral block_onDone;
			block_onDone = new BlockLiteral ();
			block_ptr_onDone = &block_onDone;
			block_onDone.SetupBlock (Trampolines.SDAction.Handler, onDone);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("closeSession:"), (IntPtr) block_ptr_onDone);
			block_ptr_onDone->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public static bool GetConnected (this IPBWatch This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("connected"));
		}
		
		[CompilerGenerated]
		public static string GetName (this IPBWatch This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("name")));
		}
		
		[CompilerGenerated]
		public static string GetSerialNumber (this IPBWatch This)
		{
			return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("serialNumber")));
		}
		
		[CompilerGenerated]
		public static PBVersionInfo GetVersionInfo (this IPBWatch This)
		{
			return  Runtime.GetNSObject<PBVersionInfo> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("versionInfo")));
		}
		
		[CompilerGenerated]
		public static NSObject GetWeakDelegate (this IPBWatch This)
		{
			return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[CompilerGenerated]
		public static void SetWeakDelegate (this IPBWatch This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static NSObject GetUserInfo (this IPBWatch This)
		{
			return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("userInfo")));
		}
		
		[CompilerGenerated]
		public static void SetUserInfo (this IPBWatch This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setUserInfo:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static NSDate GetLastConnectedDate (this IPBWatch This)
		{
			return  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("lastConnectedDate")));
		}
		
	}
	
	internal sealed class PBWatchWrapper : BaseWrapper, IPBWatch {
		public PBWatchWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBWatchWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBWatch", true)]
	[Model]
	public unsafe partial class PBWatch : NSObject, IPBWatch {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBWatch () : base (NSObjectFlag.Empty)
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
		protected PBWatch (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBWatch (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("closeSession:")]
		[CompilerGenerated]
		public unsafe virtual void CloseSession ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action onDone)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("friendlyDescription")]
		[CompilerGenerated]
		public virtual string FriendlyDescription ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual bool Connected {
			[Export ("isConnected")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public PBWatchDelegate Delegate {
			get {
				return WeakDelegate as /**/PBWatchDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual NSDate LastConnectedDate {
			[Export ("lastConnectedDate")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name")]
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
		public virtual NSObject UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setUserInfo:", ArgumentSemantic.Retain)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual PBVersionInfo VersionInfo {
			[Export ("versionInfo")]
			get {
				throw new ModelNotImplementedException ();
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
		
	} /* class PBWatch */
}
