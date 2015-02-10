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
	public unsafe static partial class Sports  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::PebbleKitAll.PBWatch");
		
		[Export ("sportsAppAddReceiveUpdateHandler:")]
		[CompilerGenerated]
		public unsafe static NSObject SportsAppAddReceiveUpdateHandler (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity3V1))]global::System.Func<PBWatch, SportsAppActivityState, bool> onReceive)
		{
			if (onReceive == null)
				throw new ArgumentNullException ("onReceive");
			BlockLiteral *block_ptr_onReceive;
			BlockLiteral block_onReceive;
			block_onReceive = new BlockLiteral ();
			block_ptr_onReceive = &block_onReceive;
			block_onReceive.SetupBlock (Trampolines.SDFuncArity3V1.Handler, onReceive);
			
			NSObject ret;
			ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sportsAppAddReceiveUpdateHandler:"), (IntPtr) block_ptr_onReceive));
			block_ptr_onReceive->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("sportsAppKill:")]
		[CompilerGenerated]
		public unsafe static void SportsAppKill (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sportsAppKill:"), (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("sportsAppLaunch:")]
		[CompilerGenerated]
		public unsafe static void SportsAppLaunch (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sportsAppLaunch:"), (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("sportsAppRemoveUpdateHandler:")]
		[CompilerGenerated]
		public static void SportsAppRemoveUpdateHandler (this PBWatch This, NSObject opaqueHandle)
		{
			if (opaqueHandle == null)
				throw new ArgumentNullException ("opaqueHandle");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sportsAppRemoveUpdateHandler:"), opaqueHandle.Handle);
		}
		
		[Export ("sportsAppSetActivityState:onSent:")]
		[CompilerGenerated]
		public unsafe static void SportsAppSetActivityState (this PBWatch This, SportsAppActivityState state, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_UInt32_IntPtr (This.Handle, Selector.GetHandle ("sportsAppSetActivityState:onSent:"), (UInt32)state, (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("sportsAppSetLabel:onSent:")]
		[CompilerGenerated]
		public unsafe static void SportsAppSetLabel (this PBWatch This, bool isPace, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("sportsAppSetLabel:onSent:"), isPace, (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("sportsAppSetMetric:onSent:")]
		[CompilerGenerated]
		public unsafe static void SportsAppSetMetric (this PBWatch This, bool isMetric, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("sportsAppSetMetric:onSent:"), isMetric, (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("sportsAppUpdate:onSent:")]
		[CompilerGenerated]
		public unsafe static void SportsAppUpdate (this PBWatch This, NSDictionary update, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (update == null)
				throw new ArgumentNullException ("update");
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("sportsAppUpdate:onSent:"), update.Handle, (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("sportsGetIsSupported:")]
		[CompilerGenerated]
		public unsafe static void SportsGetIsSupported (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<PBWatch, global::System.SByte> fetchedBlock)
		{
			if (fetchedBlock == null)
				throw new ArgumentNullException ("fetchedBlock");
			BlockLiteral *block_ptr_fetchedBlock;
			BlockLiteral block_fetchedBlock;
			block_fetchedBlock = new BlockLiteral ();
			block_ptr_fetchedBlock = &block_fetchedBlock;
			block_fetchedBlock.SetupBlock (Trampolines.SDActionArity2V2.Handler, fetchedBlock);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("sportsGetIsSupported:"), (IntPtr) block_ptr_fetchedBlock);
			block_ptr_fetchedBlock->CleanupBlock ();
			
		}
		
		[Export ("sportsSetTitle:icon:onSent:")]
		[CompilerGenerated]
		public unsafe static void SportsSetTitle (this PBWatch This, string title, global::UIKit.UIImage icon, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (icon == null)
				throw new ArgumentNullException ("icon");
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			var nstitle = NSString.CreateNative (title);
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("sportsSetTitle:icon:onSent:"), nstitle, icon.Handle, (IntPtr) block_ptr_onSent);
			NSString.ReleaseNative (nstitle);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
	} /* class Sports */
}
