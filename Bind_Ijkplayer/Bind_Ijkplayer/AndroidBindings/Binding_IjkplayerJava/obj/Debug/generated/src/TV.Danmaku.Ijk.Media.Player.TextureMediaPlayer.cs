using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='TextureMediaPlayer']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/TextureMediaPlayer", DoNotGenerateAcw=true)]
	public partial class TextureMediaPlayer : global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer, global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHolder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/TextureMediaPlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextureMediaPlayer); }
		}

		protected TextureMediaPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='TextureMediaPlayer']/constructor[@name='TextureMediaPlayer' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer']]"
		[Register (".ctor", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V", "")]
		public unsafe TextureMediaPlayer (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TextureMediaPlayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V", __args);
					return;
				}

				if (id_ctor_Ltv_danmaku_ijk_media_player_IMediaPlayer_ == IntPtr.Zero)
					id_ctor_Ltv_danmaku_ijk_media_player_IMediaPlayer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IMediaPlayer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IMediaPlayer_, __args);
			} finally {
			}
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
			global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.SurfaceTexture p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceTexture = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSurfaceTexture;
		static IntPtr id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_;
		public virtual unsafe global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='TextureMediaPlayer']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler")]
			get {
				if (id_getSurfaceTexture == IntPtr.Zero)
					id_getSurfaceTexture = JNIEnv.GetMethodID (class_ref, "getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurfaceTexture), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='TextureMediaPlayer']/method[@name='setSurfaceTexture' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
			[Register ("setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V", "GetSetSurfaceTexture_Landroid_graphics_SurfaceTexture_Handler")]
			set {
				if (id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
					id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurfaceTexture_Landroid_graphics_SurfaceTexture_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurfaceTexture", "(Landroid/graphics/SurfaceTexture;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_releaseSurfaceTexture;
#pragma warning disable 0169
		static Delegate GetReleaseSurfaceTextureHandler ()
		{
			if (cb_releaseSurfaceTexture == null)
				cb_releaseSurfaceTexture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseSurfaceTexture);
			return cb_releaseSurfaceTexture;
		}

		static void n_ReleaseSurfaceTexture (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseSurfaceTexture ();
		}
#pragma warning restore 0169

		static IntPtr id_releaseSurfaceTexture;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='TextureMediaPlayer']/method[@name='releaseSurfaceTexture' and count(parameter)=0]"
		[Register ("releaseSurfaceTexture", "()V", "GetReleaseSurfaceTextureHandler")]
		public virtual unsafe void ReleaseSurfaceTexture ()
		{
			if (id_releaseSurfaceTexture == IntPtr.Zero)
				id_releaseSurfaceTexture = JNIEnv.GetMethodID (class_ref, "releaseSurfaceTexture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseSurfaceTexture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseSurfaceTexture", "()V"));
			} finally {
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
			global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.TextureMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost p0 = (global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurfaceTextureHost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='TextureMediaPlayer']/method[@name='setSurfaceTextureHost' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.ISurfaceTextureHost']]"
		[Register ("setSurfaceTextureHost", "(Ltv/danmaku/ijk/media/player/ISurfaceTextureHost;)V", "GetSetSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_Handler")]
		public virtual unsafe void SetSurfaceTextureHost (global::TV.Danmaku.Ijk.Media.Player.ISurfaceTextureHost p0)
		{
			if (id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_ == IntPtr.Zero)
				id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_ = JNIEnv.GetMethodID (class_ref, "setSurfaceTextureHost", "(Ltv/danmaku/ijk/media/player/ISurfaceTextureHost;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurfaceTextureHost_Ltv_danmaku_ijk_media_player_ISurfaceTextureHost_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurfaceTextureHost", "(Ltv/danmaku/ijk/media/player/ISurfaceTextureHost;)V"), __args);
			} finally {
			}
		}

	}
}
