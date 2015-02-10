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
	public unsafe static partial class Golf  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::PebbleKitAll.PBWatch");
		
		[Export ("golfAppAddReceiveUpdateHandler:")]
		[CompilerGenerated]
		public unsafe static NSObject GolfAppAddReceiveUpdateHandler (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity3V2))]global::System.Func<PBWatch, GolfAppCommand, bool> onReceive)
		{
			if (onReceive == null)
				throw new ArgumentNullException ("onReceive");
			BlockLiteral *block_ptr_onReceive;
			BlockLiteral block_onReceive;
			block_onReceive = new BlockLiteral ();
			block_ptr_onReceive = &block_onReceive;
			block_onReceive.SetupBlock (Trampolines.SDFuncArity3V2.Handler, onReceive);
			
			NSObject ret;
			ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("golfAppAddReceiveUpdateHandler:"), (IntPtr) block_ptr_onReceive));
			block_ptr_onReceive->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("golfAppKill:")]
		[CompilerGenerated]
		public unsafe static void GolfAppKill (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("golfAppKill:"), (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("golfAppLaunch:")]
		[CompilerGenerated]
		public unsafe static void GolfAppLaunch (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("golfAppLaunch:"), (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("golfAppRemoveUpdateHandler:")]
		[CompilerGenerated]
		public static void GolfAppRemoveUpdateHandler (this PBWatch This, NSObject opaqueHandle)
		{
			if (opaqueHandle == null)
				throw new ArgumentNullException ("opaqueHandle");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("golfAppRemoveUpdateHandler:"), opaqueHandle.Handle);
		}
		
		[Export ("golfAppUpdate:onSent:")]
		[CompilerGenerated]
		public unsafe static void GolfAppUpdate (this PBWatch This, NSDictionary update, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
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
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("golfAppUpdate:onSent:"), update.Handle, (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("golfGetIsSupported:")]
		[CompilerGenerated]
		public unsafe static void GolfGetIsSupported (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V4))]global::System.Action<PBWatch, global::System.SByte> fetchedBlock)
		{
			if (fetchedBlock == null)
				throw new ArgumentNullException ("fetchedBlock");
			BlockLiteral *block_ptr_fetchedBlock;
			BlockLiteral block_fetchedBlock;
			block_fetchedBlock = new BlockLiteral ();
			block_ptr_fetchedBlock = &block_fetchedBlock;
			block_fetchedBlock.SetupBlock (Trampolines.SDActionArity2V4.Handler, fetchedBlock);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("golfGetIsSupported:"), (IntPtr) block_ptr_fetchedBlock);
			block_ptr_fetchedBlock->CleanupBlock ();
			
		}
		
		[Export ("golfSetTitle:icon:onSent:")]
		[CompilerGenerated]
		public unsafe static void GolfSetTitle (this PBWatch This, string title, global::UIKit.UIImage icon, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
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
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("golfSetTitle:icon:onSent:"), nstitle, icon.Handle, (IntPtr) block_ptr_onSent);
			NSString.ReleaseNative (nstitle);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
	} /* class Golf */
}
