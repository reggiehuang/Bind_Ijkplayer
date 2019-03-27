using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='ISurfaceTextureHost']"
	[Register ("tv/danmaku/ijk/media/player/ISurfaceTextureHost", "", "TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHostInvoker")]
	public partial interface ISurfaceTextureHost : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='ISurfaceTextureHost']/method[@name='releaseSurfaceTexture' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("releaseSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V", "GetReleaseSurfaceTexture_Landroid_graphics_SurfaceTexture_Handler:TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHostInvoker, Binding_IjkplayerJava")]
		void ReleaseSurfaceTexture (global::Android.Graphics.SurfaceTexture p0);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/ISurfaceTextureHost", DoNotGenerateAcw=true)]
	internal class ISurfaceTextureHostInvoker : global::Java.Lang.Object, ISurfaceTextureHost {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/ISurfaceTextureHost");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISurfaceTextureHostInvoker); }
		}

		IntPtr class_ref;

		public static ISurfaceTextureHost GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurfaceTextureHost> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.ISurfaceTextureHost"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurfaceTextureHostInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetReleaseSurfaceTexture_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_ == null)
				cb_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseSurfaceTexture_Landroid_graphics_SurfaceTexture_);
			return cb_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_;
		}

		static void n_ReleaseSurfaceTexture_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSurfaceTexture (p0);
		}
#pragma warning restore 0169

		IntPtr id_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_;
		public unsafe void ReleaseSurfaceTexture (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "releaseSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseSurfaceTexture_Landroid_graphics_SurfaceTexture_, __args);
		}

	}

}
