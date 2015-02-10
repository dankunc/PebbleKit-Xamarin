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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, global::System.nuint arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, global::System.nuint arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PebbleKitAll.PBWatch, global::System.nuint>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1), arg2);
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PebbleKitAll.PBWatch, global::System.nuint> Create (IntPtr block)
			{
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PebbleKitAll.PBWatch arg1, global::System.nuint arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V1 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V1 {
			static internal readonly DActionArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V1))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PebbleKitAll.PBWatch, global::PebbleKitAll.PBVersionInfo>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1),  Runtime.GetNSObject<PebbleKitAll.PBVersionInfo> (arg2));
			}
		} /* class SDActionArity2V1 */
		
		internal class NIDActionArity2V1 {
			IntPtr blockPtr;
			DActionArity2V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PebbleKitAll.PBWatch, global::PebbleKitAll.PBVersionInfo> Create (IntPtr block)
			{
				return new NIDActionArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PebbleKitAll.PBWatch arg1, global::PebbleKitAll.PBVersionInfo arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PebbleKitAll.PBWatch>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PebbleKitAll.PBWatch> Create (IntPtr block)
			{
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PebbleKitAll.PBWatch obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate SByte DFuncArity3V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity3V0 {
			static internal readonly DFuncArity3V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity3V0))]
			static unsafe SByte Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::PebbleKitAll.PBWatch, NSDictionary, global::System.SByte>) (descriptor->Target);
				System.SByte retval = del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1),  Runtime.GetNSObject<Foundation.NSDictionary> (arg2));
				return retval;
			}
		} /* class SDFuncArity3V0 */
		
		internal class NIDFuncArity3V0 {
			IntPtr blockPtr;
			DFuncArity3V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity3V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity3V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity3V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<global::PebbleKitAll.PBWatch, NSDictionary, global::System.SByte> Create (IntPtr block)
			{
				return new NIDFuncArity3V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe global::System.SByte Invoke (global::PebbleKitAll.PBWatch arg1, NSDictionary arg2)
			{
				var ret = invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
				return ret;
			}
		} /* class NIDFuncArity3V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V2 (IntPtr block, IntPtr arg1, global::System.SByte arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V2 {
			static internal readonly DActionArity2V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V2))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, global::System.SByte arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PebbleKitAll.PBWatch, global::System.SByte>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1), arg2);
			}
		} /* class SDActionArity2V2 */
		
		internal class NIDActionArity2V2 {
			IntPtr blockPtr;
			DActionArity2V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PebbleKitAll.PBWatch, global::System.SByte> Create (IntPtr block)
			{
				return new NIDActionArity2V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PebbleKitAll.PBWatch arg1, global::System.SByte arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2);
			}
		} /* class NIDActionArity2V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V3 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V3 {
			static internal readonly DActionArity2V3 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V3))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PebbleKitAll.PBWatch, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1),  Runtime.GetNSObject<Foundation.NSError> (arg2));
			}
		} /* class SDActionArity2V3 */
		
		internal class NIDActionArity2V3 {
			IntPtr blockPtr;
			DActionArity2V3 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V3 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V3> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V3 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PebbleKitAll.PBWatch, NSError> Create (IntPtr block)
			{
				return new NIDActionArity2V3 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PebbleKitAll.PBWatch arg1, NSError arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V3 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity3V0 (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			static internal readonly DActionArity3V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::PebbleKitAll.PBWatch, NSDictionary, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1),  Runtime.GetNSObject<Foundation.NSDictionary> (arg2),  Runtime.GetNSObject<Foundation.NSError> (arg3));
			}
		} /* class SDActionArity3V0 */
		
		internal class NIDActionArity3V0 {
			IntPtr blockPtr;
			DActionArity3V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity3V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity3V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity3V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::PebbleKitAll.PBWatch, NSDictionary, NSError> Create (IntPtr block)
			{
				return new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::PebbleKitAll.PBWatch arg1, NSDictionary arg2, NSError arg3)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle, arg3 == null ? IntPtr.Zero : arg3.Handle);
			}
		} /* class NIDActionArity3V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate bool DFuncArity3V1 (IntPtr block, IntPtr arg1, global::PebbleKitAll.SportsAppActivityState arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity3V1 {
			static internal readonly DFuncArity3V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity3V1))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg1, global::PebbleKitAll.SportsAppActivityState arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::PebbleKitAll.PBWatch, global::PebbleKitAll.SportsAppActivityState, bool>) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1), arg2);
				return retval;
			}
		} /* class SDFuncArity3V1 */
		
		internal class NIDFuncArity3V1 {
			IntPtr blockPtr;
			DFuncArity3V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity3V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity3V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity3V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<global::PebbleKitAll.PBWatch, global::PebbleKitAll.SportsAppActivityState, bool> Create (IntPtr block)
			{
				return new NIDFuncArity3V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe bool Invoke (global::PebbleKitAll.PBWatch arg1, global::PebbleKitAll.SportsAppActivityState arg2)
			{
				var ret = invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2);
				return ret;
			}
		} /* class NIDFuncArity3V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate bool DFuncArity3V2 (IntPtr block, IntPtr arg1, global::PebbleKitAll.GolfAppCommand arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity3V2 {
			static internal readonly DFuncArity3V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity3V2))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg1, global::PebbleKitAll.GolfAppCommand arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::PebbleKitAll.PBWatch, global::PebbleKitAll.GolfAppCommand, bool>) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<PebbleKitAll.PBWatch> (arg1), arg2);
				return retval;
			}
		} /* class SDFuncArity3V2 */
		
		internal class NIDFuncArity3V2 {
			IntPtr blockPtr;
			DFuncArity3V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDFuncArity3V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DFuncArity3V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDFuncArity3V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Func<global::PebbleKitAll.PBWatch, global::PebbleKitAll.GolfAppCommand, bool> Create (IntPtr block)
			{
				return new NIDFuncArity3V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe bool Invoke (global::PebbleKitAll.PBWatch arg1, global::PebbleKitAll.GolfAppCommand arg2)
			{
				var ret = invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2);
				return ret;
			}
		} /* class NIDFuncArity3V2 */
	}
}
