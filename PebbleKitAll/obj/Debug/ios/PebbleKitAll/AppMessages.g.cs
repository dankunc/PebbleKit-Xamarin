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
	public unsafe static partial class AppMessages  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::PebbleKitAll.PBWatch");
		
		[Export ("appMessagesAddReceiveUpdateHandler:")]
		[CompilerGenerated]
		public unsafe static NSObject AppMessagesAddReceiveUpdateHandler (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity3V0))]global::System.Func<PBWatch, NSDictionary, global::System.SByte> onReceive)
		{
			if (onReceive == null)
				throw new ArgumentNullException ("onReceive");
			BlockLiteral *block_ptr_onReceive;
			BlockLiteral block_onReceive;
			block_onReceive = new BlockLiteral ();
			block_ptr_onReceive = &block_onReceive;
			block_onReceive.SetupBlock (Trampolines.SDFuncArity3V0.Handler, onReceive);
			
			NSObject ret;
			ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("appMessagesAddReceiveUpdateHandler:"), (IntPtr) block_ptr_onReceive));
			block_ptr_onReceive->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("appMessagesAddReceiveUpdateHandler:withUUID:")]
		[CompilerGenerated]
		public unsafe static NSObject AppMessagesAddReceiveUpdateHandler (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity3V0))]global::System.Func<PBWatch, NSDictionary, global::System.SByte> onReceive, NSData uuid)
		{
			if (onReceive == null)
				throw new ArgumentNullException ("onReceive");
			if (uuid == null)
				throw new ArgumentNullException ("uuid");
			BlockLiteral *block_ptr_onReceive;
			BlockLiteral block_onReceive;
			block_onReceive = new BlockLiteral ();
			block_ptr_onReceive = &block_onReceive;
			block_onReceive.SetupBlock (Trampolines.SDFuncArity3V0.Handler, onReceive);
			
			NSObject ret;
			ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("appMessagesAddReceiveUpdateHandler:withUUID:"), (IntPtr) block_ptr_onReceive, uuid.Handle));
			block_ptr_onReceive->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("appMessagesGetIsSupported:")]
		[CompilerGenerated]
		public unsafe static void AppMessagesGetIsSupported (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<PBWatch, global::System.SByte> fetchedBlock)
		{
			if (fetchedBlock == null)
				throw new ArgumentNullException ("fetchedBlock");
			BlockLiteral *block_ptr_fetchedBlock;
			BlockLiteral block_fetchedBlock;
			block_fetchedBlock = new BlockLiteral ();
			block_ptr_fetchedBlock = &block_fetchedBlock;
			block_fetchedBlock.SetupBlock (Trampolines.SDActionArity2V2.Handler, fetchedBlock);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("appMessagesGetIsSupported:"), (IntPtr) block_ptr_fetchedBlock);
			block_ptr_fetchedBlock->CleanupBlock ();
			
		}
		
		[Export ("appMessagesKill:")]
		[CompilerGenerated]
		public unsafe static void AppMessagesKill (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("appMessagesKill:"), (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("appMessagesKill:withUUID:")]
		[CompilerGenerated]
		public unsafe static void AppMessagesKill (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent, NSData uuid)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			if (uuid == null)
				throw new ArgumentNullException ("uuid");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("appMessagesKill:withUUID:"), (IntPtr) block_ptr_onSent, uuid.Handle);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("appMessagesLaunch:")]
		[CompilerGenerated]
		public unsafe static void AppMessagesLaunch (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("appMessagesLaunch:"), (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("appMessagesLaunch:withUUID:")]
		[CompilerGenerated]
		public unsafe static void AppMessagesLaunch (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<PBWatch, NSError> onSent, NSData uuid)
		{
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			if (uuid == null)
				throw new ArgumentNullException ("uuid");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity2V3.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("appMessagesLaunch:withUUID:"), (IntPtr) block_ptr_onSent, uuid.Handle);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("appMessagesPushUpdate:onSent:")]
		[CompilerGenerated]
		public unsafe static void AppMessagesPushUpdate (this PBWatch This, NSDictionary dictionary, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<PBWatch, NSDictionary, NSError> onSent)
		{
			if (dictionary == null)
				throw new ArgumentNullException ("dictionary");
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity3V0.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("appMessagesPushUpdate:onSent:"), dictionary.Handle, (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("appMessagesPushUpdate:withUUID:onSent:")]
		[CompilerGenerated]
		public unsafe static void AppMessagesPushUpdate (this PBWatch This, NSDictionary dictionary, NSData uuid, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<PBWatch, NSDictionary, NSError> onSent)
		{
			if (dictionary == null)
				throw new ArgumentNullException ("dictionary");
			if (uuid == null)
				throw new ArgumentNullException ("uuid");
			if (onSent == null)
				throw new ArgumentNullException ("onSent");
			BlockLiteral *block_ptr_onSent;
			BlockLiteral block_onSent;
			block_onSent = new BlockLiteral ();
			block_ptr_onSent = &block_onSent;
			block_onSent.SetupBlock (Trampolines.SDActionArity3V0.Handler, onSent);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("appMessagesPushUpdate:withUUID:onSent:"), dictionary.Handle, uuid.Handle, (IntPtr) block_ptr_onSent);
			block_ptr_onSent->CleanupBlock ();
			
		}
		
		[Export ("appMessagesRemoveUpdateHandler:")]
		[CompilerGenerated]
		public static void AppMessagesRemoveUpdateHandler (this PBWatch This, NSObject opaqueHandle)
		{
			if (opaqueHandle == null)
				throw new ArgumentNullException ("opaqueHandle");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("appMessagesRemoveUpdateHandler:"), opaqueHandle.Handle);
		}
		
	} /* class AppMessages */
}
