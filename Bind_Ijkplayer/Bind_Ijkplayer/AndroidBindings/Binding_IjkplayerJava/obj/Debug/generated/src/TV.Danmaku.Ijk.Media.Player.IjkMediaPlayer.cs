using System;
using System.Collections.Generic;
using Android.Runtime;

namespace TV.Danmaku.Ijk.Media.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']"
	[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer", DoNotGenerateAcw=true)]
	public sealed partial class IjkMediaPlayer : global::TV.Danmaku.Ijk.Media.Player.AbstractMediaPlayer {


		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROPV_DECODER_AVCODEC']"
		[Register ("FFP_PROPV_DECODER_AVCODEC")]
		public const int FfpPropvDecoderAvcodec = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROPV_DECODER_MEDIACODEC']"
		[Register ("FFP_PROPV_DECODER_MEDIACODEC")]
		public const int FfpPropvDecoderMediacodec = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROPV_DECODER_UNKNOWN']"
		[Register ("FFP_PROPV_DECODER_UNKNOWN")]
		public const int FfpPropvDecoderUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROPV_DECODER_VIDEOTOOLBOX']"
		[Register ("FFP_PROPV_DECODER_VIDEOTOOLBOX")]
		public const int FfpPropvDecoderVideotoolbox = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_FLOAT_DROP_FRAME_RATE']"
		[Register ("FFP_PROP_FLOAT_DROP_FRAME_RATE")]
		public const int FfpPropFloatDropFrameRate = (int) 10007;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_FLOAT_PLAYBACK_RATE']"
		[Register ("FFP_PROP_FLOAT_PLAYBACK_RATE")]
		public const int FfpPropFloatPlaybackRate = (int) 10003;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_ASYNC_STATISTIC_BUF_BACKWARDS']"
		[Register ("FFP_PROP_INT64_ASYNC_STATISTIC_BUF_BACKWARDS")]
		public const int FfpPropInt64AsyncStatisticBufBackwards = (int) 20201;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_ASYNC_STATISTIC_BUF_CAPACITY']"
		[Register ("FFP_PROP_INT64_ASYNC_STATISTIC_BUF_CAPACITY")]
		public const int FfpPropInt64AsyncStatisticBufCapacity = (int) 20203;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_ASYNC_STATISTIC_BUF_FORWARDS']"
		[Register ("FFP_PROP_INT64_ASYNC_STATISTIC_BUF_FORWARDS")]
		public const int FfpPropInt64AsyncStatisticBufForwards = (int) 20202;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_AUDIO_CACHED_BYTES']"
		[Register ("FFP_PROP_INT64_AUDIO_CACHED_BYTES")]
		public const int FfpPropInt64AudioCachedBytes = (int) 20008;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_AUDIO_CACHED_DURATION']"
		[Register ("FFP_PROP_INT64_AUDIO_CACHED_DURATION")]
		public const int FfpPropInt64AudioCachedDuration = (int) 20006;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_AUDIO_CACHED_PACKETS']"
		[Register ("FFP_PROP_INT64_AUDIO_CACHED_PACKETS")]
		public const int FfpPropInt64AudioCachedPackets = (int) 20010;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_AUDIO_DECODER']"
		[Register ("FFP_PROP_INT64_AUDIO_DECODER")]
		public const int FfpPropInt64AudioDecoder = (int) 20004;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_BIT_RATE']"
		[Register ("FFP_PROP_INT64_BIT_RATE")]
		public const int FfpPropInt64BitRate = (int) 20100;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_CACHE_STATISTIC_COUNT_BYTES']"
		[Register ("FFP_PROP_INT64_CACHE_STATISTIC_COUNT_BYTES")]
		public const int FfpPropInt64CacheStatisticCountBytes = (int) 20208;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_CACHE_STATISTIC_FILE_FORWARDS']"
		[Register ("FFP_PROP_INT64_CACHE_STATISTIC_FILE_FORWARDS")]
		public const int FfpPropInt64CacheStatisticFileForwards = (int) 20206;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_CACHE_STATISTIC_FILE_POS']"
		[Register ("FFP_PROP_INT64_CACHE_STATISTIC_FILE_POS")]
		public const int FfpPropInt64CacheStatisticFilePos = (int) 20207;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_CACHE_STATISTIC_PHYSICAL_POS']"
		[Register ("FFP_PROP_INT64_CACHE_STATISTIC_PHYSICAL_POS")]
		public const int FfpPropInt64CacheStatisticPhysicalPos = (int) 20205;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_IMMEDIATE_RECONNECT']"
		[Register ("FFP_PROP_INT64_IMMEDIATE_RECONNECT")]
		public const int FfpPropInt64ImmediateReconnect = (int) 20211;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_LATEST_SEEK_LOAD_DURATION']"
		[Register ("FFP_PROP_INT64_LATEST_SEEK_LOAD_DURATION")]
		public const int FfpPropInt64LatestSeekLoadDuration = (int) 20300;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_LOGICAL_FILE_SIZE']"
		[Register ("FFP_PROP_INT64_LOGICAL_FILE_SIZE")]
		public const int FfpPropInt64LogicalFileSize = (int) 20209;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_SELECTED_AUDIO_STREAM']"
		[Register ("FFP_PROP_INT64_SELECTED_AUDIO_STREAM")]
		public const int FfpPropInt64SelectedAudioStream = (int) 20002;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_SELECTED_TIMEDTEXT_STREAM']"
		[Register ("FFP_PROP_INT64_SELECTED_TIMEDTEXT_STREAM")]
		public const int FfpPropInt64SelectedTimedtextStream = (int) 20011;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_SELECTED_VIDEO_STREAM']"
		[Register ("FFP_PROP_INT64_SELECTED_VIDEO_STREAM")]
		public const int FfpPropInt64SelectedVideoStream = (int) 20001;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_SHARE_CACHE_DATA']"
		[Register ("FFP_PROP_INT64_SHARE_CACHE_DATA")]
		public const int FfpPropInt64ShareCacheData = (int) 20210;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_TCP_SPEED']"
		[Register ("FFP_PROP_INT64_TCP_SPEED")]
		public const int FfpPropInt64TcpSpeed = (int) 20200;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_TRAFFIC_STATISTIC_BYTE_COUNT']"
		[Register ("FFP_PROP_INT64_TRAFFIC_STATISTIC_BYTE_COUNT")]
		public const int FfpPropInt64TrafficStatisticByteCount = (int) 20204;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_VIDEO_CACHED_BYTES']"
		[Register ("FFP_PROP_INT64_VIDEO_CACHED_BYTES")]
		public const int FfpPropInt64VideoCachedBytes = (int) 20007;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_VIDEO_CACHED_DURATION']"
		[Register ("FFP_PROP_INT64_VIDEO_CACHED_DURATION")]
		public const int FfpPropInt64VideoCachedDuration = (int) 20005;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_VIDEO_CACHED_PACKETS']"
		[Register ("FFP_PROP_INT64_VIDEO_CACHED_PACKETS")]
		public const int FfpPropInt64VideoCachedPackets = (int) 20009;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='FFP_PROP_INT64_VIDEO_DECODER']"
		[Register ("FFP_PROP_INT64_VIDEO_DECODER")]
		public const int FfpPropInt64VideoDecoder = (int) 20003;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_DEBUG']"
		[Register ("IJK_LOG_DEBUG")]
		public const int IjkLogDebug = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_DEFAULT']"
		[Register ("IJK_LOG_DEFAULT")]
		public const int IjkLogDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_ERROR']"
		[Register ("IJK_LOG_ERROR")]
		public const int IjkLogError = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_FATAL']"
		[Register ("IJK_LOG_FATAL")]
		public const int IjkLogFatal = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_INFO']"
		[Register ("IJK_LOG_INFO")]
		public const int IjkLogInfo = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_SILENT']"
		[Register ("IJK_LOG_SILENT")]
		public const int IjkLogSilent = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_UNKNOWN']"
		[Register ("IJK_LOG_UNKNOWN")]
		public const int IjkLogUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_VERBOSE']"
		[Register ("IJK_LOG_VERBOSE")]
		public const int IjkLogVerbose = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='IJK_LOG_WARN']"
		[Register ("IJK_LOG_WARN")]
		public const int IjkLogWarn = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='MEDIA_SET_VIDEO_SAR']"
		[Register ("MEDIA_SET_VIDEO_SAR")]
		protected const int MediaSetVideoSar = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='OPT_CATEGORY_CODEC']"
		[Register ("OPT_CATEGORY_CODEC")]
		public const int OptCategoryCodec = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='OPT_CATEGORY_FORMAT']"
		[Register ("OPT_CATEGORY_FORMAT")]
		public const int OptCategoryFormat = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='OPT_CATEGORY_PLAYER']"
		[Register ("OPT_CATEGORY_PLAYER")]
		public const int OptCategoryPlayer = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='OPT_CATEGORY_SWS']"
		[Register ("OPT_CATEGORY_SWS")]
		public const int OptCategorySws = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='PROP_FLOAT_VIDEO_DECODE_FRAMES_PER_SECOND']"
		[Register ("PROP_FLOAT_VIDEO_DECODE_FRAMES_PER_SECOND")]
		public const int PropFloatVideoDecodeFramesPerSecond = (int) 10001;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='PROP_FLOAT_VIDEO_OUTPUT_FRAMES_PER_SECOND']"
		[Register ("PROP_FLOAT_VIDEO_OUTPUT_FRAMES_PER_SECOND")]
		public const int PropFloatVideoOutputFramesPerSecond = (int) 10002;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='SDL_FCC_RV16']"
		[Register ("SDL_FCC_RV16")]
		public const int SdlFccRv16 = (int) 909203026;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='SDL_FCC_RV32']"
		[Register ("SDL_FCC_RV32")]
		public const int SdlFccRv32 = (int) 842225234;

		// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/field[@name='SDL_FCC_YV12']"
		[Register ("SDL_FCC_YV12")]
		public const int SdlFccYv12 = (int) 842094169;
		// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer.DefaultMediaCodecSelector']"
		[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$DefaultMediaCodecSelector", DoNotGenerateAcw=true)]
		public partial class DefaultMediaCodecSelector : global::Java.Lang.Object, global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListener {


			static IntPtr sInstance_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer.DefaultMediaCodecSelector']/field[@name='sInstance']"
			[Register ("sInstance")]
			public static global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.DefaultMediaCodecSelector SInstance {
				get {
					if (sInstance_jfieldId == IntPtr.Zero)
						sInstance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sInstance", "Ltv/danmaku/ijk/media/player/IjkMediaPlayer$DefaultMediaCodecSelector;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sInstance_jfieldId);
					return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.DefaultMediaCodecSelector> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkMediaPlayer$DefaultMediaCodecSelector", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultMediaCodecSelector); }
			}

			protected DefaultMediaCodecSelector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer.DefaultMediaCodecSelector']/constructor[@name='IjkMediaPlayer.DefaultMediaCodecSelector' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DefaultMediaCodecSelector ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (DefaultMediaCodecSelector)) {
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

			static Delegate cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II;
#pragma warning disable 0169
			static Delegate GetOnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_IIHandler ()
			{
				if (cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II == null)
					cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_OnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II);
				return cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II;
			}

			static IntPtr n_OnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
			{
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.DefaultMediaCodecSelector __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.DefaultMediaCodecSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.OnMediaCodecSelect (p0, p1, p2, p3));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer.DefaultMediaCodecSelector']/method[@name='onMediaCodecSelect' and count(parameter)=4 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onMediaCodecSelect", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;Ljava/lang/String;II)Ljava/lang/String;", "GetOnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_IIHandler")]
			public virtual unsafe string OnMediaCodecSelect (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, string p1, int p2, int p3)
			{
				if (id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II == IntPtr.Zero)
					id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onMediaCodecSelect", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;Ljava/lang/String;II)Ljava/lang/String;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					string __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMediaCodecSelect", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;Ljava/lang/String;II)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer.EventHandler']"
		[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$EventHandler", DoNotGenerateAcw=true)]
		public partial class EventHandler : global::Android.OS.Handler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkMediaPlayer$EventHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EventHandler); }
			}

			protected EventHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_Landroid_os_Looper_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer.EventHandler']/constructor[@name='IjkMediaPlayer.EventHandler' and count(parameter)=2 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkMediaPlayer'] and parameter[2][@type='android.os.Looper']]"
			[Register (".ctor", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer;Landroid/os/Looper;)V", "")]
			public unsafe EventHandler (global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer p0, global::Android.OS.Looper p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (EventHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer;Landroid/os/Looper;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer;Landroid/os/Looper;)V", __args);
						return;
					}

					if (id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_Landroid_os_Looper_ == IntPtr.Zero)
						id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer;Landroid/os/Looper;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_Landroid_os_Looper_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_Landroid_os_Looper_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnControlMessageListener']"
		[Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnControlMessageListener", "", "TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer/IOnControlMessageListenerInvoker")]
		public partial interface IOnControlMessageListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnControlMessageListener']/method[@name='onControlResolveSegmentUrl' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onControlResolveSegmentUrl", "(I)Ljava/lang/String;", "GetOnControlResolveSegmentUrl_IHandler:TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer/IOnControlMessageListenerInvoker, Binding_IjkplayerJava")]
			string OnControlResolveSegmentUrl (int p0);

		}

		[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnControlMessageListener", DoNotGenerateAcw=true)]
		internal class IOnControlMessageListenerInvoker : global::Java.Lang.Object, IOnControlMessageListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnControlMessageListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnControlMessageListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnControlMessageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnControlMessageListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IjkMediaPlayer.OnControlMessageListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnControlMessageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onControlResolveSegmentUrl_I;
#pragma warning disable 0169
			static Delegate GetOnControlResolveSegmentUrl_IHandler ()
			{
				if (cb_onControlResolveSegmentUrl_I == null)
					cb_onControlResolveSegmentUrl_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_OnControlResolveSegmentUrl_I);
				return cb_onControlResolveSegmentUrl_I;
			}

			static IntPtr n_OnControlResolveSegmentUrl_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.OnControlResolveSegmentUrl (p0));
			}
#pragma warning restore 0169

			IntPtr id_onControlResolveSegmentUrl_I;
			public unsafe string OnControlResolveSegmentUrl (int p0)
			{
				if (id_onControlResolveSegmentUrl_I == IntPtr.Zero)
					id_onControlResolveSegmentUrl_I = JNIEnv.GetMethodID (class_ref, "onControlResolveSegmentUrl", "(I)Ljava/lang/String;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onControlResolveSegmentUrl_I, __args), JniHandleOwnership.TransferLocalRef);
			}

		}

		public delegate string ControlMessageHandler (int p0);

		[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IjkMediaPlayer_OnControlMessageListenerImplementor")]
		internal sealed partial class IOnControlMessageListenerImplementor : global::Java.Lang.Object, IOnControlMessageListener {

			public IOnControlMessageListenerImplementor ()
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IjkMediaPlayer_OnControlMessageListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			}

#pragma warning disable 0649
			public ControlMessageHandler Handler;
#pragma warning restore 0649

			public string OnControlResolveSegmentUrl (int p0)
			{
				var __h = Handler;
				return __h != null ? __h (p0) : default (string);
			}

			internal static bool __IsEmpty (IOnControlMessageListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnMediaCodecSelectListener']"
		[Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnMediaCodecSelectListener", "", "TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer/IOnMediaCodecSelectListenerInvoker")]
		public partial interface IOnMediaCodecSelectListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnMediaCodecSelectListener']/method[@name='onMediaCodecSelect' and count(parameter)=4 and parameter[1][@type='tv.danmaku.ijk.media.player.IMediaPlayer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onMediaCodecSelect", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;Ljava/lang/String;II)Ljava/lang/String;", "GetOnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_IIHandler:TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer/IOnMediaCodecSelectListenerInvoker, Binding_IjkplayerJava")]
			string OnMediaCodecSelect (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, string p1, int p2, int p3);

		}

		[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnMediaCodecSelectListener", DoNotGenerateAcw=true)]
		internal class IOnMediaCodecSelectListenerInvoker : global::Java.Lang.Object, IOnMediaCodecSelectListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnMediaCodecSelectListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnMediaCodecSelectListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnMediaCodecSelectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMediaCodecSelectListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IjkMediaPlayer.OnMediaCodecSelectListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMediaCodecSelectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II;
#pragma warning disable 0169
			static Delegate GetOnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_IIHandler ()
			{
				if (cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II == null)
					cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_OnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II);
				return cb_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II;
			}

			static IntPtr n_OnMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
			{
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0 = (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer)global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.OnMediaCodecSelect (p0, p1, p2, p3));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II;
			public unsafe string OnMediaCodecSelect (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, string p1, int p2, int p3)
			{
				if (id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II == IntPtr.Zero)
					id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onMediaCodecSelect", "(Ltv/danmaku/ijk/media/player/IMediaPlayer;Ljava/lang/String;II)Ljava/lang/String;");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onMediaCodecSelect_Ltv_danmaku_ijk_media_player_IMediaPlayer_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

		}

		public delegate string MediaCodecSelectHandler (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, string p1, int p2, int p3);

		[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IjkMediaPlayer_OnMediaCodecSelectListenerImplementor")]
		internal sealed partial class IOnMediaCodecSelectListenerImplementor : global::Java.Lang.Object, IOnMediaCodecSelectListener {

			public IOnMediaCodecSelectListenerImplementor ()
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IjkMediaPlayer_OnMediaCodecSelectListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			}

#pragma warning disable 0649
			public MediaCodecSelectHandler Handler;
#pragma warning restore 0649

			public string OnMediaCodecSelect (global::TV.Danmaku.Ijk.Media.Player.IMediaPlayer p0, string p1, int p2, int p3)
			{
				var __h = Handler;
				return __h != null ? __h (p0, p1, p2, p3) : default (string);
			}

			internal static bool __IsEmpty (IOnMediaCodecSelectListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnNativeInvokeListener", DoNotGenerateAcw=true)]
		public abstract class OnNativeInvokeListener : Java.Lang.Object {

			internal OnNativeInvokeListener ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_ERROR']"
			[Register ("ARG_ERROR")]
			public const string ArgError = (string) "error";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_FAMILIY']"
			[Register ("ARG_FAMILIY")]
			public const string ArgFamiliy = (string) "family";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_FD']"
			[Register ("ARG_FD")]
			public const string ArgFd = (string) "fd";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_FILE_SIZE']"
			[Register ("ARG_FILE_SIZE")]
			public const string ArgFileSize = (string) "file_size";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_HTTP_CODE']"
			[Register ("ARG_HTTP_CODE")]
			public const string ArgHttpCode = (string) "http_code";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_IP']"
			[Register ("ARG_IP")]
			public const string ArgIp = (string) "ip";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_OFFSET']"
			[Register ("ARG_OFFSET")]
			public const string ArgOffset = (string) "offset";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_PORT']"
			[Register ("ARG_PORT")]
			public const string ArgPort = (string) "port";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_RETRY_COUNTER']"
			[Register ("ARG_RETRY_COUNTER")]
			public const string ArgRetryCounter = (string) "retry_counter";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_SEGMENT_INDEX']"
			[Register ("ARG_SEGMENT_INDEX")]
			public const string ArgSegmentIndex = (string) "segment_index";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='ARG_URL']"
			[Register ("ARG_URL")]
			public const string ArgUrl = (string) "url";

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='CTRL_DID_TCP_OPEN']"
			[Register ("CTRL_DID_TCP_OPEN")]
			public const int CtrlDidTcpOpen = (int) 131074;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='CTRL_WILL_CONCAT_RESOLVE_SEGMENT']"
			[Register ("CTRL_WILL_CONCAT_RESOLVE_SEGMENT")]
			public const int CtrlWillConcatResolveSegment = (int) 131079;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='CTRL_WILL_HTTP_OPEN']"
			[Register ("CTRL_WILL_HTTP_OPEN")]
			public const int CtrlWillHttpOpen = (int) 131075;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='CTRL_WILL_LIVE_OPEN']"
			[Register ("CTRL_WILL_LIVE_OPEN")]
			public const int CtrlWillLiveOpen = (int) 131077;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='CTRL_WILL_TCP_OPEN']"
			[Register ("CTRL_WILL_TCP_OPEN")]
			public const int CtrlWillTcpOpen = (int) 131073;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='EVENT_DID_HTTP_OPEN']"
			[Register ("EVENT_DID_HTTP_OPEN")]
			public const int EventDidHttpOpen = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='EVENT_DID_HTTP_SEEK']"
			[Register ("EVENT_DID_HTTP_SEEK")]
			public const int EventDidHttpSeek = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='EVENT_WILL_HTTP_OPEN']"
			[Register ("EVENT_WILL_HTTP_OPEN")]
			public const int EventWillHttpOpen = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/field[@name='EVENT_WILL_HTTP_SEEK']"
			[Register ("EVENT_WILL_HTTP_SEEK")]
			public const int EventWillHttpSeek = (int) 3;
		}

		[Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnNativeInvokeListener", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'OnNativeInvokeListener' type. This type will be removed in a future release.")]
		public abstract class OnNativeInvokeListenerConsts : OnNativeInvokeListener {

			private OnNativeInvokeListenerConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']"
		[Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnNativeInvokeListener", "", "TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer/IOnNativeInvokeListenerInvoker")]
		public partial interface IOnNativeInvokeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/interface[@name='IjkMediaPlayer.OnNativeInvokeListener']/method[@name='onNativeInvoke' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("onNativeInvoke", "(ILandroid/os/Bundle;)Z", "GetOnNativeInvoke_ILandroid_os_Bundle_Handler:TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer/IOnNativeInvokeListenerInvoker, Binding_IjkplayerJava")]
			bool OnNativeInvoke (int p0, global::Android.OS.Bundle p1);

		}

		[global::Android.Runtime.Register ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnNativeInvokeListener", DoNotGenerateAcw=true)]
		internal class IOnNativeInvokeListenerInvoker : global::Java.Lang.Object, IOnNativeInvokeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkMediaPlayer$OnNativeInvokeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnNativeInvokeListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnNativeInvokeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnNativeInvokeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "tv.danmaku.ijk.media.player.IjkMediaPlayer.OnNativeInvokeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnNativeInvokeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onNativeInvoke_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnNativeInvoke_ILandroid_os_Bundle_Handler ()
			{
				if (cb_onNativeInvoke_ILandroid_os_Bundle_ == null)
					cb_onNativeInvoke_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnNativeInvoke_ILandroid_os_Bundle_);
				return cb_onNativeInvoke_ILandroid_os_Bundle_;
			}

			static bool n_OnNativeInvoke_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListener __this = global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnNativeInvoke (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onNativeInvoke_ILandroid_os_Bundle_;
			public unsafe bool OnNativeInvoke (int p0, global::Android.OS.Bundle p1)
			{
				if (id_onNativeInvoke_ILandroid_os_Bundle_ == IntPtr.Zero)
					id_onNativeInvoke_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onNativeInvoke", "(ILandroid/os/Bundle;)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onNativeInvoke_ILandroid_os_Bundle_, __args);
				return __ret;
			}

		}

		public partial class NativeInvokeEventArgs : global::System.EventArgs {

			public NativeInvokeEventArgs (bool handled, int p0, global::Android.OS.Bundle p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Android.OS.Bundle p1;
			public global::Android.OS.Bundle P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/tv/danmaku/ijk/media/player/IjkMediaPlayer_OnNativeInvokeListenerImplementor")]
		internal sealed partial class IOnNativeInvokeListenerImplementor : global::Java.Lang.Object, IOnNativeInvokeListener {

			object sender;

			public IOnNativeInvokeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/tv/danmaku/ijk/media/player/IjkMediaPlayer_OnNativeInvokeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NativeInvokeEventArgs> Handler;
#pragma warning restore 0649

			public bool OnNativeInvoke (int p0, global::Android.OS.Bundle p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new NativeInvokeEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnNativeInvokeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("tv/danmaku/ijk/media/player/IjkMediaPlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IjkMediaPlayer); }
		}

		internal IjkMediaPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ltv_danmaku_ijk_media_player_IjkLibLoader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/constructor[@name='IjkMediaPlayer' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkLibLoader']]"
		[Register (".ctor", "(Ltv/danmaku/ijk/media/player/IjkLibLoader;)V", "")]
		public unsafe IjkMediaPlayer (global::TV.Danmaku.Ijk.Media.Player.IIjkLibLoader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (IjkMediaPlayer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ltv/danmaku/ijk/media/player/IjkLibLoader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ltv/danmaku/ijk/media/player/IjkLibLoader;)V", __args);
					return;
				}

				if (id_ctor_Ltv_danmaku_ijk_media_player_IjkLibLoader_ == IntPtr.Zero)
					id_ctor_Ltv_danmaku_ijk_media_player_IjkLibLoader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ltv/danmaku/ijk/media/player/IjkLibLoader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IjkLibLoader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ltv_danmaku_ijk_media_player_IjkLibLoader_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/constructor[@name='IjkMediaPlayer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IjkMediaPlayer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IjkMediaPlayer)) {
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

		static IntPtr id_getAsyncStatisticBufBackwards;
		public unsafe long AsyncStatisticBufBackwards {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getAsyncStatisticBufBackwards' and count(parameter)=0]"
			[Register ("getAsyncStatisticBufBackwards", "()J", "GetGetAsyncStatisticBufBackwardsHandler")]
			get {
				if (id_getAsyncStatisticBufBackwards == IntPtr.Zero)
					id_getAsyncStatisticBufBackwards = JNIEnv.GetMethodID (class_ref, "getAsyncStatisticBufBackwards", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAsyncStatisticBufBackwards);
				} finally {
				}
			}
		}

		static IntPtr id_getAsyncStatisticBufCapacity;
		public unsafe long AsyncStatisticBufCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getAsyncStatisticBufCapacity' and count(parameter)=0]"
			[Register ("getAsyncStatisticBufCapacity", "()J", "GetGetAsyncStatisticBufCapacityHandler")]
			get {
				if (id_getAsyncStatisticBufCapacity == IntPtr.Zero)
					id_getAsyncStatisticBufCapacity = JNIEnv.GetMethodID (class_ref, "getAsyncStatisticBufCapacity", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAsyncStatisticBufCapacity);
				} finally {
				}
			}
		}

		static IntPtr id_getAsyncStatisticBufForwards;
		public unsafe long AsyncStatisticBufForwards {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getAsyncStatisticBufForwards' and count(parameter)=0]"
			[Register ("getAsyncStatisticBufForwards", "()J", "GetGetAsyncStatisticBufForwardsHandler")]
			get {
				if (id_getAsyncStatisticBufForwards == IntPtr.Zero)
					id_getAsyncStatisticBufForwards = JNIEnv.GetMethodID (class_ref, "getAsyncStatisticBufForwards", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAsyncStatisticBufForwards);
				} finally {
				}
			}
		}

		static IntPtr id_getAudioCachedBytes;
		public unsafe long AudioCachedBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getAudioCachedBytes' and count(parameter)=0]"
			[Register ("getAudioCachedBytes", "()J", "GetGetAudioCachedBytesHandler")]
			get {
				if (id_getAudioCachedBytes == IntPtr.Zero)
					id_getAudioCachedBytes = JNIEnv.GetMethodID (class_ref, "getAudioCachedBytes", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAudioCachedBytes);
				} finally {
				}
			}
		}

		static IntPtr id_getAudioCachedDuration;
		public unsafe long AudioCachedDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getAudioCachedDuration' and count(parameter)=0]"
			[Register ("getAudioCachedDuration", "()J", "GetGetAudioCachedDurationHandler")]
			get {
				if (id_getAudioCachedDuration == IntPtr.Zero)
					id_getAudioCachedDuration = JNIEnv.GetMethodID (class_ref, "getAudioCachedDuration", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAudioCachedDuration);
				} finally {
				}
			}
		}

		static IntPtr id_getAudioCachedPackets;
		public unsafe long AudioCachedPackets {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getAudioCachedPackets' and count(parameter)=0]"
			[Register ("getAudioCachedPackets", "()J", "GetGetAudioCachedPacketsHandler")]
			get {
				if (id_getAudioCachedPackets == IntPtr.Zero)
					id_getAudioCachedPackets = JNIEnv.GetMethodID (class_ref, "getAudioCachedPackets", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAudioCachedPackets);
				} finally {
				}
			}
		}

		static IntPtr id_getAudioSessionId;
		public override unsafe int AudioSessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getAudioSessionId' and count(parameter)=0]"
			[Register ("getAudioSessionId", "()I", "GetGetAudioSessionIdHandler")]
			get {
				if (id_getAudioSessionId == IntPtr.Zero)
					id_getAudioSessionId = JNIEnv.GetMethodID (class_ref, "getAudioSessionId", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAudioSessionId);
				} finally {
				}
			}
		}

		static IntPtr id_getBitRate;
		public unsafe long BitRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getBitRate' and count(parameter)=0]"
			[Register ("getBitRate", "()J", "GetGetBitRateHandler")]
			get {
				if (id_getBitRate == IntPtr.Zero)
					id_getBitRate = JNIEnv.GetMethodID (class_ref, "getBitRate", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBitRate);
				} finally {
				}
			}
		}

		static IntPtr id_getCacheStatisticCountBytes;
		public unsafe long CacheStatisticCountBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getCacheStatisticCountBytes' and count(parameter)=0]"
			[Register ("getCacheStatisticCountBytes", "()J", "GetGetCacheStatisticCountBytesHandler")]
			get {
				if (id_getCacheStatisticCountBytes == IntPtr.Zero)
					id_getCacheStatisticCountBytes = JNIEnv.GetMethodID (class_ref, "getCacheStatisticCountBytes", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCacheStatisticCountBytes);
				} finally {
				}
			}
		}

		static IntPtr id_getCacheStatisticFileForwards;
		public unsafe long CacheStatisticFileForwards {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getCacheStatisticFileForwards' and count(parameter)=0]"
			[Register ("getCacheStatisticFileForwards", "()J", "GetGetCacheStatisticFileForwardsHandler")]
			get {
				if (id_getCacheStatisticFileForwards == IntPtr.Zero)
					id_getCacheStatisticFileForwards = JNIEnv.GetMethodID (class_ref, "getCacheStatisticFileForwards", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCacheStatisticFileForwards);
				} finally {
				}
			}
		}

		static IntPtr id_getCacheStatisticFilePos;
		public unsafe long CacheStatisticFilePos {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getCacheStatisticFilePos' and count(parameter)=0]"
			[Register ("getCacheStatisticFilePos", "()J", "GetGetCacheStatisticFilePosHandler")]
			get {
				if (id_getCacheStatisticFilePos == IntPtr.Zero)
					id_getCacheStatisticFilePos = JNIEnv.GetMethodID (class_ref, "getCacheStatisticFilePos", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCacheStatisticFilePos);
				} finally {
				}
			}
		}

		static IntPtr id_getCacheStatisticPhysicalPos;
		public unsafe long CacheStatisticPhysicalPos {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getCacheStatisticPhysicalPos' and count(parameter)=0]"
			[Register ("getCacheStatisticPhysicalPos", "()J", "GetGetCacheStatisticPhysicalPosHandler")]
			get {
				if (id_getCacheStatisticPhysicalPos == IntPtr.Zero)
					id_getCacheStatisticPhysicalPos = JNIEnv.GetMethodID (class_ref, "getCacheStatisticPhysicalPos", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCacheStatisticPhysicalPos);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentPosition;
		public override unsafe long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler")]
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
				} finally {
				}
			}
		}

		static IntPtr id_getDataSource;
		static IntPtr id_setDataSource_Ljava_lang_String_;
		public override unsafe string DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Ljava/lang/String;", "GetGetDataSourceHandler")]
			get {
				if (id_getDataSource == IntPtr.Zero)
					id_getDataSource = JNIEnv.GetMethodID (class_ref, "getDataSource", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataSource), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDataSource", "(Ljava/lang/String;)V", "GetSetDataSource_Ljava_lang_String_Handler")]
			set {
				if (id_setDataSource_Ljava_lang_String_ == IntPtr.Zero)
					id_setDataSource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getDropFrameRate;
		public unsafe float DropFrameRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getDropFrameRate' and count(parameter)=0]"
			[Register ("getDropFrameRate", "()F", "GetGetDropFrameRateHandler")]
			get {
				if (id_getDropFrameRate == IntPtr.Zero)
					id_getDropFrameRate = JNIEnv.GetMethodID (class_ref, "getDropFrameRate", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getDropFrameRate);
				} finally {
				}
			}
		}

		static IntPtr id_getDuration;
		public override unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
				} finally {
				}
			}
		}

		static IntPtr id_getFileSize;
		public unsafe long FileSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getFileSize' and count(parameter)=0]"
			[Register ("getFileSize", "()J", "GetGetFileSizeHandler")]
			get {
				if (id_getFileSize == IntPtr.Zero)
					id_getFileSize = JNIEnv.GetMethodID (class_ref, "getFileSize", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFileSize);
				} finally {
				}
			}
		}

		static IntPtr id_isPlayable;
		public override unsafe bool IsPlayable {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='isPlayable' and count(parameter)=0]"
			[Register ("isPlayable", "()Z", "GetIsPlayableHandler")]
			get {
				if (id_isPlayable == IntPtr.Zero)
					id_isPlayable = JNIEnv.GetMethodID (class_ref, "isPlayable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlayable);
				} finally {
				}
			}
		}

		static IntPtr id_isPlaying;
		public override unsafe bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler")]
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
				} finally {
				}
			}
		}

		static IntPtr id_isLooping;
		static IntPtr id_setLooping_Z;
		public override unsafe bool Looping {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='isLooping' and count(parameter)=0]"
			[Register ("isLooping", "()Z", "GetIsLoopingHandler")]
			get {
				if (id_isLooping == IntPtr.Zero)
					id_isLooping = JNIEnv.GetMethodID (class_ref, "isLooping", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLooping);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setLooping' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLooping", "(Z)V", "GetSetLooping_ZHandler")]
			set {
				if (id_setLooping_Z == IntPtr.Zero)
					id_setLooping_Z = JNIEnv.GetMethodID (class_ref, "setLooping", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLooping_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMediaInfo;
		public override unsafe global::TV.Danmaku.Ijk.Media.Player.MediaInfo MediaInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getMediaInfo' and count(parameter)=0]"
			[Register ("getMediaInfo", "()Ltv/danmaku/ijk/media/player/MediaInfo;", "GetGetMediaInfoHandler")]
			get {
				if (id_getMediaInfo == IntPtr.Zero)
					id_getMediaInfo = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "()Ltv/danmaku/ijk/media/player/MediaInfo;");
				try {
					return global::Java.Lang.Object.GetObject<global::TV.Danmaku.Ijk.Media.Player.MediaInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMediaMeta;
		public unsafe global::Android.OS.Bundle MediaMeta {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getMediaMeta' and count(parameter)=0]"
			[Register ("getMediaMeta", "()Landroid/os/Bundle;", "GetGetMediaMetaHandler")]
			get {
				if (id_getMediaMeta == IntPtr.Zero)
					id_getMediaMeta = JNIEnv.GetMethodID (class_ref, "getMediaMeta", "()Landroid/os/Bundle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaMeta), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSeekLoadDuration;
		public unsafe long SeekLoadDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getSeekLoadDuration' and count(parameter)=0]"
			[Register ("getSeekLoadDuration", "()J", "GetGetSeekLoadDurationHandler")]
			get {
				if (id_getSeekLoadDuration == IntPtr.Zero)
					id_getSeekLoadDuration = JNIEnv.GetMethodID (class_ref, "getSeekLoadDuration", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSeekLoadDuration);
				} finally {
				}
			}
		}

		static IntPtr id_getTcpSpeed;
		public unsafe long TcpSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getTcpSpeed' and count(parameter)=0]"
			[Register ("getTcpSpeed", "()J", "GetGetTcpSpeedHandler")]
			get {
				if (id_getTcpSpeed == IntPtr.Zero)
					id_getTcpSpeed = JNIEnv.GetMethodID (class_ref, "getTcpSpeed", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTcpSpeed);
				} finally {
				}
			}
		}

		static IntPtr id_getTrafficStatisticByteCount;
		public unsafe long TrafficStatisticByteCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getTrafficStatisticByteCount' and count(parameter)=0]"
			[Register ("getTrafficStatisticByteCount", "()J", "GetGetTrafficStatisticByteCountHandler")]
			get {
				if (id_getTrafficStatisticByteCount == IntPtr.Zero)
					id_getTrafficStatisticByteCount = JNIEnv.GetMethodID (class_ref, "getTrafficStatisticByteCount", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTrafficStatisticByteCount);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoCachedBytes;
		public unsafe long VideoCachedBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoCachedBytes' and count(parameter)=0]"
			[Register ("getVideoCachedBytes", "()J", "GetGetVideoCachedBytesHandler")]
			get {
				if (id_getVideoCachedBytes == IntPtr.Zero)
					id_getVideoCachedBytes = JNIEnv.GetMethodID (class_ref, "getVideoCachedBytes", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoCachedBytes);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoCachedDuration;
		public unsafe long VideoCachedDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoCachedDuration' and count(parameter)=0]"
			[Register ("getVideoCachedDuration", "()J", "GetGetVideoCachedDurationHandler")]
			get {
				if (id_getVideoCachedDuration == IntPtr.Zero)
					id_getVideoCachedDuration = JNIEnv.GetMethodID (class_ref, "getVideoCachedDuration", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoCachedDuration);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoCachedPackets;
		public unsafe long VideoCachedPackets {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoCachedPackets' and count(parameter)=0]"
			[Register ("getVideoCachedPackets", "()J", "GetGetVideoCachedPacketsHandler")]
			get {
				if (id_getVideoCachedPackets == IntPtr.Zero)
					id_getVideoCachedPackets = JNIEnv.GetMethodID (class_ref, "getVideoCachedPackets", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoCachedPackets);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoDecodeFramesPerSecond;
		public unsafe float VideoDecodeFramesPerSecond {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoDecodeFramesPerSecond' and count(parameter)=0]"
			[Register ("getVideoDecodeFramesPerSecond", "()F", "GetGetVideoDecodeFramesPerSecondHandler")]
			get {
				if (id_getVideoDecodeFramesPerSecond == IntPtr.Zero)
					id_getVideoDecodeFramesPerSecond = JNIEnv.GetMethodID (class_ref, "getVideoDecodeFramesPerSecond", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getVideoDecodeFramesPerSecond);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoDecoder;
		public unsafe int VideoDecoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoDecoder' and count(parameter)=0]"
			[Register ("getVideoDecoder", "()I", "GetGetVideoDecoderHandler")]
			get {
				if (id_getVideoDecoder == IntPtr.Zero)
					id_getVideoDecoder = JNIEnv.GetMethodID (class_ref, "getVideoDecoder", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoDecoder);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoHeight;
		public override unsafe int VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoHeight' and count(parameter)=0]"
			[Register ("getVideoHeight", "()I", "GetGetVideoHeightHandler")]
			get {
				if (id_getVideoHeight == IntPtr.Zero)
					id_getVideoHeight = JNIEnv.GetMethodID (class_ref, "getVideoHeight", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoOutputFramesPerSecond;
		public unsafe float VideoOutputFramesPerSecond {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoOutputFramesPerSecond' and count(parameter)=0]"
			[Register ("getVideoOutputFramesPerSecond", "()F", "GetGetVideoOutputFramesPerSecondHandler")]
			get {
				if (id_getVideoOutputFramesPerSecond == IntPtr.Zero)
					id_getVideoOutputFramesPerSecond = JNIEnv.GetMethodID (class_ref, "getVideoOutputFramesPerSecond", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getVideoOutputFramesPerSecond);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoSarDen;
		public override unsafe int VideoSarDen {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoSarDen' and count(parameter)=0]"
			[Register ("getVideoSarDen", "()I", "GetGetVideoSarDenHandler")]
			get {
				if (id_getVideoSarDen == IntPtr.Zero)
					id_getVideoSarDen = JNIEnv.GetMethodID (class_ref, "getVideoSarDen", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoSarDen);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoSarNum;
		public override unsafe int VideoSarNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoSarNum' and count(parameter)=0]"
			[Register ("getVideoSarNum", "()I", "GetGetVideoSarNumHandler")]
			get {
				if (id_getVideoSarNum == IntPtr.Zero)
					id_getVideoSarNum = JNIEnv.GetMethodID (class_ref, "getVideoSarNum", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoSarNum);
				} finally {
				}
			}
		}

		static IntPtr id_getVideoWidth;
		public override unsafe int VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getVideoWidth' and count(parameter)=0]"
			[Register ("getVideoWidth", "()I", "GetGetVideoWidthHandler")]
			get {
				if (id_getVideoWidth == IntPtr.Zero)
					id_getVideoWidth = JNIEnv.GetMethodID (class_ref, "getVideoWidth", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVideoWidth);
				} finally {
				}
			}
		}

		static IntPtr id__prepareAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='_prepareAsync' and count(parameter)=0]"
		[Register ("_prepareAsync", "()V", "")]
		public unsafe void _prepareAsync ()
		{
			if (id__prepareAsync == IntPtr.Zero)
				id__prepareAsync = JNIEnv.GetMethodID (class_ref, "_prepareAsync", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id__prepareAsync);
			} finally {
			}
		}

		static IntPtr id_deselectTrack_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='deselectTrack' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deselectTrack", "(I)V", "")]
		public unsafe void DeselectTrack (int p0)
		{
			if (id_deselectTrack_I == IntPtr.Zero)
				id_deselectTrack_I = JNIEnv.GetMethodID (class_ref, "deselectTrack", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deselectTrack_I, __args);
			} finally {
			}
		}

		static IntPtr id_getColorFormatName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getColorFormatName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColorFormatName", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetColorFormatName (int p0)
		{
			if (id_getColorFormatName_I == IntPtr.Zero)
				id_getColorFormatName_I = JNIEnv.GetStaticMethodID (class_ref, "getColorFormatName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getColorFormatName_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getSelectedTrack_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getSelectedTrack' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSelectedTrack", "(I)I", "")]
		public unsafe int GetSelectedTrack (int p0)
		{
			if (id_getSelectedTrack_I == IntPtr.Zero)
				id_getSelectedTrack_I = JNIEnv.GetMethodID (class_ref, "getSelectedTrack", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedTrack_I, __args);
			} finally {
			}
		}

		static IntPtr id_getSpeed_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getSpeed", "(F)F", "")]
		public unsafe float GetSpeed (float p0)
		{
			if (id_getSpeed_F == IntPtr.Zero)
				id_getSpeed_F = JNIEnv.GetMethodID (class_ref, "getSpeed", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getSpeed_F, __args);
			} finally {
			}
		}

		static IntPtr id_getTrackInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='getTrackInfo' and count(parameter)=0]"
		[Register ("getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/IjkTrackInfo;", "")]
		public unsafe global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo[] GetTrackInfo ()
		{
			if (id_getTrackInfo == IntPtr.Zero)
				id_getTrackInfo = JNIEnv.GetMethodID (class_ref, "getTrackInfo", "()[Ltv/danmaku/ijk/media/player/misc/IjkTrackInfo;");
			try {
				return (global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackInfo), JniHandleOwnership.TransferLocalRef, typeof (global::TV.Danmaku.Ijk.Media.Player.Misc.IjkTrackInfo));
			} finally {
			}
		}

		static IntPtr id_httphookReconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='httphookReconnect' and count(parameter)=0]"
		[Register ("httphookReconnect", "()V", "")]
		public unsafe void HttphookReconnect ()
		{
			if (id_httphookReconnect == IntPtr.Zero)
				id_httphookReconnect = JNIEnv.GetMethodID (class_ref, "httphookReconnect", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_httphookReconnect);
			} finally {
			}
		}

		static IntPtr id_loadLibrariesOnce_Ltv_danmaku_ijk_media_player_IjkLibLoader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='loadLibrariesOnce' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkLibLoader']]"
		[Register ("loadLibrariesOnce", "(Ltv/danmaku/ijk/media/player/IjkLibLoader;)V", "")]
		public static unsafe void LoadLibrariesOnce (global::TV.Danmaku.Ijk.Media.Player.IIjkLibLoader p0)
		{
			if (id_loadLibrariesOnce_Ltv_danmaku_ijk_media_player_IjkLibLoader_ == IntPtr.Zero)
				id_loadLibrariesOnce_Ltv_danmaku_ijk_media_player_IjkLibLoader_ = JNIEnv.GetStaticMethodID (class_ref, "loadLibrariesOnce", "(Ltv/danmaku/ijk/media/player/IjkLibLoader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loadLibrariesOnce_Ltv_danmaku_ijk_media_player_IjkLibLoader_, __args);
			} finally {
			}
		}

		static IntPtr id_native_profileBegin_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='native_profileBegin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("native_profileBegin", "(Ljava/lang/String;)V", "")]
		public static unsafe void Native_profileBegin (string p0)
		{
			if (id_native_profileBegin_Ljava_lang_String_ == IntPtr.Zero)
				id_native_profileBegin_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "native_profileBegin", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_native_profileBegin_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_native_profileEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='native_profileEnd' and count(parameter)=0]"
		[Register ("native_profileEnd", "()V", "")]
		public static unsafe void Native_profileEnd ()
		{
			if (id_native_profileEnd == IntPtr.Zero)
				id_native_profileEnd = JNIEnv.GetStaticMethodID (class_ref, "native_profileEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_native_profileEnd);
			} finally {
			}
		}

		static IntPtr id_native_setLogLevel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='native_setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("native_setLogLevel", "(I)V", "")]
		public static unsafe void Native_setLogLevel (int p0)
		{
			if (id_native_setLogLevel_I == IntPtr.Zero)
				id_native_setLogLevel_I = JNIEnv.GetStaticMethodID (class_ref, "native_setLogLevel", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_native_setLogLevel_I, __args);
			} finally {
			}
		}

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "")]
		public override unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
			} finally {
			}
		}

		static IntPtr id_prepareAsync;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='prepareAsync' and count(parameter)=0]"
		[Register ("prepareAsync", "()V", "")]
		public override unsafe void PrepareAsync ()
		{
			if (id_prepareAsync == IntPtr.Zero)
				id_prepareAsync = JNIEnv.GetMethodID (class_ref, "prepareAsync", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareAsync);
			} finally {
			}
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public override unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			} finally {
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public override unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
			} finally {
			}
		}

		static IntPtr id_seekTo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "")]
		public override unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
			} finally {
			}
		}

		static IntPtr id_selectTrack_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='selectTrack' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("selectTrack", "(I)V", "")]
		public unsafe void SelectTrack (int p0)
		{
			if (id_selectTrack_I == IntPtr.Zero)
				id_selectTrack_I = JNIEnv.GetMethodID (class_ref, "selectTrack", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectTrack_I, __args);
			} finally {
			}
		}

		static IntPtr id_setAndroidIOCallback_Ltv_danmaku_ijk_media_player_misc_IAndroidIO_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setAndroidIOCallback' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.misc.IAndroidIO']]"
		[Register ("setAndroidIOCallback", "(Ltv/danmaku/ijk/media/player/misc/IAndroidIO;)V", "")]
		public unsafe void SetAndroidIOCallback (global::TV.Danmaku.Ijk.Media.Player.Misc.IAndroidIO p0)
		{
			if (id_setAndroidIOCallback_Ltv_danmaku_ijk_media_player_misc_IAndroidIO_ == IntPtr.Zero)
				id_setAndroidIOCallback_Ltv_danmaku_ijk_media_player_misc_IAndroidIO_ = JNIEnv.GetMethodID (class_ref, "setAndroidIOCallback", "(Ltv/danmaku/ijk/media/player/misc/IAndroidIO;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAndroidIOCallback_Ltv_danmaku_ijk_media_player_misc_IAndroidIO_, __args);
			} finally {
			}
		}

		static IntPtr id_setAudioStreamType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setAudioStreamType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioStreamType", "(I)V", "")]
		public override unsafe void SetAudioStreamType (int p0)
		{
			if (id_setAudioStreamType_I == IntPtr.Zero)
				id_setAudioStreamType_I = JNIEnv.GetMethodID (class_ref, "setAudioStreamType", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioStreamType_I, __args);
			} finally {
			}
		}

		static IntPtr id_setCacheShare_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setCacheShare' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCacheShare", "(I)V", "")]
		public unsafe void SetCacheShare (int p0)
		{
			if (id_setCacheShare_I == IntPtr.Zero)
				id_setCacheShare_I = JNIEnv.GetMethodID (class_ref, "setCacheShare", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCacheShare_I, __args);
			} finally {
			}
		}

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public override unsafe void SetDataSource (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_setDataSource_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static IntPtr id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setDataSource", "(Landroid/content/Context;Landroid/net/Uri;Ljava/util/Map;)V", "")]
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Landroid_content_Context_Landroid_net_Uri_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setDataSource_Ljava_io_FileDescriptor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setDataSource' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register ("setDataSource", "(Ljava/io/FileDescriptor;)V", "")]
		public override unsafe void SetDataSource (global::Java.IO.FileDescriptor p0)
		{
			if (id_setDataSource_Ljava_io_FileDescriptor_ == IntPtr.Zero)
				id_setDataSource_Ljava_io_FileDescriptor_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/io/FileDescriptor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_io_FileDescriptor_, __args);
			} finally {
			}
		}

		static IntPtr id_setDataSource_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setDataSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setDataSource", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe void SetDataSource (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_setDataSource_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_setDataSource_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setDataSource", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDataSource_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setDisplay_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setDisplay", "(Landroid/view/SurfaceHolder;)V", "")]
		public override unsafe void SetDisplay (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_setDisplay_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_setDisplay_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "setDisplay", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_Landroid_view_SurfaceHolder_, __args);
			} finally {
			}
		}

		static IntPtr id_setKeepInBackground_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setKeepInBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setKeepInBackground", "(Z)V", "")]
		public override unsafe void SetKeepInBackground (bool p0)
		{
			if (id_setKeepInBackground_Z == IntPtr.Zero)
				id_setKeepInBackground_Z = JNIEnv.GetMethodID (class_ref, "setKeepInBackground", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeepInBackground_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setLogEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setLogEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLogEnabled", "(Z)V", "")]
		public override unsafe void SetLogEnabled (bool p0)
		{
			if (id_setLogEnabled_Z == IntPtr.Zero)
				id_setLogEnabled_Z = JNIEnv.GetMethodID (class_ref, "setLogEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setOnControlMessageListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnControlMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setOnControlMessageListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkMediaPlayer.OnControlMessageListener']]"
		[Register ("setOnControlMessageListener", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer$OnControlMessageListener;)V", "")]
		public unsafe void SetOnControlMessageListener (global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListener p0)
		{
			if (id_setOnControlMessageListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnControlMessageListener_ == IntPtr.Zero)
				id_setOnControlMessageListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnControlMessageListener_ = JNIEnv.GetMethodID (class_ref, "setOnControlMessageListener", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer$OnControlMessageListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnControlMessageListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnControlMessageListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnMediaCodecSelectListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnMediaCodecSelectListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setOnMediaCodecSelectListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkMediaPlayer.OnMediaCodecSelectListener']]"
		[Register ("setOnMediaCodecSelectListener", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer$OnMediaCodecSelectListener;)V", "")]
		public unsafe void SetOnMediaCodecSelectListener (global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListener p0)
		{
			if (id_setOnMediaCodecSelectListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnMediaCodecSelectListener_ == IntPtr.Zero)
				id_setOnMediaCodecSelectListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnMediaCodecSelectListener_ = JNIEnv.GetMethodID (class_ref, "setOnMediaCodecSelectListener", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer$OnMediaCodecSelectListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnMediaCodecSelectListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnMediaCodecSelectListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnNativeInvokeListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnNativeInvokeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setOnNativeInvokeListener' and count(parameter)=1 and parameter[1][@type='tv.danmaku.ijk.media.player.IjkMediaPlayer.OnNativeInvokeListener']]"
		[Register ("setOnNativeInvokeListener", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer$OnNativeInvokeListener;)V", "")]
		public unsafe void SetOnNativeInvokeListener (global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListener p0)
		{
			if (id_setOnNativeInvokeListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnNativeInvokeListener_ == IntPtr.Zero)
				id_setOnNativeInvokeListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnNativeInvokeListener_ = JNIEnv.GetMethodID (class_ref, "setOnNativeInvokeListener", "(Ltv/danmaku/ijk/media/player/IjkMediaPlayer$OnNativeInvokeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnNativeInvokeListener_Ltv_danmaku_ijk_media_player_IjkMediaPlayer_OnNativeInvokeListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setOption_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setOption' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setOption", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetOption (int p0, string p1, string p2)
		{
			if (id_setOption_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setOption_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOption", "(ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOption_ILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setOption_ILjava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setOption' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("setOption", "(ILjava/lang/String;J)V", "")]
		public unsafe void SetOption (int p0, string p1, long p2)
		{
			if (id_setOption_ILjava_lang_String_J == IntPtr.Zero)
				id_setOption_ILjava_lang_String_J = JNIEnv.GetMethodID (class_ref, "setOption", "(ILjava/lang/String;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOption_ILjava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setScreenOnWhilePlaying_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setScreenOnWhilePlaying' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScreenOnWhilePlaying", "(Z)V", "")]
		public override unsafe void SetScreenOnWhilePlaying (bool p0)
		{
			if (id_setScreenOnWhilePlaying_Z == IntPtr.Zero)
				id_setScreenOnWhilePlaying_Z = JNIEnv.GetMethodID (class_ref, "setScreenOnWhilePlaying", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScreenOnWhilePlaying_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setSpeed_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSpeed", "(F)V", "")]
		public unsafe void SetSpeed (float p0)
		{
			if (id_setSpeed_F == IntPtr.Zero)
				id_setSpeed_F = JNIEnv.GetMethodID (class_ref, "setSpeed", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSpeed_F, __args);
			} finally {
			}
		}

		static IntPtr id_setSurface_Landroid_view_Surface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("setSurface", "(Landroid/view/Surface;)V", "")]
		public override unsafe void SetSurface (global::Android.Views.Surface p0)
		{
			if (id_setSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_setSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "setSurface", "(Landroid/view/Surface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurface_Landroid_view_Surface_, __args);
			} finally {
			}
		}

		static IntPtr id_setVolume_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setVolume' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setVolume", "(FF)V", "")]
		public override unsafe void SetVolume (float p0, float p1)
		{
			if (id_setVolume_FF == IntPtr.Zero)
				id_setVolume_FF = JNIEnv.GetMethodID (class_ref, "setVolume", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_FF, __args);
			} finally {
			}
		}

		static IntPtr id_setWakeMode_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='setWakeMode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setWakeMode", "(Landroid/content/Context;I)V", "")]
		public override unsafe void SetWakeMode (global::Android.Content.Context p0, int p1)
		{
			if (id_setWakeMode_Landroid_content_Context_I == IntPtr.Zero)
				id_setWakeMode_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "setWakeMode", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWakeMode_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "")]
		public override unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
			} finally {
			}
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='tv.danmaku.ijk.media.player']/class[@name='IjkMediaPlayer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public override unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
			} finally {
			}
		}

#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListener"
		WeakReference weak_implementor_ControlMessage;
		global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListenerImplementor ImplControlMessage {
			get {
				if (weak_implementor_ControlMessage == null || !weak_implementor_ControlMessage.IsAlive)
					return null;
				return weak_implementor_ControlMessage.Target as global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListenerImplementor;
			}
			set { weak_implementor_ControlMessage = new WeakReference (value, true); }
		}

		public global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.ControlMessageHandler ControlMessage {
			get {
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListenerImplementor impl = ImplControlMessage;
				return impl == null ? null : impl.Handler;
			}
			set {
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListenerImplementor impl = ImplControlMessage;
				if (impl == null) {
					impl = new global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListenerImplementor ();
					ImplControlMessage = impl;
				} else
					impl.Handler = value;
			}
		}

		WeakReference weak_implementor_SetOnControlMessageListener;

		global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListenerImplementor __CreateIOnControlMessageListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnControlMessageListenerImplementor ();
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListener"
		WeakReference weak_implementor_MediaCodecSelect;
		global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListenerImplementor ImplMediaCodecSelect {
			get {
				if (weak_implementor_MediaCodecSelect == null || !weak_implementor_MediaCodecSelect.IsAlive)
					return null;
				return weak_implementor_MediaCodecSelect.Target as global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListenerImplementor;
			}
			set { weak_implementor_MediaCodecSelect = new WeakReference (value, true); }
		}

		public global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.MediaCodecSelectHandler MediaCodecSelect {
			get {
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListenerImplementor impl = ImplMediaCodecSelect;
				return impl == null ? null : impl.Handler;
			}
			set {
				global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListenerImplementor impl = ImplMediaCodecSelect;
				if (impl == null) {
					impl = new global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListenerImplementor ();
					ImplMediaCodecSelect = impl;
				} else
					impl.Handler = value;
			}
		}

		WeakReference weak_implementor_SetOnMediaCodecSelectListener;

		global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListenerImplementor __CreateIOnMediaCodecSelectListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnMediaCodecSelectListenerImplementor ();
		}
#endregion
#region "Event implementation for TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListener"
		public event EventHandler<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.NativeInvokeEventArgs> NativeInvoke {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListener, global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListenerImplementor>(
						ref weak_implementor_SetOnNativeInvokeListener,
						__CreateIOnNativeInvokeListenerImplementor,
						SetOnNativeInvokeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListener, global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListenerImplementor>(
						ref weak_implementor_SetOnNativeInvokeListener,
						global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListenerImplementor.__IsEmpty,
						__v => SetOnNativeInvokeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnNativeInvokeListener;

		global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListenerImplementor __CreateIOnNativeInvokeListenerImplementor ()
		{
			return new global::TV.Danmaku.Ijk.Media.Player.IjkMediaPlayer.IOnNativeInvokeListenerImplementor (this);
		}
#endregion
	}
}
