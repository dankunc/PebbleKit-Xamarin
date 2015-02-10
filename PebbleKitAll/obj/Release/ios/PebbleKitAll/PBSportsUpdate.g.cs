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
	[Protocol (Name = "PBSportsUpdate", WrapperType = typeof (PBSportsUpdateWrapper))]
	public interface IPBSportsUpdate : INativeObject, IDisposable
	{
	}
	
	public static partial class PBSportsUpdate_Extensions {
		[CompilerGenerated]
		public static NSDictionary Dictionary (this IPBSportsUpdate This)
		{
			return  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("dictionary")));
		}
		
		[CompilerGenerated]
		public static global::System.Double GetTime (this IPBSportsUpdate This)
		{
			return ApiDefinition.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("time"));
		}
		
		[CompilerGenerated]
		public static void SetTime (this IPBSportsUpdate This, global::System.Double value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setTime:"), value);
		}
		
		[CompilerGenerated]
		public static float GetDistance (this IPBSportsUpdate This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("distance"));
		}
		
		[CompilerGenerated]
		public static void SetDistance (this IPBSportsUpdate This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setDistance:"), value);
		}
		
		[CompilerGenerated]
		public static float GetData (this IPBSportsUpdate This)
		{
			return ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("data"));
		}
		
		[CompilerGenerated]
		public static void SetData (this IPBSportsUpdate This, float value)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setData:"), value);
		}
		
	}
	
	internal sealed class PBSportsUpdateWrapper : BaseWrapper, IPBSportsUpdate {
		public PBSportsUpdateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public PBSportsUpdateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace PebbleKitAll {
	[Protocol]
	[Register("PBSportsUpdate", true)]
	[Model]
	public unsafe partial class PBSportsUpdate : NSObject, IPBSportsUpdate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PBSportsUpdate () : base (NSObjectFlag.Empty)
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
		protected PBSportsUpdate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PBSportsUpdate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dictionary")]
		[CompilerGenerated]
		public virtual NSDictionary Dictionary ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("timeStringFromFloat:")]
		[CompilerGenerated]
		public static string TimeStringFromFloat (float seconds)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("updateWithTime:distance:data:")]
		[CompilerGenerated]
		public static PBSportsUpdate UpdateWithTime (global::System.Double time, float distance, float data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual float Data {
			[Export ("data", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setData:", ArgumentSemantic.UnsafeUnretained)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual float Distance {
			[Export ("distance", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setDistance:", ArgumentSemantic.UnsafeUnretained)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Time {
			[Export ("time", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class PBSportsUpdate */
}
