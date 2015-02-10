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
	public unsafe static partial class Ping  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::PebbleKitAll.PBWatch");
		
		[Export ("pingWithCookie:onPong:onTimeout:")]
		[CompilerGenerated]
		public unsafe static void PingWithCookie (this PBWatch This, global::System.nuint cookie, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<PBWatch, global::System.nuint> onPong, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<PBWatch, global::System.nuint> onTimeout)
		{
			if (onPong == null)
				throw new ArgumentNullException ("onPong");
			if (onTimeout == null)
				throw new ArgumentNullException ("onTimeout");
			BlockLiteral *block_ptr_onPong;
			BlockLiteral block_onPong;
			block_onPong = new BlockLiteral ();
			block_ptr_onPong = &block_onPong;
			block_onPong.SetupBlock (Trampolines.SDActionArity2V0.Handler, onPong);
			BlockLiteral *block_ptr_onTimeout;
			BlockLiteral block_onTimeout;
			block_onTimeout = new BlockLiteral ();
			block_ptr_onTimeout = &block_onTimeout;
			block_onTimeout.SetupBlock (Trampolines.SDActionArity2V0.Handler, onTimeout);
			
			ApiDefinition.Messaging.void_objc_msgSend_nuint_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pingWithCookie:onPong:onTimeout:"), cookie, (IntPtr) block_ptr_onPong, (IntPtr) block_ptr_onTimeout);
			block_ptr_onPong->CleanupBlock ();
			block_ptr_onTimeout->CleanupBlock ();
			
		}
		
	} /* class Ping */
}
