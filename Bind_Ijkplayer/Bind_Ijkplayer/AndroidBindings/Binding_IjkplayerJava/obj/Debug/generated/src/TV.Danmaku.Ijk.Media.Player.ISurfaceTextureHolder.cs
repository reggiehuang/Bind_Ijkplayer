using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='ISurfaceTextureHolder']"
	[Register ("tv/danmaku/ijk/media/player/ISurfaceTextureHolder", "", "TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolderInvoker")]
	public partial interface ISurfaceTextureHolder : IJavaObject {

		global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='ISurfaceTextureHolder']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler:TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolderInvoker, Binding_IjkplayerJava")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='ISurfaceTextureHolder']/method[@name='setSurfaceTexture' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
			[Register ("setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V", "GetSetSurfaceTexture_Landroid_graphics_SurfaceTexture_Handler:TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolderInvoker, Binding_IjkplayerJava")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='ISurfaceTextureHolder']/method[@name='setSurfaceTextureHost' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.ISurfaceTextureHost']]"
		[Register ("setSurfaceTextureHost", "(Ltv/danmaku/ijk/media/player/ISurfaceTextureHost;)V", "GetSetSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_Handler:TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolderInvoker, Binding_IjkplayerJava")]
		void SetSurfaceTextureHost (global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost p0);

	}

	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/ISurfaceTextureHolder", DoNotGenerateAcw=true)]
	internal class ISurfaceTextureHolderInvoker : global::Java.Lang.Object, ISurfaceTextureHolder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/ISurfaceTextureHolder");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISurfaceTextureHolderInvoker); }
		}

		IntPtr class_ref;

		public static ISurfaceTextureHolder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISurfaceTextureHolder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.ISurfaceTextureHolder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISurfaceTextureHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSurfaceTexture;
#pragma warning disable 0169
		static Delegate GetGetSurfaceTextureHandler ()
		{
			if (cb_getSurfaceTexture == null)
				cb_getSurfaceTexture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurfaceTexture);
			return cb_getSurfaceTexture;
		}

		static IntPtr n_GetSurfaceTexture (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceTexture);
		}
#pragma warning restore 0169

		static Delegate cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetSetSurfaceTexture_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ == null)
				cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSurfaceTexture_Landroid_graphics_SurfaceTexture_);
			return cb_setSurfaceTexture_Landroid_graphics_SurfaceTexture_;
		}

		static void n_SetSurfaceTexture_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceTexture = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSurfaceTexture;
		IntPtr id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_;
		public unsafe global::Android.Graphics.SurfaceTexture SurfaceTexture {
			get {
				if (id_getSurfaceTexture == IntPtr.Zero)
					id_getSurfaceTexture = JNIEnv.GetMethodID (class_ref, "getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurfaceTexture), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
					id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_, __args);
			}
		}

		static Delegate cb_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_;
#pragma warning disable 0169
		static Delegate GetSetSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_Handler ()
		{
			if (cb_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_ == null)
				cb_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_);
			return cb_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_;
		}

		static void n_SetSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost p0 = (global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurfaceTextureHost (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_;
		public unsafe void SetSurfaceTextureHost (global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost p0)
		{
			if (id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_ == IntPtr.Zero)
				id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_ = JNIEnv.GetMethodID (class_ref, "setSurfaceTextureHost", "(Ltv/danmaku/ijk/media/player/ISurfaceTextureHost;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_, __args);
		}

	}

}
