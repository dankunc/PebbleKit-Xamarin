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
	public unsafe static partial class Version  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::PebbleKitAll.PBWatch");
		
		[Export ("getVersionInfo:onTimeout:")]
		[CompilerGenerated]
		public unsafe static void GetVersionInfo (this PBWatch This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<PBWatch, PBVersionInfo> handler, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<PBWatch> onTimeout)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			if (onTimeout == null)
				throw new ArgumentNullException ("onTimeout");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlock (Trampolines.SDActionArity2V1.Handler, handler);
			BlockLiteral *block_ptr_onTimeout;
			BlockLiteral block_onTimeout;
			block_onTimeout = new BlockLiteral ();
			block_ptr_onTimeout = &block_onTimeout;
			block_onTimeout.SetupBlock (Trampolines.SDActionArity1V0.Handler, onTimeout);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getVersionInfo:onTimeout:"), (IntPtr) block_ptr_handler, (IntPtr) block_ptr_onTimeout);
			block_ptr_handler->CleanupBlock ();
			block_ptr_onTimeout->CleanupBlock ();
			
		}
		
	} /* class Version */
}
