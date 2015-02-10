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
	[Register("PBWatch", true)]
	public unsafe partial class PBWatch : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBWatch");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
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
			if (onDone == null)
				throw new ArgumentNullException ("onDone");
			BlockLiteral *block_ptr_onDone;
			BlockLiteral block_onDone;
			block_onDone = new BlockLiteral ();
			block_ptr_onDone = &block_onDone;
			block_onDone.SetupBlock (Trampolines.SDAction.Handler, onDone);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("closeSession:"), (IntPtr) block_ptr_onDone);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("closeSession:"), (IntPtr) block_ptr_onDone);
			}
			block_ptr_onDone->CleanupBlock ();
			
		}
		
		[Export ("friendlyDescription")]
		[CompilerGenerated]
		public virtual string FriendlyDescription ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("friendlyDescription")));
			} else {
				return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("friendlyDescription")));
			}
		}
		
		[CompilerGenerated]
		public virtual bool Connected {
			[Export ("isConnected")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isConnected"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isConnected"));
				}
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
		object __mt_LastConnectedDate_var;
		[CompilerGenerated]
		public virtual NSDate LastConnectedDate {
			[Export ("lastConnectedDate")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastConnectedDate")));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastConnectedDate")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LastConnectedDate_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("name")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("name")));
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
		object __mt_UserInfo_var;
		[CompilerGenerated]
		public virtual NSObject UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInfo")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userInfo")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = ret;
				return ret;
			}
			
			[Export ("setUserInfo:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInfo:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserInfo:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_VersionInfo_var;
		[CompilerGenerated]
		public virtual PBVersionInfo VersionInfo {
			[Export ("versionInfo")]
			get {
				PBVersionInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PBVersionInfo> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("versionInfo")));
				} else {
					ret =  Runtime.GetNSObject<PBVersionInfo> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("versionInfo")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_VersionInfo_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_LastConnectedDate_var = null;
				__mt_UserInfo_var = null;
				__mt_VersionInfo_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class PBWatch */
}
