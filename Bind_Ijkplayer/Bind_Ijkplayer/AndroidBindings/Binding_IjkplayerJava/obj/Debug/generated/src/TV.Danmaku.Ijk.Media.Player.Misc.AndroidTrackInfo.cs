using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidTrackInfo']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/misc/AndroidTrackInfo", DoNotGenerateAcw=true)]
	public partial class AndroidTrackInfo : global::Java.Lang.Object, global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo {


		public static class InterfaceConsts {

			// The following are fields from: tv.danmaku.ijk.media.player.misc.ITrackInfo

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_AUDIO']"
			[Register ("MEDIA_TRACK_TYPE_AUDIO")]
			public const int MediaTrackTypeAudio = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_METADATA']"
			[Register ("MEDIA_TRACK_TYPE_METADATA")]
			public const int MediaTrackTypeMetadata = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_SUBTITLE']"
			[Register ("MEDIA_TRACK_TYPE_SUBTITLE")]
			public const int MediaTrackTypeSubtitle = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_TIMEDTEXT']"
			[Register ("MEDIA_TRACK_TYPE_TIMEDTEXT")]
			public const int MediaTrackTypeTimedtext = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_UNKNOWN']"
			[Register ("MEDIA_TRACK_TYPE_UNKNOWN")]
			public const int MediaTrackTypeUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/interface[@name='ITrackInfo']/field[@name='MEDIA_TRACK_TYPE_VIDEO']"
			[Register ("MEDIA_TRACK_TYPE_VIDEO")]
			public const int MediaTrackTypeVideo = (int) 1;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/misc/AndroidTrackInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidTrackInfo); }
		}

		protected AndroidTrackInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format);
		}
#pragma warning restore 0169

		static IntPtr id_getFormat;
		public virtual unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidTrackInfo']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;", "GetGetFormatHandler")]
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaFormat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormat", "()Ltv/danmaku/ijk/media/player/misc/IMediaFormat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInfoInline;
#pragma warning disable 0169
		static Delegate GetGetInfoInlineHandler ()
		{
			if (cb_getInfoInline == null)
				cb_getInfoInline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfoInline);
			return cb_getInfoInline;
		}

		static IntPtr n_GetInfoInline (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InfoInline);
		}
#pragma warning restore 0169

		static IntPtr id_getInfoInline;
		public virtual unsafe string InfoInline {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidTrackInfo']/method[@name='getInfoInline' and count(parameter)=0]"
			[Register ("getInfoInline", "()Ljava/lang/String;", "GetGetInfoInlineHandler")]
			get {
				if (id_getInfoInline == IntPtr.Zero)
					id_getInfoInline = JNIEnv.GetMethodID (class_ref, "getInfoInline", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfoInline), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfoInline", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static IntPtr id_getLanguage;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidTrackInfo']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackType;
#pragma warning disable 0169
		static Delegate GetGetTrackTypeHandler ()
		{
			if (cb_getTrackType == null)
				cb_getTrackType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrackType);
			return cb_getTrackType;
		}

		static int n_GetTrackType (IntPtr jnienv, IntPtr native__this)
		{
			global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackType;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackType;
		public virtual unsafe int TrackType {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidTrackInfo']/method[@name='getTrackType' and count(parameter)=0]"
			[Register ("getTrackType", "()I", "GetGetTrackTypeHandler")]
			get {
				if (id_getTrackType == IntPtr.Zero)
					id_getTrackType = JNIEnv.GetMethodID (class_ref, "getTrackType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackType", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_fromMediaPlayer_Landroid_media_MediaPlayer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player.misc']/class[@name='AndroidTrackInfo']/method[@name='fromMediaPlayer' and count(parameter)=1 and parameter[1][@type='android.media.MediaPlayer']]"
		[Register ("fromMediaPlayer", "(Landroid/media/MediaPlayer;)[Ltv/danmaku/ijk/media/player/misc/AndroidTrackInfo;", "")]
		public static unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo[] FromMediaPlayer (global::Android.Media.MediaPlayer p0)
		{
			if (id_fromMediaPlayer_Landroid_media_MediaPlayer_ == IntPtr.Zero)
				id_fromMediaPlayer_Landroid_media_MediaPlayer_ = JNIEnv.GetStaticMethodID (class_ref, "fromMediaPlayer", "(Landroid/media/MediaPlayer;)[Ltv/danmaku/ijk/media/player/misc/AndroidTrackInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo[] __ret = (global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromMediaPlayer_Landroid_media_MediaPlayer_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::TV.Danmaku.Ijk.Media.Player.Misc.AndroidTrackInfo));
				return __ret;
			} finally {
			}
		}

	}
}
