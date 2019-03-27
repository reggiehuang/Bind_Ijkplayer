using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/AndroidMediaPlayer", DoNotGenerateAcw=true)]
	public partial class AndroidMediaPlayer : global::TV.Danmaku.Ijk.Media.Player.AbstractMediaPlayer {

		// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']"
		[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/AndroidMediaPlayer$AndroidMediaPlayerListenerHolder", DoNotGenerateAcw=true)]
		public partial class AndroidMediaPlayerListenerHolder : global::Java.Lang.Object, global::Android.Media.MediaPlayer.IOnBufferingUpdateListener, global::Android.Media.MediaPlayer.IOnCompletionListener, global::Android.Media.MediaPlayer.IOnErrorListener, global::Android.Media.MediaPlayer.IOnInfoListener, global::Android.Media.MediaPlayer.IOnPreparedListener, global::Android.Media.MediaPlayer.IOnSeekCompleteListener, global::Android.Media.MediaPlayer.IOnTimedTextListener, global::Android.Media.MediaPlayer.IOnVideoSizeChangedListener {


			static IntPtr mWeakMediaPlayer_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/field[@name='mWeakMediaPlayer']"
			[Register ("mWeakMediaPlayer")]
			public global::Java.Lang.Ref.WeakReference MWeakMediaPlayer {
				get {
					if (mWeakMediaPlayer_jfieldId == IntPtr.Zero)
						mWeakMediaPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "mWeakMediaPlayer", "Ljava/lang/ref/WeakReference;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mWeakMediaPlayer_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mWeakMediaPlayer_jfieldId == IntPtr.Zero)
						mWeakMediaPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "mWeakMediaPlayer", "Ljava/lang/ref/WeakReference;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mWeakMediaPlayer_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/AndroidMediaPlayer$AndroidMediaPlayerListenerHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AndroidMediaPlayerListenerHolder); }
			}

			protected AndroidMediaPlayerListenerHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/constructor[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder' and count(parameter)=2 and parameter[1][@type='tv.danmaku.ijk.media.player.AndroidMediaPlayer'] and parameter[2][@type='tv.danmaku.ijk.media.player.AndroidMediaPlayer']]"
			[Register (".ctor", "(Ltv/danmaku/ijk/media/player/AndroidMediaPlayer;Ltv/danmaku/ijk/media/player/AndroidMediaPlayer;)V", "")]
			public unsafe AndroidMediaPlayerListenerHolder (global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __self, global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (AndroidMediaPlayerListenerHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ltv/danmaku/ijk/media/player/AndroidMediaPlayer;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ltv/danmaku/ijk/media/player/AndroidMediaPlayer;)V", __args);
						return;
					}

					if (id_ctor_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_ == IntPtr.Zero)
						id_ctor_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ltv/danmaku/ijk/media/player/AndroidMediaPlayer;Ltv/danmaku/ijk/media/player/AndroidMediaPlayer;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_Ltv_danmaku_ijk_media_player_AndroidMediaPlayer_, __args);
				} finally {
				}
			}

			static Delegate cb_onBufferingUpdate_Landroid_media_MediaPlayer_I;
#pragma warning disable 0169
			static Delegate GetOnBufferingUpdate_Landroid_media_MediaPlayer_IHandler ()
			{
				if (cb_onBufferingUpdate_Landroid_media_MediaPlayer_I == null)
					cb_onBufferingUpdate_Landroid_media_MediaPlayer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBufferingUpdate_Landroid_media_MediaPlayer_I);
				return cb_onBufferingUpdate_Landroid_media_MediaPlayer_I;
			}

			static void n_OnBufferingUpdate_Landroid_media_MediaPlayer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBufferingUpdate (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onBufferingUpdate_Landroid_media_MediaPlayer_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onBufferingUpdate' and count(parameter)=2 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int']]"
			[Register ("onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V", "GetOnBufferingUpdate_Landroid_media_MediaPlayer_IHandler")]
			public virtual unsafe void OnBufferingUpdate (global::Android.Media.MediaPlayer p0, int p1)
			{
				if (id_onBufferingUpdate_Landroid_media_MediaPlayer_I == IntPtr.Zero)
					id_onBufferingUpdate_Landroid_media_MediaPlayer_I = JNIEnv.GetMethodID (class_ref, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferingUpdate_Landroid_media_MediaPlayer_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCompletion_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
			static Delegate GetOnCompletion_Landroid_media_MediaPlayer_Handler ()
			{
				if (cb_onCompletion_Landroid_media_MediaPlayer_ == null)
					cb_onCompletion_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompletion_Landroid_media_MediaPlayer_);
				return cb_onCompletion_Landroid_media_MediaPlayer_;
			}

			static void n_OnCompletion_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCompletion (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCompletion_Landroid_media_MediaPlayer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onCompletion' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
			[Register ("onCompletion", "(Landroid/media/MediaPlayer;)V", "GetOnCompletion_Landroid_media_MediaPlayer_Handler")]
			public virtual unsafe void OnCompletion (global::Android.Media.MediaPlayer p0)
			{
				if (id_onCompletion_Landroid_media_MediaPlayer_ == IntPtr.Zero)
					id_onCompletion_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onCompletion", "(Landroid/media/MediaPlayer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletion_Landroid_media_MediaPlayer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompletion", "(Landroid/media/MediaPlayer;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onError_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
			static Delegate GetOnError_Landroid_media_MediaPlayer_IIHandler ()
			{
				if (cb_onError_Landroid_media_MediaPlayer_II == null)
					cb_onError_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnError_Landroid_media_MediaPlayer_II);
				return cb_onError_Landroid_media_MediaPlayer_II;
			}

			static bool n_OnError_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaError p1 = (global::Android.Media.MediaError) native_p1;
				bool __ret = __this.OnError (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onError_Landroid_media_MediaPlayer_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onError", "(Landroid/media/MediaPlayer;II)Z", "GetOnError_Landroid_media_MediaPlayer_IIHandler")]
			public virtual unsafe bool OnError (global::Android.Media.MediaPlayer p0, [global::Android.Runtime.GeneratedEnum] global::Android.Media.MediaError p1, int p2)
			{
				if (id_onError_Landroid_media_MediaPlayer_II == IntPtr.Zero)
					id_onError_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onError", "(Landroid/media/MediaPlayer;II)Z");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);
					__args [2] = new JValue (p2);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onError_Landroid_media_MediaPlayer_II, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Landroid/media/MediaPlayer;II)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onInfo_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
			static Delegate GetOnInfo_Landroid_media_MediaPlayer_IIHandler ()
			{
				if (cb_onInfo_Landroid_media_MediaPlayer_II == null)
					cb_onInfo_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_OnInfo_Landroid_media_MediaPlayer_II);
				return cb_onInfo_Landroid_media_MediaPlayer_II;
			}

			static bool n_OnInfo_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaInfo p1 = (global::Android.Media.MediaInfo) native_p1;
				bool __ret = __this.OnInfo (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onInfo_Landroid_media_MediaPlayer_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onInfo' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onInfo", "(Landroid/media/MediaPlayer;II)Z", "GetOnInfo_Landroid_media_MediaPlayer_IIHandler")]
			public virtual unsafe bool OnInfo (global::Android.Media.MediaPlayer p0, [global::Android.Runtime.GeneratedEnum] global::Android.Media.MediaInfo p1, int p2)
			{
				if (id_onInfo_Landroid_media_MediaPlayer_II == IntPtr.Zero)
					id_onInfo_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onInfo", "(Landroid/media/MediaPlayer;II)Z");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);
					__args [2] = new JValue (p2);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onInfo_Landroid_media_MediaPlayer_II, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInfo", "(Landroid/media/MediaPlayer;II)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onPrepared_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
			static Delegate GetOnPrepared_Landroid_media_MediaPlayer_Handler ()
			{
				if (cb_onPrepared_Landroid_media_MediaPlayer_ == null)
					cb_onPrepared_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPrepared_Landroid_media_MediaPlayer_);
				return cb_onPrepared_Landroid_media_MediaPlayer_;
			}

			static void n_OnPrepared_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPrepared (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPrepared_Landroid_media_MediaPlayer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onPrepared' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
			[Register ("onPrepared", "(Landroid/media/MediaPlayer;)V", "GetOnPrepared_Landroid_media_MediaPlayer_Handler")]
			public virtual unsafe void OnPrepared (global::Android.Media.MediaPlayer p0)
			{
				if (id_onPrepared_Landroid_media_MediaPlayer_ == IntPtr.Zero)
					id_onPrepared_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onPrepared", "(Landroid/media/MediaPlayer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepared_Landroid_media_MediaPlayer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepared", "(Landroid/media/MediaPlayer;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onSeekComplete_Landroid_media_MediaPlayer_;
#pragma warning disable 0169
			static Delegate GetOnSeekComplete_Landroid_media_MediaPlayer_Handler ()
			{
				if (cb_onSeekComplete_Landroid_media_MediaPlayer_ == null)
					cb_onSeekComplete_Landroid_media_MediaPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSeekComplete_Landroid_media_MediaPlayer_);
				return cb_onSeekComplete_Landroid_media_MediaPlayer_;
			}

			static void n_OnSeekComplete_Landroid_media_MediaPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSeekComplete (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSeekComplete_Landroid_media_MediaPlayer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onSeekComplete' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
			[Register ("onSeekComplete", "(Landroid/media/MediaPlayer;)V", "GetOnSeekComplete_Landroid_media_MediaPlayer_Handler")]
			public virtual unsafe void OnSeekComplete (global::Android.Media.MediaPlayer p0)
			{
				if (id_onSeekComplete_Landroid_media_MediaPlayer_ == IntPtr.Zero)
					id_onSeekComplete_Landroid_media_MediaPlayer_ = JNIEnv.GetMethodID (class_ref, "onSeekComplete", "(Landroid/media/MediaPlayer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSeekComplete_Landroid_media_MediaPlayer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSeekComplete", "(Landroid/media/MediaPlayer;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_;
#pragma warning disable 0169
			static Delegate GetOnTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_Handler ()
			{
				if (cb_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_ == null)
					cb_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_);
				return cb_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_;
			}

			static void n_OnTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.TimedText p1 = global::Java.Lang.Object.GetObject<global::Android.Media.TimedText> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTimedText (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onTimedText' and count(parameter)=2 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='android.media.TimedText']]"
			[Register ("onTimedText", "(Landroid/media/MediaPlayer;Landroid/media/TimedText;)V", "GetOnTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_Handler")]
			public virtual unsafe void OnTimedText (global::Android.Media.MediaPlayer p0, global::Android.Media.TimedText p1)
			{
				if (id_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_ == IntPtr.Zero)
					id_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_ = JNIEnv.GetMethodID (class_ref, "onTimedText", "(Landroid/media/MediaPlayer;Landroid/media/TimedText;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimedText_Landroid_media_MediaPlayer_Landroid_media_TimedText_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTimedText", "(Landroid/media/MediaPlayer;Landroid/media/TimedText;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
#pragma warning disable 0169
			static Delegate GetOnVideoSizeChanged_Landroid_media_MediaPlayer_IIHandler ()
			{
				if (cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II == null)
					cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnVideoSizeChanged_Landroid_media_MediaPlayer_II);
				return cb_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
			}

			static void n_OnVideoSizeChanged_Landroid_media_MediaPlayer_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.AndroidMediaPlayerListenerHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Media.MediaPlayer p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnVideoSizeChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onVideoSizeChanged_Landroid_media_MediaPlayer_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.AndroidMediaPlayerListenerHolder']/method[@name='onVideoSizeChanged' and count(parameter)=3 and parameter[1][@type='android.media.MediaPlayer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", "GetOnVideoSizeChanged_Landroid_media_MediaPlayer_IIHandler")]
			public virtual unsafe void OnVideoSizeChanged (global::Android.Media.MediaPlayer p0, int p1, int p2)
			{
				if (id_onVideoSizeChanged_Landroid_media_MediaPlayer_II == IntPtr.Zero)
					id_onVideoSizeChanged_Landroid_media_MediaPlayer_II = JNIEnv.GetMethodID (class_ref, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoSizeChanged_Landroid_media_MediaPlayer_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.MediaDataSourceProxy']"
		[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/AndroidMediaPlayer$MediaDataSourceProxy", DoNotGenerateAcw=true)]
		public partial class MediaDataSourceProxy : global::Android.Media.MediaDataSource {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/AndroidMediaPlayer$MediaDataSourceProxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaDataSourceProxy); }
			}

			protected MediaDataSourceProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.MediaDataSourceProxy']/constructor[@name='AndroidMediaPlayer.MediaDataSourceProxy' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.misc.IMediaDataSource']]"
			[Register (".ctor", "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V", "")]
			public unsafe MediaDataSourceProxy (global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (MediaDataSourceProxy)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V", __args);
						return;
					}

					if (id_ctor_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ == IntPtr.Zero)
						id_ctor_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_, __args);
				} finally {
				}
			}

			static Delegate cb_getSize;
#pragma warning disable 0169
			static Delegate GetGetSizeHandler ()
			{
				if (cb_getSize == null)
					cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
				return cb_getSize;
			}

			static long n_GetSize (IntPtr jnienv, IntPtr native__this)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.MediaDataSourceProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.MediaDataSourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Size;
			}
#pragma warning restore 0169

			static IntPtr id_getSize;
			public override unsafe long Size {
				// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.MediaDataSourceProxy']/method[@name='getSize' and count(parameter)=0]"
				[Register ("getSize", "()J", "GetGetSizeHandler")]
				get {
					if (id_getSize == IntPtr.Zero)
						id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_close;
#pragma warning disable 0169
			static Delegate GetCloseHandler ()
			{
				if (cb_close == null)
					cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
				return cb_close;
			}

			static void n_Close (IntPtr jnienv, IntPtr native__this)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.MediaDataSourceProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.MediaDataSourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.MediaDataSourceProxy']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public override unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
				} finally {
				}
			}

			static Delegate cb_readAt_JarrayBII;
#pragma warning disable 0169
			static Delegate GetReadAt_JarrayBIIHandler ()
			{
				if (cb_readAt_JarrayBII == null)
					cb_readAt_JarrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, int, int, int>) n_ReadAt_JarrayBII);
				return cb_readAt_JarrayBII;
			}

			static int n_ReadAt_JarrayBII (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, int p2, int p3)
			{
				global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.MediaDataSourceProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer.MediaDataSourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				int __ret = __this.ReadAt (p0, p1, p2, p3);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_readAt_JarrayBII;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer.MediaDataSourceProxy']/method[@name='readAt' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("readAt", "(J[BII)I", "GetReadAt_JarrayBIIHandler")]
			public override unsafe int ReadAt (long p0, byte[] p1, int p2, int p3)
			{
				if (id_readAt_JarrayBII == IntPtr.Zero)
					id_readAt_JarrayBII = JNIEnv.GetMethodID (class_ref, "readAt", "(J[BII)I");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					int __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readAt_JarrayBII, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readAt", "(J[BII)I"), __args);
					return __ret;
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/AndroidMediaPlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidMediaPlayer); }
		}

		protected AndroidMediaPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/constructor[@name='AndroidMediaPlayer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndroidMediaPlayer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AndroidMediaPlayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getAudioSessionId;
#pragma warning disable 0169
		static Delegate GetGetAudioSessionIdHandler ()
		{
			if (cb_getAudioSessionId == null)
				cb_getAudioSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAudioSessionId);
			return cb_getAudioSessionId;
		}

		static int n_GetAudioSessionId (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSessionId;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioSessionId;
		public override unsafe int AudioSessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getAudioSessionId' and count(parameter)=0]"
			[Register ("getAudioSessionId", "()I", "GetGetAudioSessionIdHandler")]
			get {
				if (id_getAudioSessionId == IntPtr.Zero)
					id_getAudioSessionId = JNIEnv.GetMethodID (class_ref, "getAudioSessionId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAudioSessionId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioSessionId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionHandler ()
		{
			if (cb_getCurrentPosition == null)
				cb_getCurrentPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentPosition);
			return cb_getCurrentPosition;
		}

		static long n_GetCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPosition;
		public override unsafe long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler")]
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDataSource;
#pragma warning disable 0169
		static Delegate GetGetDataSourceHandler ()
		{
			if (cb_getDataSource == null)
				cb_getDataSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSource);
			return cb_getDataSource;
		}

		static IntPtr n_GetDataSource (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataSource);
		}
#pragma warning restore 0169

		static Delegate cb_setDataSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Ljava_lang_String_Handler ()
		{
			if (cb_setDataSource_Ljava_lang_String_ == null)
				cb_setDataSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSource_Ljava_lang_String_);
			return cb_setDataSource_Ljava_lang_String_;
		}

		static void n_SetDataSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource;
		static IntPtr id_setDataSource_Ljava_lang_String_;
		public override unsafe string DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Ljava/lang/String;", "GetGetDataSourceHandler")]
			get {
				if (id_getDataSource == IntPtr.Zero)
					id_getDataSource = JNIEnv.GetMethodID (class_ref, "getDataSource", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataSource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDataSource", "(Ljava/lang/String;)V", "GetSetDataSource_Ljava_lang_String_Handler")]
			set {
				if (id_setDataSource_Ljava_lang_String_ == IntPtr.Zero)
					id_setDataSource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public override unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getInternalMediaPlayer;
#pragma warning disable 0169
		static Delegate GetGetInternalMediaPlayerHandler ()
		{
			if (cb_getInternalMediaPlayer == null)
				cb_getInternalMediaPlayer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInternalMediaPlayer);
			return cb_getInternalMediaPlayer;
		}

		static IntPtr n_GetInternalMediaPlayer (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalMediaPlayer);
		}
#pragma warning restore 0169

		static IntPtr id_getInternalMediaPlayer;
		public virtual unsafe global::Android.Media.MediaPlayer InternalMediaPlayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getInternalMediaPlayer' and count(parameter)=0]"
			[Register ("getInternalMediaPlayer", "()Landroid/media/MediaPlayer;", "GetGetInternalMediaPlayerHandler")]
			get {
				if (id_getInternalMediaPlayer == IntPtr.Zero)
					id_getInternalMediaPlayer = JNIEnv.GetMethodID (class_ref, "getInternalMediaPlayer", "()Landroid/media/MediaPlayer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInternalMediaPlayer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInternalMediaPlayer", "()Landroid/media/MediaPlayer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPlayable;
#pragma warning disable 0169
		static Delegate GetIsPlayableHandler ()
		{
			if (cb_isPlayable == null)
				cb_isPlayable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlayable);
			return cb_isPlayable;
		}

		static bool n_IsPlayable (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlayable;
		}
#pragma warning restore 0169

		static IntPtr id_isPlayable;
		public override unsafe bool IsPlayable {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='isPlayable' and count(parameter)=0]"
			[Register ("isPlayable", "()Z", "GetIsPlayableHandler")]
			get {
				if (id_isPlayable == IntPtr.Zero)
					id_isPlayable = JNIEnv.GetMethodID (class_ref, "isPlayable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlayable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPlayable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPlaying;
#pragma warning disable 0169
		static Delegate GetIsPlayingHandler ()
		{
			if (cb_isPlaying == null)
				cb_isPlaying = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlaying);
			return cb_isPlaying;
		}

		static bool n_IsPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		static IntPtr id_isPlaying;
		public override unsafe bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler")]
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPlaying", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLooping;
#pragma warning disable 0169
		static Delegate GetIsLoopingHandler ()
		{
			if (cb_isLooping == null)
				cb_isLooping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLooping);
			return cb_isLooping;
		}

		static bool n_IsLooping (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Looping;
		}
#pragma warning restore 0169

		static Delegate cb_setLooping_Z;
#pragma warning disable 0169
		static Delegate GetSetLooping_ZHandler ()
		{
			if (cb_setLooping_Z == null)
				cb_setLooping_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLooping_Z);
			return cb_setLooping_Z;
		}

		static void n_SetLooping_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Looping = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isLooping;
		static IntPtr id_setLooping_Z;
		public override unsafe bool Looping {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='isLooping' and count(parameter)=0]"
			[Register ("isLooping", "()Z", "GetIsLoopingHandler")]
			get {
				if (id_isLooping == IntPtr.Zero)
					id_isLooping = JNIEnv.GetMethodID (class_ref, "isLooping", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLooping);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLooping", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setLooping' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLooping", "(Z)V", "GetSetLooping_ZHandler")]
			set {
				if (id_setLooping_Z == IntPtr.Zero)
					id_setLooping_Z = JNIEnv.GetMethodID (class_ref, "setLooping", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLooping_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLooping", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaInfo;
#pragma warning disable 0169
		static Delegate GetGetMediaInfoHandler ()
		{
			if (cb_getMediaInfo == null)
				cb_getMediaInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaInfo);
			return cb_getMediaInfo;
		}

		static IntPtr n_GetMediaInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaInfo;
		public override unsafe global::TV.Danmaku.Ijk.Media.Player.MediaInfo MediaInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getMediaInfo' and count(parameter)=0]"
			[Register ("getMediaInfo", "()Ltv/danmaku/ijk/media/player/MediaInfo;", "GetGetMediaInfoHandler")]
			get {
				if (id_getMediaInfo == IntPtr.Zero)
					id_getMediaInfo = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "()Ltv/danmaku/ijk/media/player/MediaInfo;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaInfo", "()Ltv/danmaku/ijk/media/player/MediaInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoHeight;
#pragma warning disable 0169
		static Delegate GetGetVideoHeightHandler ()
		{
			if (cb_getVideoHeight == null)
				cb_getVideoHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoHeight);
			return cb_getVideoHeight;
		}

		static int n_GetVideoHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoHeight;
		public override unsafe int VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getVideoHeight' and count(parameter)=0]"
			[Register ("getVideoHeight", "()I", "GetGetVideoHeightHandler")]
			get {
				if (id_getVideoHeight == IntPtr.Zero)
					id_getVideoHeight = JNIEnv.GetMethodID (class_ref, "getVideoHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoSarDen;
#pragma warning disable 0169
		static Delegate GetGetVideoSarDenHandler ()
		{
			if (cb_getVideoSarDen == null)
				cb_getVideoSarDen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoSarDen);
			return cb_getVideoSarDen;
		}

		static int n_GetVideoSarDen (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSarDen;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoSarDen;
		public override unsafe int VideoSarDen {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getVideoSarDen' and count(parameter)=0]"
			[Register ("getVideoSarDen", "()I", "GetGetVideoSarDenHandler")]
			get {
				if (id_getVideoSarDen == IntPtr.Zero)
					id_getVideoSarDen = JNIEnv.GetMethodID (class_ref, "getVideoSarDen", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoSarDen);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoSarDen", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoSarNum;
#pragma warning disable 0169
		static Delegate GetGetVideoSarNumHandler ()
		{
			if (cb_getVideoSarNum == null)
				cb_getVideoSarNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoSarNum);
			return cb_getVideoSarNum;
		}

		static int n_GetVideoSarNum (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSarNum;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoSarNum;
		public override unsafe int VideoSarNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getVideoSarNum' and count(parameter)=0]"
			[Register ("getVideoSarNum", "()I", "GetGetVideoSarNumHandler")]
			get {
				if (id_getVideoSarNum == IntPtr.Zero)
					id_getVideoSarNum = JNIEnv.GetMethodID (class_ref, "getVideoSarNum", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoSarNum);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoSarNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoWidth;
#pragma warning disable 0169
		static Delegate GetGetVideoWidthHandler ()
		{
			if (cb_getVideoWidth == null)
				cb_getVideoWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVideoWidth);
			return cb_getVideoWidth;
		}

		static int n_GetVideoWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoWidth;
		public override unsafe int VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getVideoWidth' and count(parameter)=0]"
			[Register ("getVideoWidth", "()I", "GetGetVideoWidthHandler")]
			get {
				if (id_getVideoWidth == IntPtr.Zero)
					id_getVideoWidth = JNIEnv.GetMethodID (class_ref, "getVideoWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTrackInfo;
#pragma warning disable 0169
		static Delegate GetGetTrackInfoHandler ()
		{
			if (cb_getTrackInfo == null)
				cb_getTrackInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackInfo);
			return cb_getTrackInfo;
		}

		static IntPtr n_GetTrackInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTrackInfo ());
		}
#pragma warning restore 0169

		static IntPtr id_getTrackInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='getTrackInfo' and count(parameter)=0]"
		[Register ("getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/ITrackInfo;", "GetGetTrackInfoHandler")]
		public override unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo[] GetTrackInfo ()
		{
			if (id_getTrackInfo == IntPtr.Zero)
				id_getTrackInfo = JNIEnv.GetMethodID (class_ref, "getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/ITrackInfo;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackInfo), JniHandleOwnership.TransferLocalRef, typeof (global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo));
				else
					return (global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/ITrackInfo;")), JniHandleOwnership.TransferLocalRef, typeof (global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo));
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public override unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_prepareAsync;
#pragma warning disable 0169
		static Delegate GetPrepareAsyncHandler ()
		{
			if (cb_prepareAsync == null)
				cb_prepareAsync = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareAsync);
			return cb_prepareAsync;
		}

		static void n_PrepareAsync (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareAsync ();
		}
#pragma warning restore 0169

		static IntPtr id_prepareAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='prepareAsync' and count(parameter)=0]"
		[Register ("prepareAsync", "()V", "GetPrepareAsyncHandler")]
		public override unsafe void PrepareAsync ()
		{
			if (id_prepareAsync == IntPtr.Zero)
				id_prepareAsync = JNIEnv.GetMethodID (class_ref, "prepareAsync", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareAsync);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareAsync", "()V"));
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public override unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static void n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seekTo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler")]
		public override unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekTo", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAudioStreamType_I;
#pragma warning disable 0169
		static Delegate GetSetAudioStreamType_IHandler ()
		{
			if (cb_setAudioStreamType_I == null)
				cb_setAudioStreamType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAudioStreamType_I);
			return cb_setAudioStreamType_I;
		}

		static void n_SetAudioStreamType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioStreamType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAudioStreamType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setAudioStreamType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioStreamType", "(I)V", "GetSetAudioStreamType_IHandler")]
		public override unsafe void SetAudioStreamType (int p0)
		{
			if (id_setAudioStreamType_I == IntPtr.Zero)
				id_setAudioStreamType_I = JNIEnv.GetMethodID (class_ref, "setAudioStreamType", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioStreamType_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioStreamType", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Handler ()
		{
			if (cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_ == null)
				cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_);
			return cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
		}

		static void n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Handler")]
		public override unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_Handler ()
		{
			if (cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ == null)
				cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_);
			return cb_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
		}

		static void n_SetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_Handler")]
		public override unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ == IntPtr.Zero)
				id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setDataSource_Ljava_io_FileDescriptor_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Ljava_io_FileDescriptor_Handler ()
		{
			if (cb_setDataSource_Ljava_io_FileDescriptor_ == null)
				cb_setDataSource_Ljava_io_FileDescriptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSource_Ljava_io_FileDescriptor_);
			return cb_setDataSource_Ljava_io_FileDescriptor_;
		}

		static void n_SetDataSource_Ljava_io_FileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.FileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Ljava_io_FileDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register ("setDataSource", "(Ljava/io/FileDescriptor;)V", "GetSetDataSource_Ljava_io_FileDescriptor_Handler")]
		public override unsafe void SetDataSource (global::Java.IO.FileDescriptor p0)
		{
			if (id_setDataSource_Ljava_io_FileDescriptor_ == IntPtr.Zero)
				id_setDataSource_Ljava_io_FileDescriptor_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_io_FileDescriptor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Ljava/io/FileDescriptor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplay_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSetDisplay_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_setDisplay_Landroid_view_SurfaceHolder_ == null)
				cb_setDisplay_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplay_Landroid_view_SurfaceHolder_);
			return cb_setDisplay_Landroid_view_SurfaceHolder_;
		}

		static void n_SetDisplay_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplay_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setDisplay", "(Landroid/view/SurfaceHolder;)V", "GetSetDisplay_Landroid_view_SurfaceHolder_Handler")]
		public override unsafe void SetDisplay (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_setDisplay_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_setDisplay_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setKeepInBackground_Z;
#pragma warning disable 0169
		static Delegate GetSetKeepInBackground_ZHandler ()
		{
			if (cb_setKeepInBackground_Z == null)
				cb_setKeepInBackground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetKeepInBackground_Z);
			return cb_setKeepInBackground_Z;
		}

		static void n_SetKeepInBackground_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeepInBackground_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setKeepInBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setKeepInBackground", "(Z)V", "GetSetKeepInBackground_ZHandler")]
		public override unsafe void SetKeepInBackground (bool p0)
		{
			if (id_setKeepInBackground_Z == IntPtr.Zero)
				id_setKeepInBackground_Z = JNIEnv.GetMethodID (class_ref, "setKeepInBackground", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeepInBackground_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepInBackground", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLogEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLogEnabled_ZHandler ()
		{
			if (cb_setLogEnabled_Z == null)
				cb_setLogEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLogEnabled_Z);
			return cb_setLogEnabled_Z;
		}

		static void n_SetLogEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setLogEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLogEnabled", "(Z)V", "GetSetLogEnabled_ZHandler")]
		public override unsafe void SetLogEnabled (bool p0)
		{
			if (id_setLogEnabled_Z == IntPtr.Zero)
				id_setLogEnabled_Z = JNIEnv.GetMethodID (class_ref, "setLogEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScreenOnWhilePlaying_Z;
#pragma warning disable 0169
		static Delegate GetSetScreenOnWhilePlaying_ZHandler ()
		{
			if (cb_setScreenOnWhilePlaying_Z == null)
				cb_setScreenOnWhilePlaying_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScreenOnWhilePlaying_Z);
			return cb_setScreenOnWhilePlaying_Z;
		}

		static void n_SetScreenOnWhilePlaying_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScreenOnWhilePlaying (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScreenOnWhilePlaying_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setScreenOnWhilePlaying' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScreenOnWhilePlaying", "(Z)V", "GetSetScreenOnWhilePlaying_ZHandler")]
		public override unsafe void SetScreenOnWhilePlaying (bool p0)
		{
			if (id_setScreenOnWhilePlaying_Z == IntPtr.Zero)
				id_setScreenOnWhilePlaying_Z = JNIEnv.GetMethodID (class_ref, "setScreenOnWhilePlaying", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScreenOnWhilePlaying_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScreenOnWhilePlaying", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSurface_Landroid_view_Surface_;
#pragma warning disable 0169
		static Delegate GetSetSurface_Landroid_view_Surface_Handler ()
		{
			if (cb_setSurface_Landroid_view_Surface_ == null)
				cb_setSurface_Landroid_view_Surface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSurface_Landroid_view_Surface_);
			return cb_setSurface_Landroid_view_Surface_;
		}

		static void n_SetSurface_Landroid_view_Surface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurface (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSurface_Landroid_view_Surface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("setSurface", "(Landroid/view/Surface;)V", "GetSetSurface_Landroid_view_Surface_Handler")]
		public override unsafe void SetSurface (global::Android.Views.Surface p0)
		{
			if (id_setSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_setSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "setSurface", "(Landroid/view/Surface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurface_Landroid_view_Surface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurface", "(Landroid/view/Surface;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVolume_FF;
#pragma warning disable 0169
		static Delegate GetSetVolume_FFHandler ()
		{
			if (cb_setVolume_FF == null)
				cb_setVolume_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetVolume_FF);
			return cb_setVolume_FF;
		}

		static void n_SetVolume_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVolume_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setVolume' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setVolume", "(FF)V", "GetSetVolume_FFHandler")]
		public override unsafe void SetVolume (float p0, float p1)
		{
			if (id_setVolume_FF == IntPtr.Zero)
				id_setVolume_FF = JNIEnv.GetMethodID (class_ref, "setVolume", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVolume", "(FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setWakeMode_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetSetWakeMode_Landroid_content_Context_IHandler ()
		{
			if (cb_setWakeMode_Landroid_content_Context_I == null)
				cb_setWakeMode_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetWakeMode_Landroid_content_Context_I);
			return cb_setWakeMode_Landroid_content_Context_I;
		}

		static void n_SetWakeMode_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWakeMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWakeMode_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='setWakeMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setWakeMode", "(Landroid/content/Context;I)V", "GetSetWakeMode_Landroid_content_Context_IHandler")]
		public override unsafe void SetWakeMode (global::Android.Content.Context p0, int p1)
		{
			if (id_setWakeMode_Landroid_content_Context_I == IntPtr.Zero)
				id_setWakeMode_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setWakeMode", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWakeMode_Landroid_content_Context_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWakeMode", "(Landroid/content/Context;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.AndroidMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='AndroidMediaPlayer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
