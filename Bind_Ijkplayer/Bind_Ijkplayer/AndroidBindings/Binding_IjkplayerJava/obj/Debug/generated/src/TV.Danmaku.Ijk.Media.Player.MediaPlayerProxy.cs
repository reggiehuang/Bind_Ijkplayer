using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/MediaPlayerProxy", DoNotGenerateAcw=true)]
	public partial class MediaPlayerProxy : global::Java.Lang.Object, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer {


		static IntPtr mBackEndMediaPlayer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/field[@name='mBackEndMediaPlayer']"
		[Register ("mBackEndMediaPlayer")]
		protected global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer MBackEndMediaPlayer {
			get {
				if (mBackEndMediaPlayer_jfieldId == IntPtr.Zero)
					mBackEndMediaPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackEndMediaPlayer", "Ltv/danmaku/ijk/media/player/IMediaPlayer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBackEndMediaPlayer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBackEndMediaPlayer_jfieldId == IntPtr.Zero)
					mBackEndMediaPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackEndMediaPlayer", "Ltv/danmaku/ijk/media/player/IMediaPlayer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBackEndMediaPlayer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: tv.danmaku.ijk.media.player.IMediaPlayer

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_IO']"
			[Register ("MEDIA_ERROR_IO")]
			public const int MediaErrorIo = (int) -1004;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_MALFORMED']"
			[Register ("MEDIA_ERROR_MALFORMED")]
			public const int MediaErrorMalformed = (int) -1007;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK']"
			[Register ("MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK")]
			public const int MediaErrorNotValidForProgressivePlayback = (int) 200;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_SERVER_DIED']"
			[Register ("MEDIA_ERROR_SERVER_DIED")]
			public const int MediaErrorServerDied = (int) 100;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_TIMED_OUT']"
			[Register ("MEDIA_ERROR_TIMED_OUT")]
			public const int MediaErrorTimedOut = (int) -110;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_UNKNOWN']"
			[Register ("MEDIA_ERROR_UNKNOWN")]
			public const int MediaErrorUnknown = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_ERROR_UNSUPPORTED']"
			[Register ("MEDIA_ERROR_UNSUPPORTED")]
			public const int MediaErrorUnsupported = (int) -1010;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_AUDIO_DECODED_START']"
			[Register ("MEDIA_INFO_AUDIO_DECODED_START")]
			public const int MediaInfoAudioDecodedStart = (int) 10003;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_AUDIO_RENDERING_START']"
			[Register ("MEDIA_INFO_AUDIO_RENDERING_START")]
			public const int MediaInfoAudioRenderingStart = (int) 10002;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_AUDIO_SEEK_RENDERING_START']"
			[Register ("MEDIA_INFO_AUDIO_SEEK_RENDERING_START")]
			public const int MediaInfoAudioSeekRenderingStart = (int) 10009;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_BAD_INTERLEAVING']"
			[Register ("MEDIA_INFO_BAD_INTERLEAVING")]
			public const int MediaInfoBadInterleaving = (int) 800;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_BUFFERING_END']"
			[Register ("MEDIA_INFO_BUFFERING_END")]
			public const int MediaInfoBufferingEnd = (int) 702;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_BUFFERING_START']"
			[Register ("MEDIA_INFO_BUFFERING_START")]
			public const int MediaInfoBufferingStart = (int) 701;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_COMPONENT_OPEN']"
			[Register ("MEDIA_INFO_COMPONENT_OPEN")]
			public const int MediaInfoComponentOpen = (int) 10007;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_FIND_STREAM_INFO']"
			[Register ("MEDIA_INFO_FIND_STREAM_INFO")]
			public const int MediaInfoFindStreamInfo = (int) 10006;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_MEDIA_ACCURATE_SEEK_COMPLETE']"
			[Register ("MEDIA_INFO_MEDIA_ACCURATE_SEEK_COMPLETE")]
			public const int MediaInfoMediaAccurateSeekComplete = (int) 10100;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_METADATA_UPDATE']"
			[Register ("MEDIA_INFO_METADATA_UPDATE")]
			public const int MediaInfoMetadataUpdate = (int) 802;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_NETWORK_BANDWIDTH']"
			[Register ("MEDIA_INFO_NETWORK_BANDWIDTH")]
			public const int MediaInfoNetworkBandwidth = (int) 703;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_NOT_SEEKABLE']"
			[Register ("MEDIA_INFO_NOT_SEEKABLE")]
			public const int MediaInfoNotSeekable = (int) 801;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_OPEN_INPUT']"
			[Register ("MEDIA_INFO_OPEN_INPUT")]
			public const int MediaInfoOpenInput = (int) 10005;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_STARTED_AS_NEXT']"
			[Register ("MEDIA_INFO_STARTED_AS_NEXT")]
			public const int MediaInfoStartedAsNext = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_SUBTITLE_TIMED_OUT']"
			[Register ("MEDIA_INFO_SUBTITLE_TIMED_OUT")]
			public const int MediaInfoSubtitleTimedOut = (int) 902;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_TIMED_TEXT_ERROR']"
			[Register ("MEDIA_INFO_TIMED_TEXT_ERROR")]
			public const int MediaInfoTimedTextError = (int) 900;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_UNKNOWN']"
			[Register ("MEDIA_INFO_UNKNOWN")]
			public const int MediaInfoUnknown = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_UNSUPPORTED_SUBTITLE']"
			[Register ("MEDIA_INFO_UNSUPPORTED_SUBTITLE")]
			public const int MediaInfoUnsupportedSubtitle = (int) 901;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_DECODED_START']"
			[Register ("MEDIA_INFO_VIDEO_DECODED_START")]
			public const int MediaInfoVideoDecodedStart = (int) 10004;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_RENDERING_START']"
			[Register ("MEDIA_INFO_VIDEO_RENDERING_START")]
			public const int MediaInfoVideoRenderingStart = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_ROTATION_CHANGED']"
			[Register ("MEDIA_INFO_VIDEO_ROTATION_CHANGED")]
			public const int MediaInfoVideoRotationChanged = (int) 10001;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_SEEK_RENDERING_START']"
			[Register ("MEDIA_INFO_VIDEO_SEEK_RENDERING_START")]
			public const int MediaInfoVideoSeekRenderingStart = (int) 10008;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IMediaPlayer']/field[@name='MEDIA_INFO_VIDEO_TRACK_LAGGING']"
			[Register ("MEDIA_INFO_VIDEO_TRACK_LAGGING")]
			public const int MediaInfoVideoTrackLagging = (int) 700;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/MediaPlayerProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaPlayerProxy); }
		}

		protected MediaPlayerProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_IMediaPlayer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/constructor[@name='MediaPlayerProxy' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer']]"
		[Register (".ctor", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;)V", "")]
		public unsafe MediaPlayerProxy (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MediaPlayerProxy)) {
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSessionId;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioSessionId;
		public virtual unsafe int AudioSessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getAudioSessionId' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPosition;
		public virtual unsafe long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getCurrentPosition' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DataSource = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSource;
		static IntPtr id_setDataSource_Ljava_lang_String_;
		public virtual unsafe string DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getDataSource' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getDuration' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalMediaPlayer);
		}
#pragma warning restore 0169

		static IntPtr id_getInternalMediaPlayer;
		public virtual unsafe global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer InternalMediaPlayer {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getInternalMediaPlayer' and count(parameter)=0]"
			[Register ("getInternalMediaPlayer", "()Ltv/danmaku/ijk/media/player/IMediaPlayer;", "GetGetInternalMediaPlayerHandler")]
			get {
				if (id_getInternalMediaPlayer == IntPtr.Zero)
					id_getInternalMediaPlayer = JNIEnv.GetMethodID (class_ref, "getInternalMediaPlayer", "()Ltv/danmaku/ijk/media/player/IMediaPlayer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInternalMediaPlayer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInternalMediaPlayer", "()Ltv/danmaku/ijk/media/player/IMediaPlayer;")), JniHandleOwnership.TransferLocalRef);
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlayable;
		}
#pragma warning restore 0169

		static IntPtr id_isPlayable;
		public virtual unsafe bool IsPlayable {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='isPlayable' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		static IntPtr id_isPlaying;
		public virtual unsafe bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='isPlaying' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Looping = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isLooping;
		static IntPtr id_setLooping_Z;
		public virtual unsafe bool Looping {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='isLooping' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setLooping' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaInfo;
		public virtual unsafe global::TV.Danmaku.Ijk.Media.Player.MediaInfo MediaInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getMediaInfo' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoHeight;
		public virtual unsafe int VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getVideoHeight' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSarDen;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoSarDen;
		public virtual unsafe int VideoSarDen {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getVideoSarDen' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSarNum;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoSarNum;
		public virtual unsafe int VideoSarNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getVideoSarNum' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoWidth;
		public virtual unsafe int VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getVideoWidth' and count(parameter)=0]"
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTrackInfo ());
		}
#pragma warning restore 0169

		static IntPtr id_getTrackInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='getTrackInfo' and count(parameter)=0]"
		[Register ("getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/ITrackInfo;", "GetGetTrackInfoHandler")]
		public virtual unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.ITrackInfo[] GetTrackInfo ()
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareAsync ();
		}
#pragma warning restore 0169

		static IntPtr id_prepareAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='prepareAsync' and count(parameter)=0]"
		[Register ("prepareAsync", "()V", "GetPrepareAsyncHandler")]
		public virtual unsafe void PrepareAsync ()
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seekTo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler")]
		public virtual unsafe void SeekTo (long p0)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioStreamType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAudioStreamType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setAudioStreamType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioStreamType", "(I)V", "GetSetAudioStreamType_IHandler")]
		public virtual unsafe void SetAudioStreamType (int p0)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Handler")]
		public virtual unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V", "GetSetDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_Handler")]
		public virtual unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1, global::System.Collections.Generic.IDictionary<string, string> p2)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.FileDescriptor p0 = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Ljava_io_FileDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register ("setDataSource", "(Ljava/io/FileDescriptor;)V", "GetSetDataSource_Ljava_io_FileDescriptor_Handler")]
		public virtual unsafe void SetDataSource (global::Java.IO.FileDescriptor p0)
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

		static Delegate cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_;
#pragma warning disable 0169
		static Delegate GetSetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_Handler ()
		{
			if (cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ == null)
				cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_);
			return cb_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_;
		}

		static void n_SetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource p0 = (global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.misc.IMediaDataSource']]"
		[Register ("setDataSource", "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V", "GetSetDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_Handler")]
		public virtual unsafe void SetDataSource (global::TV.Danmaku.Ijk.Media.Player.Misc.IMediaDataSource p0)
		{
			if (id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ == IntPtr.Zero)
				id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ltv_danmaku_ijk_media_player_misc_IMediaDataSource_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDataSource", "(Ltv/danmaku/ijk/media/player/misc/IMediaDataSource;)V"), __args);
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplay_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setDisplay", "(Landroid/view/SurfaceHolder;)V", "GetSetDisplay_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SetDisplay (global::Android.Views.ISurfaceHolder p0)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepInBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setKeepInBackground_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setKeepInBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setKeepInBackground", "(Z)V", "GetSetKeepInBackground_ZHandler")]
		public virtual unsafe void SetKeepInBackground (bool p0)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setLogEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLogEnabled", "(Z)V", "GetSetLogEnabled_ZHandler")]
		public virtual unsafe void SetLogEnabled (bool p0)
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

		static Delegate cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_Handler ()
		{
			if (cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ == null)
				cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_);
			return cb_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_;
		}

		static void n_SetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnBufferingUpdateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnBufferingUpdateListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnBufferingUpdateListener']]"
		[Register ("setOnBufferingUpdateListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener;)V", "GetSetOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_Handler")]
		public virtual unsafe void SetOnBufferingUpdateListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener p0)
		{
			if (id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ == IntPtr.Zero)
				id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_ = JNIEnv.GetMethodID (class_ref, "setOnBufferingUpdateListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnBufferingUpdateListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnBufferingUpdateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnBufferingUpdateListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnBufferingUpdateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_Handler ()
		{
			if (cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ == null)
				cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_);
			return cb_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_;
		}

		static void n_SetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompletionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnCompletionListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnCompletionListener']]"
		[Register ("setOnCompletionListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener;)V", "GetSetOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_Handler")]
		public virtual unsafe void SetOnCompletionListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener p0)
		{
			if (id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ == IntPtr.Zero)
				id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_ = JNIEnv.GetMethodID (class_ref, "setOnCompletionListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCompletionListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnCompletionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCompletionListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnCompletionListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_;
#pragma warning disable 0169
		static Delegate GetSetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_Handler ()
		{
			if (cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ == null)
				cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_);
			return cb_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_;
		}

		static void n_SetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnErrorListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnErrorListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnErrorListener']]"
		[Register ("setOnErrorListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener;)V", "GetSetOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_Handler")]
		public virtual unsafe void SetOnErrorListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener p0)
		{
			if (id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ == IntPtr.Zero)
				id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_ = JNIEnv.GetMethodID (class_ref, "setOnErrorListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnErrorListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnErrorListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnErrorListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnErrorListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_Handler ()
		{
			if (cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ == null)
				cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_);
			return cb_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_;
		}

		static void n_SetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnInfoListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnInfoListener']]"
		[Register ("setOnInfoListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener;)V", "GetSetOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_Handler")]
		public virtual unsafe void SetOnInfoListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener p0)
		{
			if (id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ == IntPtr.Zero)
				id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_ = JNIEnv.GetMethodID (class_ref, "setOnInfoListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnInfoListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnInfoListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnInfoListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnInfoListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_Handler ()
		{
			if (cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ == null)
				cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_);
			return cb_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_;
		}

		static void n_SetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPreparedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnPreparedListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnPreparedListener']]"
		[Register ("setOnPreparedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener;)V", "GetSetOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_Handler")]
		public virtual unsafe void SetOnPreparedListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener p0)
		{
			if (id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ == IntPtr.Zero)
				id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_ = JNIEnv.GetMethodID (class_ref, "setOnPreparedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPreparedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnPreparedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPreparedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnPreparedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_Handler ()
		{
			if (cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ == null)
				cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_);
			return cb_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_;
		}

		static void n_SetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSeekCompleteListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnSeekCompleteListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnSeekCompleteListener']]"
		[Register ("setOnSeekCompleteListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener;)V", "GetSetOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_Handler")]
		public virtual unsafe void SetOnSeekCompleteListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener p0)
		{
			if (id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ == IntPtr.Zero)
				id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_ = JNIEnv.GetMethodID (class_ref, "setOnSeekCompleteListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSeekCompleteListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnSeekCompleteListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnSeekCompleteListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnSeekCompleteListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_Handler ()
		{
			if (cb_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_ == null)
				cb_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_);
			return cb_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_;
		}

		static void n_SetOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTimedTextListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnTimedTextListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnTimedTextListener']]"
		[Register ("setOnTimedTextListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnTimedTextListener;)V", "GetSetOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_Handler")]
		public virtual unsafe void SetOnTimedTextListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListener p0)
		{
			if (id_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_ == IntPtr.Zero)
				id_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_ = JNIEnv.GetMethodID (class_ref, "setOnTimedTextListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnTimedTextListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnTimedTextListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnTimedTextListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnTimedTextListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnTimedTextListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_Handler ()
		{
			if (cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ == null)
				cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_);
			return cb_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_;
		}

		static void n_SetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnVideoSizeChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setOnVideoSizeChangedListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer.OnVideoSizeChangedListener']]"
		[Register ("setOnVideoSizeChangedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener;)V", "GetSetOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_Handler")]
		public virtual unsafe void SetOnVideoSizeChangedListener (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener p0)
		{
			if (id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ == IntPtr.Zero)
				id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnVideoSizeChangedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnVideoSizeChangedListener_Ltv_danmaku_ijk_media_player_IMediaPlayer_OnVideoSizeChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnVideoSizeChangedListener", "(Ltv/danmaku/ijk/media/player/IMediaPlayer$OnVideoSizeChangedListener;)V"), __args);
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScreenOnWhilePlaying (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScreenOnWhilePlaying_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setScreenOnWhilePlaying' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScreenOnWhilePlaying", "(Z)V", "GetSetScreenOnWhilePlaying_ZHandler")]
		public virtual unsafe void SetScreenOnWhilePlaying (bool p0)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Surface p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurface (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSurface_Landroid_view_Surface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("setSurface", "(Landroid/view/Surface;)V", "GetSetSurface_Landroid_view_Surface_Handler")]
		public virtual unsafe void SetSurface (global::Android.Views.Surface p0)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setVolume_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setVolume' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setVolume", "(FF)V", "GetSetVolume_FFHandler")]
		public virtual unsafe void SetVolume (float p0, float p1)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWakeMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setWakeMode_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='setWakeMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setWakeMode", "(Landroid/content/Context;I)V", "GetSetWakeMode_Landroid_content_Context_IHandler")]
		public virtual unsafe void SetWakeMode (global::Android.Content.Context p0, int p1)
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
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
			global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='MediaPlayerProxy']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
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

#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnBufferingUpdateEventArgs> BufferingUpdate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListenerImplementor>(
						ref weak_implementor_SetOnBufferingUpdateListener,
						__CreateIMediaPlayerOnBufferingUpdateListenerImplementor,
						SetOnBufferingUpdateListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListenerImplementor>(
						ref weak_implementor_SetOnBufferingUpdateListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListenerImplementor.__IsEmpty,
						__v => SetOnBufferingUpdateListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnBufferingUpdateListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListenerImplementor __CreateIMediaPlayerOnBufferingUpdateListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnBufferingUpdateListenerImplementor (this);
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnCompletionEventArgs> Completion {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListenerImplementor>(
						ref weak_implementor_SetOnCompletionListener,
						__CreateIMediaPlayerOnCompletionListenerImplementor,
						SetOnCompletionListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListenerImplementor>(
						ref weak_implementor_SetOnCompletionListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListenerImplementor.__IsEmpty,
						__v => SetOnCompletionListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCompletionListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListenerImplementor __CreateIMediaPlayerOnCompletionListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnCompletionListenerImplementor (this);
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListenerImplementor>(
						ref weak_implementor_SetOnErrorListener,
						__CreateIMediaPlayerOnErrorListenerImplementor,
						SetOnErrorListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListenerImplementor>(
						ref weak_implementor_SetOnErrorListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListenerImplementor.__IsEmpty,
						__v => SetOnErrorListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnErrorListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListenerImplementor __CreateIMediaPlayerOnErrorListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnErrorListenerImplementor (this);
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnInfoEventArgs> Info {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListenerImplementor>(
						ref weak_implementor_SetOnInfoListener,
						__CreateIMediaPlayerOnInfoListenerImplementor,
						SetOnInfoListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListenerImplementor>(
						ref weak_implementor_SetOnInfoListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListenerImplementor.__IsEmpty,
						__v => SetOnInfoListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInfoListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListenerImplementor __CreateIMediaPlayerOnInfoListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnInfoListenerImplementor (this);
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnPreparedEventArgs> Prepared {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListenerImplementor>(
						ref weak_implementor_SetOnPreparedListener,
						__CreateIMediaPlayerOnPreparedListenerImplementor,
						SetOnPreparedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListenerImplementor>(
						ref weak_implementor_SetOnPreparedListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListenerImplementor.__IsEmpty,
						__v => SetOnPreparedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPreparedListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListenerImplementor __CreateIMediaPlayerOnPreparedListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnPreparedListenerImplementor (this);
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnSeekCompleteEventArgs> SeekComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListenerImplementor>(
						ref weak_implementor_SetOnSeekCompleteListener,
						__CreateIMediaPlayerOnSeekCompleteListenerImplementor,
						SetOnSeekCompleteListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListenerImplementor>(
						ref weak_implementor_SetOnSeekCompleteListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListenerImplementor.__IsEmpty,
						__v => SetOnSeekCompleteListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSeekCompleteListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListenerImplementor __CreateIMediaPlayerOnSeekCompleteListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnSeekCompleteListenerImplementor (this);
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnTimedTextEventArgs> TimedText {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListenerImplementor>(
						ref weak_implementor_SetOnTimedTextListener,
						__CreateIMediaPlayerOnTimedTextListenerImplementor,
						SetOnTimedTextListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListenerImplementor>(
						ref weak_implementor_SetOnTimedTextListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListenerImplementor.__IsEmpty,
						__v => SetOnTimedTextListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTimedTextListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListenerImplementor __CreateIMediaPlayerOnTimedTextListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnTimedTextListenerImplementor (this);
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.MediaPlayerOnVideoSizeChangedEventArgs> VideoSizeChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListenerImplementor>(
						ref weak_implementor_SetOnVideoSizeChangedListener,
						__CreateIMediaPlayerOnVideoSizeChangedListenerImplementor,
						SetOnVideoSizeChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListener, global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListenerImplementor>(
						ref weak_implementor_SetOnVideoSizeChangedListener,
						global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListenerImplementor.__IsEmpty,
						__v => SetOnVideoSizeChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnVideoSizeChangedListener;

		global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListenerImplementor __CreateIMediaPlayerOnVideoSizeChangedListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IMediaPlayerOnVideoSizeChangedListenerImplementor (this);
		}
#endregion
	}
}
