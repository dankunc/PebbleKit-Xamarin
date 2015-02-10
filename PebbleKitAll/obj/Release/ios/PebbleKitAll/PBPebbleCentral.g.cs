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
	[Protocol (Name = "PBPebbleCentral", WrapperType = typeof (PBPebbleCentralWrapper))]
	public interface IPBPebbleCentral : INativeObject, IDisposable
	{
	}
	
	public static partial class PBPebbleCentral_Extensions {
		[CompilerGenerated]
		public static bool HasValidAppUUID (this IPBPebbleCentral This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasValidAppUUID"));
		}
		
		[CompilerGenerated]
		public static bool IsMobileAppInstalled (this IPBPebbleCentral This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMobileAppInstalled"));
		}
		
		[CompilerGenerated]
		public static void InstallMobileApp (this IPBPebbleCentral This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("installMobileApp"));
		}
		
		[CompilerGenerated]
		public static void UnregisterAllWatches (this IPBPebbleCentral This)
		{
			ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("unregisterAllWatches"));
		}
		
		[CompilerGenerated]
		public static PBWatch LastConnectedWatch (this IPBPebbleCentral This)
		{
			return  Runtime.GetNSObject<PBWatch> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("lastConnectedWatch")));
		}
		
		[CompilerGenerated]
		public static NSObject[] GetConnectedWatches (this IPBPebbleCentral This)
		{
			return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("connectedWatches")));
		}
		
		[CompilerGenerated]
		public static NSObject[] GetRegisteredWatches (this IPBPebbleCentral This)
		{
			return NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("registeredWatches")));
		}
		
		[CompilerGenerated]
		public static NSObject GetWeakDelegate (this IPBPebbleCentral This)
		{
			return Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("delegate")));
		}
		
		[CompilerGenerated]
		public static void SetWeakDelegate (this IPBPebbleCentral This, NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDelegate:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static NSData GetAppUUID (this IPBPebbleCentral This)
		{
			return  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("appUUID")));
		}
		
		[CompilerGenerated]
		public static void SetAppUUID (this IPBPebbleCentral This, NSData value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAppUUID:"), value.Handle);
		}
		
		[CompilerGenerated]
		public static PBDataLoggingService GetDataLoggingService (this IPBPebbleCentral This)
		{
			return  Runtime.GetNSObject<PBDataLoggingService> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dataLoggingService")));
		}
		
	}
	
	internal sealed class PBPebbleCentralWrapper : BaseWrapper, IPBPebbleCentral {
		public PBPebbleCentralWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBPebbleCentralWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBPebbleCentral", true)]
	public unsafe partial class PBPebbleCentral : NSObject, IPBPebbleCentral {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("PBPebbleCentral");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBPebbleCentral () : base (NSObjectFlag.Empty)
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
		protected PBPebbleCentral (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBPebbleCentral (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addLumberjackLoggers")]
		[CompilerGenerated]
		public static void AddLumberjackLoggers ()
		{
			ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("addLumberjackLoggers"));
		}
		
		[Export ("defaultCentral")]
		[CompilerGenerated]
		public static PBPebbleCentral DefaultCentral ()
		{
			return  Runtime.GetNSObject<PBPebbleCentral> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("defaultCentral")));
		}
		
		[Export ("hasValidAppUUID")]
		[CompilerGenerated]
		public virtual bool HasValidAppUUID ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasValidAppUUID"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasValidAppUUID"));
			}
		}
		
		[Export ("installMobileApp")]
		[CompilerGenerated]
		public virtual void InstallMobileApp ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("installMobileApp"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("installMobileApp"));
			}
		}
		
		[Export ("isMobileAppInstalled")]
		[CompilerGenerated]
		public virtual bool IsMobileAppInstalled ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMobileAppInstalled"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMobileAppInstalled"));
			}
		}
		
		[Export ("lastConnectedWatch")]
		[CompilerGenerated]
		public virtual PBWatch LastConnectedWatch ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<PBWatch> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastConnectedWatch")));
			} else {
				return  Runtime.GetNSObject<PBWatch> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastConnectedWatch")));
			}
		}
		
		[Export ("setDebugLogsEnabled:")]
		[CompilerGenerated]
		public static void SetDebugLogsEnabled (bool logsEnabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setDebugLogsEnabled:"), logsEnabled);
		}
		
		[Export ("unregisterAllWatches")]
		[CompilerGenerated]
		public virtual void UnregisterAllWatches ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("unregisterAllWatches"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unregisterAllWatches"));
			}
		}
		
		[CompilerGenerated]
		object __mt_AppUUID_var;
		[CompilerGenerated]
		public virtual NSData AppUUID {
			[Export ("appUUID", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("appUUID")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appUUID")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AppUUID_var = ret;
				return ret;
			}
			
			[Export ("setAppUUID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAppUUID:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAppUUID:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AppUUID_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ConnectedWatches_var;
		[CompilerGenerated]
		public virtual NSObject[] ConnectedWatches {
			[Export ("connectedWatches", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("connectedWatches")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectedWatches")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ConnectedWatches_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_DataLoggingService_var;
		[CompilerGenerated]
		public virtual PBDataLoggingService DataLoggingService {
			[Export ("dataLoggingService")]
			get {
				PBDataLoggingService ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PBDataLoggingService> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataLoggingService")));
				} else {
					ret =  Runtime.GetNSObject<PBDataLoggingService> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataLoggingService")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DataLoggingService_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public PBPebbleCentralDelegate Delegate {
			get {
				return WeakDelegate as /**/PBPebbleCentralDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_RegisteredWatches_var;
		[CompilerGenerated]
		public virtual NSObject[] RegisteredWatches {
			[Export ("registeredWatches", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("registeredWatches")));
				} else {
					ret = NSArray.ArrayFromHandle<Foundation.NSObject>(ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("registeredWatches")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RegisteredWatches_var = ret;
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
				__mt_AppUUID_var = null;
				__mt_ConnectedWatches_var = null;
				__mt_DataLoggingService_var = null;
				__mt_RegisteredWatches_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class PBPebbleCentral */
}
